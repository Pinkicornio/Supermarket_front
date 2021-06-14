using ShopfyDBLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Login_Form : Form
    {

        private DB db = new DB();
        private Data_class data_class = new Data_class();
        public Login_Form()
        {
            InitializeComponent();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Load_Form load_form;
            string userInput = userfield.Text;
            string pwdInput = passwordfield.Text;

            if (!string.IsNullOrWhiteSpace(userInput) && !string.IsNullOrWhiteSpace(pwdInput))
            {
                try {

                List<string> datainfo = db.getLoginInfo(userInput);

               
                    if (datainfo[1].Equals(data_class.hashpwd(pwdInput, datainfo[2])))
                    {
                        if (datainfo[3].Equals("ADMIN"))
                        {
                            Data_class.admin = true;
                            Data_class.currentUser = userInput;
                            this.Hide();
                            load_form = new Load_Form();
                            load_form.Show();

                        }
                        else if (datainfo[3].Equals("USER"))
                        {
                            Data_class.admin = false;
                            Data_class.currentUser = userInput;
                            this.Hide();
                            load_form = new Load_Form();
                            load_form.Show();

                        }
                        else {
                            MessageBox.Show("THIS APP IS FOR COMPANY");
                        }
                    }
                    else {
                        MessageBox.Show("WRONG PASSWORD");
                    }

                }
            catch
            {
                MessageBox.Show("LOG FAILED, USERNAME NOT EXIST");
            }
        }else MessageBox.Show("ALL FIELDS MUST BE FULL");
            


    }

        private void pictureBox1_Click(object sender, EventArgs e)
        { 
            if(passwordfield.PasswordChar=='*'){
               // pictureBox1.Image = Resour
                passwordfield.PasswordChar = '\0';
            }
           else  if (passwordfield.PasswordChar == '\0')
            {
                //pictureBox1.Image = Gestion.Properties.Resources.hide;
                passwordfield.PasswordChar = '*';
            }
        }

        private void textchanger(object sender, KeyPressEventArgs e)
        {
           // passwordfield.PasswordChar = '*';
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            conectionDb();
         
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

        private void userfield_Enter(object sender, EventArgs e)
        {
            if (userfield.Text.Equals("username")) {
                userfield.Clear();
            }
        }
        private void userfield_Leave(object sender, EventArgs e)
        {
            if (userfield.Text.Equals(""))
            {
                userfield.Text = "username";
            }
        }

        private void passwordfield_Enter(object sender, EventArgs e)
        {
            if (passwordfield.Text.Equals("pasword"))
            {
                passwordfield.Clear();
            }

        }

        private void passwordfield_Leave(object sender, EventArgs e)
        {
            if (passwordfield.Text.Equals(""))
            {
                passwordfield.Text = "pasword";
            }
        }
    }
}
