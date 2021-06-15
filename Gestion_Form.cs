using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShopfyDBLibrary;



namespace Gestion
{
    public partial class Gestion_Form : Form
    {
        private Data_class dataClass = new Data_class();
        private DB db = new DB();
        private string currentTable, currentSection;
        private bool modify,delete;
        
   

        public Gestion_Form()
        {
            InitializeComponent();
        }

        private void loadAdminRequirements()
        {
            buttonDeleteProduct.Enabled = true;
            buttonusers.Visible = true;
            storageButtonMenu.Visible = true;


        }
        //-- Load datos de tabla
        private void LoadUsers(string campo, string where, string where2)
        {
            dataGridView1.DataSource = db.userSelection(campo, where, where2);
            dataGridView1.ClearSelection();
            currentTable = "user";
        }

        private void LoadProducts(string campo, string where, string where2)
        {
            dataGridView1.DataSource = db.productSelection(campo, where, where2);
            dataGridView1.ClearSelection();
            currentTable = "products";
        }
        private void LoadSales(string campo, string where, string where2)
        {
            dataGridView1.DataSource = db.salesSelection(campo, where, where2);
            dataGridView1.ClearSelection();
            currentTable = "sales";
        }
        private void LoadSalesDetail(string campo, string where, string where2) {
            dataGridView1.DataSource = db.sales_detailSelection(campo, where, where2);
            dataGridView1.ClearSelection();
            currentTable = "salesDetails";
        }
        private void LoadCategories(string campo, string where)
        {
            dataGridView1.DataSource = db.categorySelection(campo, where);
            dataGridView1.ClearSelection();
            currentTable = "category";
        }

        private void LoadSubCategories(string campo, string where)
        {
            dataGridView1.DataSource = db.subcategorySelection(campo, where);
            dataGridView1.ClearSelection();
            currentTable = "subcategory";
        }

        private void LoadStorage(string campo, string where, string where2)
        {
            dataGridView1.DataSource = db.storageSelection(campo, where, where2);
            dataGridView1.ClearSelection();
            currentTable = "storage";
        }
        private void LoadStorageDetails(string campo, string where, string where2)
        {

            dataGridView1.DataSource = db.storage_detailSelection(campo, where, where2);
            dataGridView1.ClearSelection();
            currentTable = "detailstorage";
        }

        //Cargar datos combobox categorias
        private void loadpropietiesCombobox()
        {
            //-- Cargar datos combo box de categoria        
            comboboxCategory.DataSource = db.categorySelection("", "");
            comboboxCategory.DisplayMember = "CATEGORY_ID";
            //comboboxCategory.DisplayMember = "NAME";
            comboboxCategory.ValueMember = "CATEGORY_ID";
            //-- Cargar datos combo box de Subcategoria 
            comboboxSubcategory.DataSource = db.subcategorySelection("", "");
            comboboxSubcategory.DisplayMember = "SUBCATEGORY_ID";
            //comboboxSubcategory.DisplayMember = "NAME";
            comboboxSubcategory.ValueMember = "SUBCATEGORY_ID";

        }
        //FILTRO:
        private void loadUserFilterCombobox()
        {
            string[] Filtertable = new string[] {"USER_ID","USERNAME", "CREATION_DATE", "ROL"};
            clearFilter(Filtertable);
        }
        private void loadProductFilterCombobox()
        {
            string[] Filtertable = new string[] { "PRODUCT_ID", "NAME", "PRICE", "STOCK", "CATEGORY_ID", "SUBCATEGORY_ID" };
            clearFilter(Filtertable);
        }
        private void loadSalesFilterCombobox()
        {
            string[] Filtertable = new string[] {"SALE_ID", "PRICE", "GENERATION_DATE"};
            clearFilter(Filtertable);
        }
        private void loadDetailSalesFilterCombobox()
        {
            string[] Filtertable = new string[] {"SALE_ID", "PRICE", "PRODUCT_ID", "AMOUNT"};
            clearFilter(Filtertable);
        }
        private void LoadCategoriesFilterCombobox()
        {
            string[] Filtertable = new string[] {"CATEGORY_ID", "NAME" };
            clearFilter(Filtertable);
        }
        private void LoadSubcategoriesFilterCombobox()
        {
            string[] Filtertable = new string[] { "SUBCATEGORY_ID", "NAME" };
            clearFilter(Filtertable);
        }
        private void LoadStorageFilterCombobox()
        {
            string[] Filtertable = new string[] { "USER_ID", "HOUSE_ID" };
            clearFilter(Filtertable);
        }
        private void LoadStorageDetailsilterCombobox()
        {
            string[] Filtertable = new string[] { "PRODUCT_ID", "HOUSE_ID", "STOCK", "ADQUISITION_DATE","NAME","BRAND","TOTAL_PRICE" };
            clearFilter(Filtertable);
        }
        private void FilterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            where1TextBox.Clear();
            where2Textbox.Clear();
            if (FilterCombobox.SelectedItem.ToString().Contains("PRICE"))
            {
                where2Textbox.Visible = true;
                where2label.Visible = true;
                where1label.Text = "Min Price";
                where2label.Text = "Max Price";
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                where1TextBox.Visible = true;
                where1label.Visible = true;
                DateLabel1.Visible = false;
                DataLabel2.Visible = false;
            }
            else if (FilterCombobox.SelectedItem.ToString().Contains("DATE"))
            {

                where2Textbox.Visible = false;
                where2label.Visible = false;
                where1label.Text = "Where 1";
                where2label.Text = "Where 2";
                where1TextBox.Visible = false;
                where1label.Visible = false;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                DateLabel1.Visible = true;
                DataLabel2.Visible = true;
            }
            else
            {
                where2Textbox.Visible = false;
                where2label.Visible = false;
                where1label.Text = "Where 1";
                where2label.Text = "Where 2";
                where1TextBox.Visible = true;
                where1label.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                DateLabel1.Visible = false;
                DataLabel2.Visible = false;
            }
        }

