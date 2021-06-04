using System;
using System.Windows.Forms;
using ShopfyDBLibrary;



namespace Gestion
{
    public partial class Gestion_Form : Form
    {
        private Data_class dataClass = new Data_class();
        private DB db = new DB();
        private string currentTable;
        private bool modify;
        private bool delete;
        private int id;

        public Gestion_Form()
        {
            InitializeComponent();
        }

        private void loadAdminRequirements()
        {
            buttonModifyProduct.Enabled = true;
            buttonModifyUsers.Enabled = true;
            buttonDeleteProduct.Enabled = true;
            buttonDeleteUsers.Enabled = true;
        }


        //-- Load datos de tabla
        private void LoadUsers(string campo, string where)
        {

            dataGridView1.DataSource = db.userSelection("", "");
            dataGridView1.ClearSelection();
            currentTable = "user";
        }

        private void LoadProducts(string campo, string where)
        {

            dataGridView1.DataSource = db.productSelection("", "");
            dataGridView1.ClearSelection();
            currentTable = "products";
        }
        private void LoadSales(string campo, string where)
        {

            dataGridView1.DataSource = db.salesSelection("", "");
            dataGridView1.ClearSelection();
            currentTable = "sales";
        }

        private void LoadSalesDetail() {
            dataGridView1.DataSource = db.sales_detailSelection("","","");
            dataGridView1.ClearSelection();
            currentTable = "salesDetails";
        }


        private void LoadCategories()
        {
            dataGridView1.DataSource = db.categorySelection("", "");
            dataGridView1.ClearSelection();
            currentTable = "category";
        }

        private void LoadSubCategories()
        {
            dataGridView1.DataSource = db.categorySelection("", "");
            dataGridView1.ClearSelection();
            currentTable = "subcategory";
        }

        //Cargar datos combobox categorias
        private void loadpropietiesCombobox()
        {
            //-- Cargar datos combo box de categoria        
            comboboxCategory.DataSource = db.categorySelection("", "");
            comboboxCategory.DisplayMember = "NAME";
            comboboxCategory.ValueMember = "CATEGORY_ID";
            //-- Cargar datos combo box de Subcategoria 
            comboboxSubcategory.DataSource = db.subcategorySelection("", "");
            comboboxSubcategory.DisplayMember = "NAME";
            comboboxSubcategory.ValueMember = "SUBCATEGORY_ID";

        }
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
            panelSubcategoryMenuLeft.Visible = false;

            comboboxCategory.SelectedIndex = 0;
            comboboxSubcategory.SelectedIndex = 0;
            Roles.SelectedIndex = 0;


            userCurrentlabel.Text = Data_class.currentUser;
            loadpropietiesCombobox();

            if (Data_class.admin)
            {
                loadAdminRequirements();
                adminbutton.Enabled = true;
            }


        }

        //user 
        private void createUser_Click(object sender, EventArgs e)
        {

            switch (userButon.Text)
            {

                case "Create":
                    if (string.IsNullOrEmpty(userUsername.Text) && string.IsNullOrEmpty(userPassword.Text) && string.IsNullOrEmpty(emailUser.Text))
                    {
                        MessageBox.Show("Fields can't be empty!");
                    }
                    else
                    {
                        string email = emailUser.Text;
                        if (dataClass.IsValidEmail(email))
                        {
                            string password = userPassword.Text;
                            string user = userUsername.Text;
                            string rol = Roles.SelectedItem.ToString();
                            db.userInsert(user, password, email, rol);
                            MessageBox.Show("USER " + user + " INSERTED");
                            LoadUsers("", "");
                            cleanData();
                        }
                        else
                        {
                            MessageBox.Show("Email can't be like that");
                        }

                    }
                    break;
                case "Modify":
                    if (string.IsNullOrEmpty(userUsername.Text) && string.IsNullOrEmpty(userPassword.Text) && string.IsNullOrEmpty(emailUser.Text))
                    {
                        MessageBox.Show("Fields can't be empty!");
                    }
                    else
                    {
                        string email = emailUser.Text;
                        if (dataClass.IsValidEmail(email))
                        {
                            string user = userUsername.Text;
                            string rol = Roles.SelectedItem.ToString();
                            db.userUpdate(Int32.Parse(idUser.Text), user, userPassword.Text, email, rol);
                            MessageBox.Show("USER " + user + " UPDATED");
                            LoadUsers("", "");
                        }
                        else
                        {
                            MessageBox.Show("Email can't be like that");
                        }

                    }
                    break;

                case "Delete":
                    db.userDelete(Int32.Parse(idUser.Text));
                    LoadUsers("", "");
                    break;
            }

        }

        //-- Producto 
        private void createProduct_onClick(object sender, EventArgs e)
        {

            switch (butonProduct.Text)
            {

                case "Create":
                    if (string.IsNullOrEmpty(nameProduct.Text) && string.IsNullOrEmpty(stokbox.Text) && string.IsNullOrEmpty(brandbox.Text) && string.IsNullOrEmpty(pricebox.Text))
                    {
                        MessageBox.Show("Fields can't be empty!");

                    }
                    else
                    {
                        db.productInsert(nameProduct.Text, brandbox.Text, float.Parse(pricebox.Text), Int32.Parse(stokbox.Text), comboboxCategory.SelectedIndex + 1, comboboxSubcategory.SelectedIndex + 1);
                        MessageBox.Show("PRODUCT " + nameProduct.Text + " INSERTED");
                        LoadProducts("", "");
                    }
                    break;
                case "Modify":
                    if (string.IsNullOrEmpty(idUser.Text) && string.IsNullOrEmpty(nameProduct.Text) && string.IsNullOrEmpty(stokbox.Text) && string.IsNullOrEmpty(brandbox.Text) && string.IsNullOrEmpty(pricebox.Text))

                    {
                        MessageBox.Show("Fields can't be empty!");
                    }
                    else
                    {
                        db.productUpdate(Int32.Parse(idProduct.Text), nameProduct.Text, brandbox.Text, float.Parse(pricebox.Text), Int32.Parse(stokbox.Text), comboboxCategory.SelectedIndex, comboboxSubcategory.SelectedIndex);
                        MessageBox.Show("PRODUCT " + nameProduct.Text + " UPDATED");
                        LoadProducts("", "");
                    }
                    break;

                case "Delete":
                    if (!string.IsNullOrEmpty(idProduct.Text))
                    {
                        db.productDelete(Int32.Parse(idProduct.Text));
                        LoadProducts("", "");
                        MessageBox.Show("PRODUCT " + nameProduct.Text + " DELETED ");
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
                        break;
                    case "Modify":
                        break;
                    case "Delete":
                        break;
                }
            }
            else { 
            
            }
        }

  

