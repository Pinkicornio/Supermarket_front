using System;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using ShopfyDBLibrary;



namespace Gestion
{
    public partial class Gestion_Form : Form
    {
        private Data_class dataClass = new Data_class();
        private DB db = new DB();
        public Gestion_Form()
        {
         
            InitializeComponent();
            conectionDb();
            loadpropietiesLeftPanel();
           

            userCurrentlabel.Text = Data_class.currentUser;
            loadpropietiesCombobox();         
           // LoadUsers("","");

            if (Data_class.admin)
            {
                loadAdminRequirements();
                adminbutton.Enabled = true;
            }

        }

        private void loadAdminRequirements()
        {

            buttonModifyProduct.Enabled = true;
            buttonModifyUsers.Enabled = true;
            buttonDeleteProduct.Enabled = true;
            buttonDeleteUsers.Enabled = true;
        }

        private void LoadUsers(string campo, string where)
        {
            
            dataGridView1.DataSource = db.userSelection("", "");
        }

        private void LoadProducts(string campo, string where) {
           
            dataGridView1.DataSource = db.productSelection("", "");
        }
        private void LoadSales(string campo, string where)
        {
            
            dataGridView1.DataSource = db.salesSelection("", "");
        }


        private void loadpropietiesCombobox()
        {
           
            comboboxCategory.DataSource = db.categorySelection("", "");
            comboboxCategory.DisplayMember = "NAME";
            comboboxCategory.ValueMember = "CATEGORY_ID";

            comboboxSubcategory.DataSource = db.subcategorySelection("", "");
            comboboxSubcategory.DisplayMember = "NAME";
            comboboxSubcategory.ValueMember = "SUBCATEGORY_ID";

            //dataGridView1.DataSource = db.userSelection("", "");



        }

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

            private void loadpropietiesLeftPanel()
        {
           
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            panelUsers.Visible = false;
            panelProducts.Visible = false;
            panelSales.Visible = false;

       //db.userInsert("CARLESPASFER", "Monlau2020", "CARLESPASFER@gmail.com", "admin");
            //                campo    -  where    
            
        }

    


        private void showSubmenu(Panel submenu) {

            if (submenu.Visible == false)
            {
               
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        
        }
        private void Users_Click(object sender, EventArgs e)
        {
            showSubmenu(panelUsers);
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            showSubmenu(panelProducts);
        }

        private void salesButton_Click(object sender, EventArgs e)
        {
            showSubmenu(panelSales);
        }

  

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonDeleteUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Delete";
        }

      
        private void Gestion_Form_Load_1(object sender, EventArgs e)
        {

          comboboxCategory.SelectedIndex = 0;
           comboboxSubcategory.SelectedIndex = 0;
            Roles.SelectedIndex = 0;
            
        }

      
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createUser_Click(object sender, EventArgs e)
        {

            switch (userButon.Text) {

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
                            string user = userUsername.Text;
                            string rol = Roles.SelectedItem.ToString();
                            db.userInsert(user, userPassword.Text, email, rol);
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
                            db.userUpdate(1,user, userPassword.Text, email, rol);
                            MessageBox.Show("USER " + user + " UPDATED");
                            LoadUsers("","");
                        }
                        else
                        {
                            MessageBox.Show("Email can't be like that");
                        }

                    }
                    break;              

                case "Delete":
                    db.productDelete(1);
                    break;

            
          
            }
        
        }

        private void cleanData()
        {
            //- Limpiar usuario
            userUsername.Clear();
            userPassword.Clear();
            emailUser.Clear();

            //- Limpiar producto
            nameProduct.Clear();
            brandbox.Clear();
            pricebox.Clear();
            stokbox.Clear();

            //- Limpiar Sales

            //- Limpiar Categorias

            //- Limpiar Subcategorias

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

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

                        db.productInsert(nameProduct.Text, brandbox.Text, float.Parse(pricebox.Text),Int32.Parse(stokbox.Text) , comboboxCategory.SelectedIndex+1, comboboxSubcategory.SelectedIndex+1);
                            MessageBox.Show("PRODUCT " + nameProduct + " INSERTED");
                            LoadProducts("", "");
                      

                    }
                    break;
                case "Modify":
                    if (string.IsNullOrEmpty(nameProduct.Text) && string.IsNullOrEmpty(stokbox.Text) && string.IsNullOrEmpty(brandbox.Text) && string.IsNullOrEmpty(pricebox.Text))
                    
                        {
                        MessageBox.Show("Fields can't be empty!");
                    }
                    else
                    {
                        db.productUpdate(1,nameProduct.Text, brandbox.Text, float.Parse(pricebox.Text), Int32.Parse(stokbox.Text), comboboxCategory.SelectedIndex, comboboxSubcategory.SelectedIndex);
                        MessageBox.Show("PRODUCT " + nameProduct + " INSERTED");
                        LoadProducts("", "");

                    }
                    break;

                case "Delete":
                    db.userDelete(1);
                    break;
            }

        }

        private void stockPressed(object sender, KeyPressEventArgs e)
        {
            dataClass.check_onlynumbers(sender, e);
        }

        private void pricePressed(object sender, KeyPressEventArgs e)
        {
            dataClass.check_onlynumbers(sender, e);
        }

        private void buttonCreateUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Create";
            

        }

        private void buttonModifyUsers_Click(object sender, EventArgs e)
        {
            userButon.Text = "Modify";

        }

        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Create";
        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Modify";

        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            butonProduct.Text = "Delete";
        }

        private void buttonSalesModify_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalesSelect_Click(object sender, EventArgs e)
        {

        }

        private void rowSelected(object sender, DataGridViewCellEventArgs e)
        {

        }

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
        private void userPanelvisisble() {
            panelUser.Visible = true;
            DefaultPanel.Visible = false;
            panelProduct.Visible = false;
        }

        private void productVisible() {

            panelProduct.Visible = false;
            DefaultPanel.Visible = false;
            panelUser.Visible = true;

        }

    }
}