        private void FilterValidatorString(object sender, KeyPressEventArgs e)
        {
            if (FilterCombobox.SelectedItem.ToString().Contains("PRICE")) dataClass.check_onlynumbersWithComa(sender, e);
            if (FilterCombobox.SelectedItem.ToString().Equals("STOCK")
               || FilterCombobox.SelectedItem.ToString().Contains("ID")) dataClass.check_onlynumbers(sender, e);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            float price1;
            float price2;
            try
            {
                switch (currentTable)
                {
                    case "user":
                        if (FilterCombobox.SelectedItem.ToString().Contains("DATE")) {
                            LoadUsers(FilterCombobox.SelectedItem.ToString(), dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
                        }
                        else
                        {
                            LoadUsers(FilterCombobox.SelectedItem.ToString(), where1TextBox.Text, where2Textbox.Text);
                        }
                        break;
                    case "products":
                        if (FilterCombobox.SelectedItem.ToString().Contains("PRICE"))
                        {
                            if (float.TryParse(where1TextBox.Text, out price1) && float.TryParse(where2Textbox.Text, out price2))
                            {
                                price1 = (float)Math.Round(price1, 2);
                                price2 = (float)Math.Round(price2, 2);

                                if (price1 < price2)
                                {
                                    LoadProducts(FilterCombobox.SelectedItem.ToString(),price1.ToString(), price2.ToString());
                                }
                                else {
                                    MessageBox.Show("FIRST PRICE MUST BE BIGGER");
                                }                             
                            }
                            else {
                                MessageBox.Show("PRICE NOT VALID");
                            }
                        }
                        else { 
                        LoadProducts(FilterCombobox.SelectedItem.ToString(), where1TextBox.Text, where2Textbox.Text);
                             }
                        break;
                    case "sales":
                        if (FilterCombobox.SelectedItem.ToString().Contains("DATE"))
                        {
                            LoadSales(FilterCombobox.SelectedItem.ToString(), dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
                        }
                        else if (FilterCombobox.SelectedItem.ToString().Contains("PRICE"))
                        {
                            if (float.TryParse(where1TextBox.Text, out price1) && float.TryParse(where2Textbox.Text, out price2))
                            {
                                price1 = (float)Math.Round(price1, 2);
                                price2 = (float)Math.Round(price2, 2);

                                if (price1 < price2)
                                {
                                    LoadSales(FilterCombobox.SelectedItem.ToString(), price1.ToString(), price2.ToString());
                                }
                                else
                                {
                                    MessageBox.Show("FIRST PRICE MUST BE BIGGER");
                                }
                            }
                            else
                            {
                                MessageBox.Show("PRICE NOT VALID");
                            }
                        }
                        else
                        {
                            LoadSales(FilterCombobox.SelectedItem.ToString(), where1TextBox.Text, where2Textbox.Text);
                        }

                       
                        break;
                    case "salesDetails":

                        if (FilterCombobox.SelectedItem.ToString().Contains("PRICE"))
                        {
                            if (float.TryParse(where1TextBox.Text, out price1) && float.TryParse(where2Textbox.Text, out price2))
                            {
                                price1 = (float)Math.Round(price1, 2);
                                price2 = (float)Math.Round(price2, 2);

                                if (price1 < price2)
                                {
                                    LoadSalesDetail(FilterCombobox.SelectedItem.ToString(), price1.ToString(), price2.ToString());
                                }
                                else
                                {
                                    MessageBox.Show("FIRST PRICE MUST BE BIGGER");
                                }

                            }
                            else
                            {
                                MessageBox.Show("PRICE NOT VALID");
                            }
                        }
                        else
                        {
                            LoadSalesDetail(FilterCombobox.SelectedItem.ToString(), where1TextBox.Text, where2Textbox.Text);
                        }
                            
                        break;
                    case "category":
                        LoadCategories(FilterCombobox.SelectedItem.ToString(), where1TextBox.Text);
                        break;
                    case "subcategory":
                        LoadSubCategories(FilterCombobox.SelectedItem.ToString(), where1TextBox.Text);
                        break;
                    case "storage":
                        LoadStorage(FilterCombobox.SelectedItem.ToString(), where1TextBox.Text, where2Textbox.Text);
                        break;
                    case "detailstorage":
                        if (FilterCombobox.SelectedItem.ToString().Contains("DATE"))
                        {
                            LoadStorageDetails(FilterCombobox.SelectedItem.ToString(), dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
                        }
                        else if (FilterCombobox.SelectedItem.ToString().Contains("PRICE"))
                        {
                            if (float.TryParse(where1TextBox.Text, out price1) && float.TryParse(where2Textbox.Text, out price2))
                            {
                                price1 = (float)Math.Round(price1, 2);
                                price2 = (float)Math.Round(price2, 2);

                                if (price1 < price2)
                                {
                                    LoadStorageDetails(FilterCombobox.SelectedItem.ToString(), price1.ToString(), price2.ToString());
                                }
                                else
                                {
                                    MessageBox.Show("FIRST PRICE MUST BE BIGGER");
                                }

                            }
                            else
                            {
                                MessageBox.Show("PRICE NOT VALID");
                            }
                        }
                        else
                        {
                            LoadStorageDetails(FilterCombobox.SelectedItem.ToString(), where1TextBox.Text, where2Textbox.Text);
                        }
                    
                        break;
                }
            }
            catch
            {
                MessageBox.Show("ERROR");   
            }
        }
        //FIN FILTRO


        //conexion bd
        private void conectionDb()
        {
            try
            {
                db.startConnection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //-- Datos iniciales form
        private void Gestion_Form_Load_1(object sender, EventArgs e)
        {
            conectionDb();
            chek.Start();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            panelUsersMenuLeft.Visible = false;
            panelProductsMenuLeft.Visible = false;
            panelSalesMenuLeft.Visible = false;
            panelCategoryMenuLeft.Visible = false;
            panelStorage.Visible = false;
            comboboxCategory.SelectedIndex = 0;
            comboboxSubcategory.SelectedIndex = 0;
            Roles.SelectedIndex = 0;
            userCurrentlabel.Text = Data_class.currentUser;

            loadpropietiesCombobox();

            if (Data_class.admin)
            {
                loadAdminRequirements();
        
            }

         

        }

        //user 
        private void createUser_Click(object sender, EventArgs e)
        {

            switch (userButon.Text)
            {

                case "Create":
                    if (string.IsNullOrWhiteSpace(userUsername.Text) && string.IsNullOrWhiteSpace(userPassword.Text) && string.IsNullOrWhiteSpace(emailUser.Text))
                    {
                        MessageBox.Show("Fields can't be empty!");
                    }
                    else
                    {
                        string email = emailUser.Text;
                        if (dataClass.IsValidEmail(email))
                        {
                            string password = userPassword.Text;
                            DateTime dateTimenow = DateTime.Now; 
                            password = dataClass.hashpwd(password,dateTimenow.ToString());
                            string user = userUsername.Text;
                            string rol = Roles.SelectedItem.ToString();

                            if (db.userInsert(user, password, email, rol,0))
                            {
                                MessageBox.Show("USER " + user + " INSERTED");
                                LoadUsers("", "","");
                                cleanData();
                            }
                            else {
                                MessageBox.Show("USER " + user + " NOT INSERTED");
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Email can't be like that");
                        }

                    }
                    break;
                case "Modify":

                  
                    if (string.IsNullOrWhiteSpace(userUsername.Text) && string.IsNullOrWhiteSpace(userPassword.Text) && string.IsNullOrWhiteSpace(emailUser.Text))
                    {
                        MessageBox.Show("Fields can't be empty!");
                    }
                    else
                    {
                        string email = emailUser.Text;
                        if (dataClass.IsValidEmail(email))
                        {
                            string user = userUsername.Text;
                            string password = userPassword.Text;
                            string creation_date = db.getUserDate(idUser.Text);

                            password = dataClass.hashpwd(password, creation_date);
                            string rol = Roles.SelectedItem.ToString();

                            if (db.userUpdate(Int32.Parse(idUser.Text), user, password, email, rol,0))
                            {
                                MessageBox.Show("USER " + user + " UPDATED");
                                LoadUsers("", "","");
                                cleanData();
                            }
                            else {
                                MessageBox.Show("USER " + user + " CAN'T UPDATED");
                            }
                          
                        }
                        else
                        {
                            MessageBox.Show("VERIFY THE EMAIL!");

                        }

                    }
                    break;

                case "Delete":

                    if (db.userDelete(Int32.Parse(idUser.Text)))
                    {
                        MessageBox.Show("User deleted");
                        LoadUsers("", "","");
                    }
                    else {
                        MessageBox.Show("User not deleted");
                    }
                   
                    break;
            }

        }

        //-- Producto 
        private void createProduct_onClick(object sender, EventArgs e)
        {
            float price;
            switch (butonProduct.Text)
            {

                case "Create":
                    if (string.IsNullOrWhiteSpace(nameProduct.Text) && string.IsNullOrWhiteSpace(stokbox.Text) && string.IsNullOrWhiteSpace(brandbox.Text) && string.IsNullOrWhiteSpace(pricebox.Text))
                    {
                        MessageBox.Show("Fields can't be empty!");
                    }
                    else
                    {
                        if (float.TryParse(pricebox.Text, out price))
                        {
                            price = (float) Math.Round(price,2);


                            if (db.productInsert(nameProduct.Text, 
                                brandbox.Text,
                                price, 
                                Int32.Parse(stokbox.Text), 
                                Int32.Parse(comboboxCategory.Text),
                                Int32.Parse(comboboxSubcategory.Text)))
                            {
                                MessageBox.Show("PRODUCT " + nameProduct.Text + " INSERTED");
                                LoadProducts("", "","");
                                cleanData();
                            }
                            else
                            {
                                MessageBox.Show("PRODUCT " + nameProduct.Text + " NOT INSERTED");
                            }
                        }
                        else {
                            MessageBox.Show("Price not valid");
                        }
                    }
                    break;
                case "Modify":
                    if (string.IsNullOrWhiteSpace(idUser.Text) && string.IsNullOrWhiteSpace(nameProduct.Text) && string.IsNullOrWhiteSpace(stokbox.Text) && string.IsNullOrWhiteSpace(brandbox.Text) && string.IsNullOrWhiteSpace(pricebox.Text))

                    {
                        MessageBox.Show("Fields can't be empty!");
                    }
                    else
                    {
                        if (float.TryParse(pricebox.Text, out price))
                        {
                            price = (float)Math.Round(price, 2);

                        
                            if (db.productUpdate(Int32.Parse(idProduct.Text),
                                nameProduct.Text, brandbox.Text,
                               price, Int32.Parse(stokbox.Text),
                                Int32.Parse(comboboxCategory.Text),
                                Int32.Parse(comboboxSubcategory.Text)))
                            {
                                MessageBox.Show("PRODUCT " + nameProduct.Text + " UPDATED");
                                LoadProducts("", "", "");
                                cleanData();
                            }
                            else
                            {
                                MessageBox.Show("PRODUCT NOT UPDATED");
                            }
                        }
                        else {
                            MessageBox.Show("Price not valid");
                        }
                    }
                    break;

                case "Delete":
                    if (!string.IsNullOrWhiteSpace(idProduct.Text))
                    {
                        if (db.productDelete(Int32.Parse(idProduct.Text))) {
                            LoadProducts("", "","");
                            cleanData();
                            MessageBox.Show("PRODUCT " + nameProduct.Text + " DELETED ");
                        }
                        else
                        {
                            MessageBox.Show("PRODUCT " + nameProduct.Text + " NOT DELETED ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID field can't be empty!");
                    }
                    break;
            }
        }

        //Categories
        private void createCategories_Click(object sender, EventArgs e)
        {
            if (currentTable.Equals("category"))
            {

                switch (createCategories.Text)
                {
                    case "Create":
                        if (!string.IsNullOrWhiteSpace(categoryName.Text))
                        {
                            if (db.categoryInsert(categoryName.Text))
                            {
                                MessageBox.Show("NEW CATEGORY ADDED");
                                LoadCategories("","");
                                loadpropietiesCombobox();
                                cleanData();
                            }
                            else
                            {
                                MessageBox.Show("CAN'T ADD A NEW CATEGORY");
                            }
                        }
                        else {
                            MessageBox.Show("FIELDS CAN BE EMPTY");
                        } 
                        break;
                    case "Modify":
                        if (!string.IsNullOrWhiteSpace(idCategories.Text) && !string.IsNullOrWhiteSpace(categoryName.Text))
                        {
                            if (db.categoryUpdate(Int32.Parse(idCategories.Text), categoryName.Text))
                            {
                                MessageBox.Show("CATEGORY UPDATED");
                                LoadCategories("", "");
                                loadpropietiesCombobox();
                                cleanData();
                            }
                            else
                            {
                                MessageBox.Show("CAN'T UPDATE");
                            }
                        }
                        else {
                            MessageBox.Show("FIELDS CAN BE EMPTY");
                        }
                         break;
                    case "Delete":
                        if (!string.IsNullOrWhiteSpace(idCategories.Text))
                        {

                            if (db.categoryDelete(Int32.Parse(idCategories.Text)))
                            {
                                MessageBox.Show("CATEGORY DELETED");
                                LoadCategories("", "");
                                loadpropietiesCombobox();
                                cleanData();
                            }
                            else
                            {
                                MessageBox.Show("CAN'T DELETE");
                            }
                        }
                        else {
                            MessageBox.Show("FIELDS CAN BE EMPTY");
                        }

                        break;
                }
            }
            else {

                switch (createCategories.Text)
                {
                    case "Create":
                        if (!string.IsNullOrWhiteSpace(subcategoryName.Text))
                        {
                            if (db.subcategoryInsert(subcategoryName.Text))
                            {
                                MessageBox.Show("SUBCATEGORY ADDED");
                                LoadSubCategories("", "");
                                loadpropietiesCombobox();
                                cleanData();
                            }
                            else {
                                MessageBox.Show("SUBCATEGORY NOT ADDED");
                            }
                        }
                        else {
                            MessageBox.Show("FIELDS CAN'T BE EMPTY");
                        }
                        break;
                    case "Modify":
                        if (!string.IsNullOrWhiteSpace(subcategoryName.Text)&&!string.IsNullOrWhiteSpace(idSubcategories.Text))
                        {

                            if (db.subcategoryUpdate(Int32.Parse(idSubcategories.Text), subcategoryName.Text))
                            {
                                MessageBox.Show("SUBCATEGORY UPDATED");
                                LoadSubCategories("", "");
                                loadpropietiesCombobox();
                                cleanData();
                            }
                            else
                            {
                                MessageBox.Show("SUBCATEGORY NOT UPDATED");
                            }
                        }
                        else
                        {
                            MessageBox.Show("FIELDS CAN'T BE EMPTY");
                        }
                        break;
                    case "Delete":
                        if (!string.IsNullOrWhiteSpace(idSubcategories.Text))
                        {
                            if (db.subcategoryDelete(Int32.Parse(idSubcategories.Text)))
                            {
                                MessageBox.Show("SUBCATEGORY DELETED");
                                LoadSubCategories("", "");
                                loadpropietiesCombobox();
                                cleanData();
                            }
                            else
                            {
                                MessageBox.Show("SUBCATEGORY NOT DELETED");
                            }
                        }
                        else
                        {
                            MessageBox.Show("FIELDS CAN'T BE EMPTY");
                        }
                        break;
                }

            }
        }

  

        //-- User Menu
        private void buttonCreateUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Create";
            
            userPanelvisisble();
            LoadUsers("", "","");
            enableUsers();
            modify = false;
            delete = false;
            cleanData();
            currentSection = "- Create users";
            InfoPanel();
            loadUserFilterCombobox();
  
        }


        private void buttonModifyUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Modify";
            MessageBox.Show("REMEMBER CHANGE PASWORD");
            userPanelvisisble();
            enableUsers();
            LoadUsers("", "","");
            modify = true;
            delete = false;
            cleanData();
            currentSection = "- Modify users";
            InfoPanel();
            loadUserFilterCombobox();
           
        }
        private void buttonDeleteUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Delete";
            DisableUsers();
            userPanelvisisble();
            LoadUsers("", "","");
            modify = false;
            delete = true;
            cleanData();
            currentSection = "- Delete users";
            InfoPanel();
            loadUserFilterCombobox();

        }


        //Product Menu
        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Create";
            productVisible();
            LoadProducts("", "","");
            enableProducts();
            modify = false;
            delete = false;
            cleanData();
            currentSection = "- Create product";
            InfoPanel();
            loadProductFilterCombobox();

        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Modify";
            productVisible();
            LoadProducts("", "","");
            enableProducts();
            modify = true;
            delete = false;
           currentSection = "- Modify product";
            InfoPanel();
            cleanData();
            loadProductFilterCombobox();
           
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Delete";
            productVisible();
            LoadProducts("", "","");
            modify = false;
            delete = true;
            cleanData();
            currentSection = "- Delete product";
            InfoPanel();
            DisableProducts();
            loadProductFilterCombobox();
            
        }

        
        //Sales menu
        private void buttonSalesselect_Click(object sender, EventArgs e)
        {
            modify = false;
            delete = false;
            cleanData();
            LoadSales("", "", "");
            defaultPanleVisible();
            currentSection = "- Select sales";
            InfoPanel();
            loadSalesFilterCombobox();
         
        }
        private void buttonSalesSelect_Click(object sender, EventArgs e)
        {
            //details Sales
            modify = false;
            delete = false;
            LoadSalesDetail("", "", "");
            cleanData();
            defaultPanleVisible();
            currentSection = "- Select detail of sales";
            InfoPanel();
            loadDetailSalesFilterCombobox();
         
        }

        
        //categories menu
        private void createCategry_Onclick(object sender, EventArgs e)
        {
            modify = false;
            delete = false;
            cleanData();
            categoriesPanelVisible();
            enableCategories();
            DisableSubcategories();
            LoadCategories("", "");
            currentSection = "- Create category";
            InfoPanel();
            createCategories.Text = "Create";
            LoadCategoriesFilterCombobox();
          
        }
        private void modifyCategory_Click(object sender, EventArgs e)
        {
            modify = true;
            delete = false;
            cleanData();
            enableCategories();
            DisableSubcategories();
            LoadCategories("", "");
            categoriesPanelVisible();
            currentSection = "- Modify category";
            InfoPanel();
            createCategories.Text = "Modify";
            LoadCategoriesFilterCombobox();
          
        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            modify = false;
            delete = true;
            cleanData();
            LoadCategories("", "");
            DisableSubcategories();
            DisableCategories();
            categoriesPanelVisible();
            currentSection = "- Delete category";
            InfoPanel();
            createCategories.Text = "Delete";
            LoadCategoriesFilterCombobox();
          
        }

        //Subcategory menu
        private void createSubcategory_Click(object sender, EventArgs e)
        {
            modify = false;
            delete = false;
            cleanData();
            categoriesPanelVisible();
            enableSubcategories();
            DisableCategories();
            LoadSubCategories("", "");
            createCategories.Text = "Create";
            currentSection = "- Create subcategory";
            InfoPanel();
            LoadSubcategoriesFilterCombobox();
            
        }

        private void modifySubcategory_Click(object sender, EventArgs e)
        {
            modify = true;
            delete = false;
            cleanData();
            categoriesPanelVisible();
            enableSubcategories();
            DisableCategories();
            LoadSubCategories("", "");
            createCategories.Text = "Modify";
            currentSection = "- Modify category";
            InfoPanel();
            LoadSubcategoriesFilterCombobox();
          
        }

        private void deleteSubcategory_Click(object sender, EventArgs e)
        {
            modify = false;
            delete = true;
            createCategories.Text = "Delete";
            cleanData();
            DisableCategories();
            DisableSubcategories();
            categoriesPanelVisible();
            LoadSubCategories("","");
            currentSection = "- Delete category";
            InfoPanel();
            LoadSubcategoriesFilterCombobox();
           
        }

        // STORAGE
        private void storageSelectButton_Click_1(object sender, EventArgs e)
        {
            modify = false;
            delete = false;
            cleanData();
            LoadStorage("", "","");
            currentSection = "- Select storage";
            InfoPanel();
            categoriesPanelVisible();
            LoadStorageFilterCombobox();
            
        }

        private void storageDetailButton_Click(object sender, EventArgs e)
        {
            modify = false;
            delete = false;
            cleanData();
            LoadStorageDetails("","","");
            currentSection = "- Select details storage";
            InfoPanel();
            categoriesPanelVisible();
            LoadStorageDetailsilterCombobox();
          
        }
      

        //Panel de informacion

        private void InfoPanel()
        {
            switch (currentTable)
            {
                case "user":
                    CurrentTableLabel.Text = "Users";
                    TableDescriptionLabel.Text = currentSection;
                    break;
                case "products":
                    CurrentTableLabel.Text = "Products";
                    TableDescriptionLabel.Text = currentSection;
                    break;
                case "sales":
                    CurrentTableLabel.Text = "Sales";
                    TableDescriptionLabel.Text = currentSection;
                    break;
                case "salesDetails":
                    CurrentTableLabel.Text = "Sales details";
                    TableDescriptionLabel.Text = currentSection;
                    break;
                case "category":
                    CurrentTableLabel.Text = "Category";
                    TableDescriptionLabel.Text = currentSection;
                    break;
                case "subcategory":
                    CurrentTableLabel.Text = "Subcategory";
                    TableDescriptionLabel.Text = currentSection;
                    break;
                case "storage":
                    CurrentTableLabel.Text = "Storage";
                    TableDescriptionLabel.Text = currentSection;
                    break;
                case "detailstorage":
                    CurrentTableLabel.Text = "Detail storage";
                    TableDescriptionLabel.Text = currentSection;
                    break;
            }
            
        }

        //row selected metodo
        private void rowSelected(object sender, DataGridViewCellEventArgs e)
        {

            if (modify)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                    switch (currentTable)
                    {

                        case "user":
                            userUsername.Text = row.Cells["USERNAME"].Value.ToString();
                            string password = row.Cells["EMAIL"].Value.ToString();                       
                            emailUser.Text = password;
                            idUser.Text = row.Cells["USER_ID"].Value.ToString();
                            break;

                        case "products":
                            nameProduct.Text = row.Cells["NAME"].Value.ToString();
                            stokbox.Text = row.Cells["STOCK"].Value.ToString();
                            pricebox.Text = row.Cells["PRICE"].Value.ToString();
                            brandbox.Text = row.Cells["BRAND"].Value.ToString();
                            idProduct.Text = row.Cells["PRODUCT_ID"].Value.ToString();

                            break;

                        case "category":

                            categoryName.Text = row.Cells["NAME"].Value.ToString();
                            idCategories.Text = row.Cells["CATEGORY_ID"].Value.ToString();
                            break;

                        case "subcategory":
                            subcategoryName.Text = row.Cells["NAME"].Value.ToString();
                            idSubcategories.Text = row.Cells["SUBCATEGORY_ID"].Value.ToString();
                            break;
                    }
                }
            }
        }

        //------ Mostrar menu---
        private void showSubmenu(Panel submenu)
        {

            if (submenu.Visible == false)
            {

                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }
        private void Users_Click(object sender, EventArgs e)
        {
            showSubmenu(panelUsersMenuLeft);

        }
        private void productsButton_Click(object sender, EventArgs e)
        {
            showSubmenu(panelProductsMenuLeft);
        }
        private void salesButton_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSalesMenuLeft);
        }
        private void categoryButton_Click(object sender, EventArgs e)
        {
            showSubmenu(panelCategoryMenuLeft);
        }
      
