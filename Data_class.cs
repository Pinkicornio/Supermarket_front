using NPOI.POIFS.Crypt;
using System.Text;
using System.Windows.Forms;

namespace Gestion
{
    class Data_class
    {
        public static bool  admin = true;
        public static string currentUser = "user_test";


        public void check_onlynumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }

        }


        public void check_onlynumbersWithComa(object sender, KeyPressEventArgs e) {

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


        public bool verificar(string user, string pwd) {

            
            return true;
        }

        public string encriptar(string contra, System.DateTime fecha)
        {
   
            string fechaHash = fecha.ToString();
            fechaHash = fechaHash.Replace("-", "");

            //-----------
            string hashDate = mD5(fechaHash);

            //-----------
            string hashpass = mD5(contra);

            string salContra = mD5(hashDate + hashpass);
            //-----------

            string pebre = salContra;

            int lengh = pebre.Length;
            string sSubCadena = pebre.Substring(0, 17);
            string sSubCadena2 = pebre.Substring(17, lengh);
            string Contrapebre = sSubCadena2 + sSubCadena;

            //lengh conocer la lingtud de la string luego lo separamos por X numero y cambiarlo de posicion 
            //pebreee

            string contraFinal = mD5(salContra + Contrapebre);
            return contraFinal;

        }

        public string mD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    }
}
