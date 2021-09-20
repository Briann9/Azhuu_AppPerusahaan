using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Azhuu_AppPerusahaan
{
    public partial class FormNewPassword : Form
    {
        public FormNewPassword()
        {
            InitializeComponent();
        }
        FormWelcome fWelcome;
        //MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        //string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;
        public void init(FormWelcome f)
        {
            fWelcome = f;
        }
        private void FormNewPassword_Load(object sender, EventArgs e)
        {
            try
            {
                if (tBoxPassword.Text != tBoxConfirmPassword.Text)
                {
                    labError.Text = " paswword tidak sama";
                }
                else
                {
                    // masih belom selesai, close semua form di sebelum ini

                    // ForgotPasswordEmail vt = new ForgotPasswordEmail();
                    //sqlConnect = new MySqlConnection(connectString);
                    DataTable masuk1 = new DataTable();
                    sqlQuery = "update po_bus set pobus_PASSWORD = '" + tBoxPassword.Text + "' where pobus_EMAIL = '" + FormForgotPassEmail.emailforgot + "' ";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(masuk1);

                    // labError.Text = " paswword sudah diganti";

                    // password di password char '*';

                    // lempar ke login

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                var pwnotelp = new FormForgotPassTlpn();
                pwnotelp.init(fWelcome);
                pwnotelp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tBoxPassword.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tBoxConfirmPassword.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