        private void storageButtonMenu_Click(object sender, EventArgs e)
        {
            showSubmenu(panelStorage);
        }
        //----------------------

        //Visibilidad panels
        private void userPanelvisisble()
        {
            panelUser.BringToFront();

        }
        private void productVisible()
        {
            panelProduct.BringToFront();
          
        }
        private void categoriesPanelVisible() {
            panelCategories.BringToFront();
          
        }
        private void defaultPanleVisible() {
            DefaultPanel.BringToFront();
        }


        //llamada a metodos auxiliares
        //-- Text box validators
        
        private void numbersAndcoma(object sender, KeyPressEventArgs e)
        {
            dataClass.check_onlynumbersWithComa(sender, e);
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            dataClass.check_onlynumbers(sender, e);
        }
        //
        private void ReloadTable_Click(object sender, EventArgs e)
        {
            switch (currentTable)
            {
                case "user":                                    
                        LoadUsers("","","");
                    
                    break;
                case "products":
                    LoadProducts("", "", "");
                    break;
                case "sales":
                    
                        LoadSales("", "", "");
                    
                    break;
                case "salesDetails":
                    LoadSalesDetail("", "", "");
                    break;
                case "category":
                    LoadCategories("", "");
                    break;
                case "subcategory":
                    LoadSubCategories("", "");
                    break;
                case "storage":
                    LoadStorage("", "", "");
                    break;
                case "detailstorage":
                 
                    
                        LoadStorageDetails("", "", "");
                    
                    break;
            }
        }