        //-- User Menu
        private void buttonCreateUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Create";
            userPanelvisisble();
            LoadUsers("", "");
            enableUsers();
            modify = false;
            delete = false;
            cleanData();
        }
        private void buttonModifyUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Modify";
            userPanelvisisble();
            enableUsers();
            LoadUsers("", "");
            modify = true;
            delete = false;
            cleanData();
        }
        private void buttonDeleteUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Delete";
            DisableUsers();
            userPanelvisisble();
            LoadUsers("", "");
            modify = false;
            delete = true;
            cleanData();
        }


        //Product Menu
        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Create";
            productVisible();
            LoadProducts("", "");
            enableProducts();
            modify = false;
            delete = false;
            cleanData();
        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Modify";
            productVisible();
            LoadProducts("", "");
            enableProducts();
            modify = true;
            delete = false;
            cleanData();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Delete";
            productVisible();
            LoadProducts("", "");
            modify = false;
            delete = true;
            cleanData();
            DisableProducts();
        }

        
        //Sales menu
        private void buttonSalesselect_Click(object sender, EventArgs e)
        {
            modify = false;
            delete = false;
            cleanData();
            defaultPanleVisible();


        }
        private void buttonSalesSelect_Click(object sender, EventArgs e)
        {
            //details Sales
            modify = false;
            delete = false;
            cleanData();
            defaultPanleVisible();
                      

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
            LoadCategories();
            createCategories.Text = "Create";
        }
        private void modifyCategory_Click(object sender, EventArgs e)
        {
            modify = true;
            delete = false;
            cleanData();
            enableCategories();
            DisableSubcategories();
            LoadCategories();
            categoriesPanelVisible();
            createCategories.Text = "Modify";
        }

        private void deleteCategory_Click(object sender, EventArgs e)
        {
            modify = false;
            delete = true;
            cleanData();
            LoadCategories();
            DisableSubcategories();
            DisableCategories();
            categoriesPanelVisible();
            createCategories.Text = "Delete";
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
            LoadSubCategories();
            createCategories.Text = "Create";
        }

        private void modifySubcategory_Click(object sender, EventArgs e)
        {
            modify = true;
            delete = false;
            cleanData();
            categoriesPanelVisible();
            enableSubcategories();
            DisableCategories();
            LoadSubCategories();
            createCategories.Text = "Modify";
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
            LoadSubCategories();
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
                            userPassword.Text = row.Cells["PWD"].Value.ToString();
                            string password = row.Cells["EMAIL"].Value.ToString();
                            /*metodo de deshasheo
                                    I                             
                                    V
                             La to transforma y lo expresa
                            */
                            emailUser.Text = password;
                            idUser.Text = row.Cells["USER_ID"].Value.ToString();
                            break;

                        case "products":
                            nameProduct.Text = row.Cells["PRODUCT_ID"].Value.ToString();
                        
                            stokbox.Text = row.Cells["NAME"].Value.ToString();
                            pricebox.Text = row.Cells["BRAND"].Value.ToString();
                            brandbox.Text = row.Cells["PRICE"].Value.ToString();
                            idProduct.Text = row.Cells["STOCK"].Value.ToString();

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
        private void subcategoryButton_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSubcategoryMenuLeft);
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

        //-- Text box validators
        private void stockPressed(object sender, KeyPressEventArgs e)
        {
            dataClass.check_onlynumbers(sender, e);
        }

        private void pricePressed(object sender, KeyPressEventArgs e)
        {
            dataClass.check_onlynumbers(sender, e);
        }


        //llamada a metodos auxiliares
        private void idProductPress(object sender, KeyPressEventArgs e)
        {
            dataClass.check_onlynumbers(sender, e);
        }

        private void idUserPressed(object sender, KeyPressEventArgs e)
        {
            dataClass.check_onlynumbers(sender, e);
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
                        //resto 
                        //idlabelProduct.Visible = false;
                       //idProduct.Visible = false;
                        break;

                    case "products":
                        //product
                        idlabelProduct.Visible = true;
                        idProduct.Visible = true;                 
                        break;

                    case "category":
                        idLabelCategories.Visible = true;
                        idCategories.Visible = true;
                        idLabelSubCategories.Visible = false;
                        idSubcategories.Visible = false;
                        break;
                    case "subcategory":
                        idLabelSubCategories.Visible = true;
                        idSubcategories.Visible = true;
                        idLabelCategories.Visible = false;
                        idCategories.Visible = false;
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
                        break;
                    case "subcategory":
                        idLabelSubCategories.Visible = false;
                        idCategories.Visible = false;
                        break;
                }
            }
        }//tick end

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
            //- Limpiar Subcategorias
            subcategoryName.Clear();
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }
        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

    }
        //-----------------------------

    }
