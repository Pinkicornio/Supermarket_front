using System;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Login_Form : Form
    {

       
        public Login_Form()
        {
            InitializeComponent();
            
        }

        private void record_user_event(object sender, EventArgs e)
        {
            
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Gestion_Form gestion_form;


            if (userfield.Text.Equals("admin") && passwordfield.Text.Equals("admin")) {

             
                this.Hide();
                Data_class.admin = true;
                gestion_form = new Gestion_Form();
                gestion_form.Show();
                    
            }

            else if (userfield.Text.Equals("user") && passwordfield.Text.Equals("user"))
            {
                this.Hide();
                gestion_form = new Gestion_Form();
                gestion_form.Show();
            }



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
    }
}