        //Verificador
        private void chek_Tick(object sender, EventArgs e)
        {
            if (modify || delete)
            {
                switch (currentTable)
                {

                    case "user":
                        //user
                        idLabelUser.Visible = true;
                        idUser.Visible= true;
                        if (modify) {
                            idUser.Enabled = false;
                        }
                        if (delete) {
                            idUser.Enabled = true;
                        }
                        break;

                    case "products":
                        //product
                        idlabelProduct.Visible = true;
                        idProduct.Visible = true;
                        if (modify)
                        {
                            idProduct.Enabled = false;
                        }
                        if (delete)
                        {
                            idProduct.Enabled = true;
                        }
                        break;

                    case "category":
                        idLabelCategories.Visible = true;
                        idCategories.Visible = true;
                        idLabelSubCategories.Visible = false;
                        idSubcategories.Visible = false;
                        if (modify)
                        {
                            idCategories.Enabled = false;
                        }
                        if (delete)
                        {
                            idCategories.Enabled = true;
                        }
                        break;
                    case "subcategory":
                        idLabelSubCategories.Visible = true;
                        idSubcategories.Visible = true;
                        idLabelCategories.Visible = false;
                        idCategories.Visible = false;
                        if (modify)
                        {
                            idSubcategories.Enabled = false;
                        }
                        if (delete)
                        {
                            idSubcategories.Enabled = true;
                        }
                        break;
                }
            }
            else
            {
                switch (currentTable)
                {
                    case "user":
                        idLabelUser.Visible = false;
                        idUser.Visible = false;
                        break;

                    case "products":
                        idlabelProduct.Visible = false;
                        idProduct.Visible = false;
                        break;
                    case "category":
                        idLabelCategories.Visible = false;
                        idCategories.Visible = false;
                        idLabelSubCategories.Visible = false;
                        idSubcategories.Visible = false;
                        break;
                    case "subcategory":
                        idLabelSubCategories.Visible = false;
                        idSubcategories.Visible = false;
                        idLabelCategories.Visible = false;
                        idCategories.Visible = false;

                        break;
                }
            }

          
        }//tick end


