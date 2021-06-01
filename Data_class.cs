using System.Windows.Forms;

namespace Gestion
{
    class Data_class
    {
        public static bool  admin = true;
        public static string currentUser = "user_test";


        public void check_onlynumbers(object sender, KeyPressEventArgs e) {

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

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool sendEmail() {


            return false;
        }



    }
}
