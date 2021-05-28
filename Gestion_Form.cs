using System;
using System.Drawing;
using System.Windows.Forms;
using ShopfyDBLibrary;


namespace Gestion
{
    public partial class Gestion_Form : Form
    {
        private DB db = new DB();
        public Gestion_Form()
        {
         
            InitializeComponent();
            conectionDb();

           
            loadpropietiesLeftPanel();
            
            loadpropietiesCombobox();
            LoadUsers("","");
        

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

            dataGridView1.DataSource = db.userSelection("", "");



        }

        private void conectionDb()
        {
            try
            {
                
               
                db.startConnection();
                userUsername.Text = "funciona";

             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

            private void loadpropietiesLeftPanel()
        {
            if (Data_class.admin)
            {
                adminbutton.Enabled = true;
            }
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            panelUsers.Visible = false;
            panelProducts.Visible = false;
            panelSales.Visible = false;


            //buttonusers.Image = Image.FromFile("C:\\Proyectos\\Proyecto_Final\\Gestion\\Gestion\\Resources\\users_icon.ico");
            buttonusers.ImageAlign = ContentAlignment.MiddleLeft;
           //   buttonusers.TextAlign = ContentAlignment.MiddleCenter;         
           // productsButton.Image = Image.FromFile("C:\\Proyectos\\Proyecto_Final\\Gestion\\Gestion\\Resources\\product.ico");
            productsButton.ImageAlign = ContentAlignment.MiddleLeft;
            productsButton.TextAlign = ContentAlignment.MiddleCenter;
           // salesButton.Image = Image.FromFile("C:\\Proyectos\\Proyecto_Final\\Gestion\\Gestion\\Resources\\sales.ico");
            salesButton.ImageAlign = ContentAlignment.MiddleLeft;
            salesButton.TextAlign = ContentAlignment.MiddleCenter;

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

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void adminbutton_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_Form_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonDeleteUsers_Click(object sender, EventArgs e)
        {

        }

      
        private void mouseleaveUsers(object sender, EventArgs e)
        {
         //   buttonusers.BackColor = SystemColors.ButtonFace;
        }

        private void Gestion_Form_Load_1(object sender, EventArgs e)
        {

          comboboxCategory.SelectedIndex = 0;
           comboboxSubcategory.SelectedIndex = 0;
            Roles.SelectedIndex = 2;
            
        }

        private void mouseEnters(object sender, EventArgs e)
        {
        //    buttonusers.BackColor = Color.Red;
        }

        private void mouseenterbutonProduct(object sender, EventArgs e)
        {
          //  buttonusers.BackColor = Color.Red;
        }

        private void mouseleaveProduct(object sender, EventArgs e)
        {
        //    buttonusers.BackColor = Color.Red;
        }

        private void mouseEnterSales(object sender, EventArgs e)
        {
         //   buttonusers.BackColor = Color.Red;
        }

        private void mouseLeaveSales(object sender, EventArgs e)
        {
        //    buttonusers.BackColor = Color.Red;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createUser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(userUsername.Text) && string.IsNullOrEmpty(userPassword.Text) && string.IsNullOrEmpty(emailUser.Text))
            {
                string user = userUsername.Text;
                string pwd = userPassword.Text;
                string email = emailUser.Text;
                //string rol = Roles.SelectedItem.ToString();


            }
            else {
                MessageBox.Show("Fields can't be empty!");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void createProduct_onClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameProduct.Text) && string.IsNullOrEmpty(stokbox.Text) && string.IsNullOrEmpty(brandbox.Text) && string.IsNullOrEmpty(pricebox.Text)){ 
            
            }

        }

        private void stockPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != ','))
            {
                e.Handled = true;

            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void pricePressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != ','))
            {
                e.Handled = true;

            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonCreateUsers_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifyUsers_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {

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
    }
}