        //Limpiador
        private void cleanData()
        {
            //- Limpiar usuario
            userUsername.Clear();
            userPassword.Clear();
            emailUser.Clear();
            idUser.Clear();

            //- Limpiar producto
            nameProduct.Clear();
            brandbox.Clear();
            pricebox.Clear();
            stokbox.Clear();
            idProduct.Clear();

            //- Limpiar Categorias
            categoryName.Clear();
            idCategories.Clear();
            //- Limpiar Subcategorias
            subcategoryName.Clear();
            idSubcategories.Clear();
        }

        private void clearFilter(string [] Filtertable) {

            where1TextBox.Clear();
            where2Textbox.Clear();
            FilterCombobox.Items.Clear();
            FilterCombobox.Items.AddRange(Filtertable);
            FilterCombobox.SelectedIndex = 0;
        }


        //Enable and disable:
        //Enable
        private void enableUsers() {
            userUsername.Enabled = true;
            userPassword.Enabled = true;
            emailUser.Enabled = true;
        }

        private void enableProducts() {
            nameProduct.Enabled = true;
            stokbox.Enabled = true;
            pricebox.Enabled = true;
            brandbox.Enabled = true;
        }

        private void enableCategories()
        {
            categoryName.Enabled = true;
           
        }

        private void enableSubcategories()
        {
            subcategoryName.Enabled = true;
        }

        //Disable
        private void DisableUsers()
        {
            userUsername.Enabled = false;
            userPassword.Enabled = false;
            emailUser.Enabled = false;
        }

        private void DisableProducts()
        {
            nameProduct.Enabled = false;
            stokbox.Enabled = false;
            pricebox.Enabled = false;
            brandbox.Enabled = false;
        }

        private void DisableCategories()
        {
            categoryName.Enabled = false;

        }

        private void DisableSubcategories()
        {
            subcategoryName.Enabled = false;
        }



        //metodos a buscar y eleminar------


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

    

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
        //-----------------------------

    }
