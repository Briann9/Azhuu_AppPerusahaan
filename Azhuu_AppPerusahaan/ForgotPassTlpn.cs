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
    public partial class FormForgotPassTlpn : Form
    {
        public FormForgotPassTlpn()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        string emailforgot = FormForgotPassEmail.emailforgot;
        private void FormForgotPassTlpn_Load(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                //ForgotPasswordEmail fe = new ForgotPasswordEmail();
                sqlConnect = new MySqlConnection(connectString);
                DataTable masuk1 = new DataTable();
                sqlQuery = "select * from user_azhuu where USER_TELP  = '" + tBoxNoTelp.Text + "' and USER_EMAIL = '" + emailforgot + "' ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(masuk1);

                if (masuk1.Rows.Count == 0)
                {
                    labelError.Text = "nomor telfon salah";
                }
                else
                {
                    this.Hide();
                    var pwnew = new FormNewPassword();
                    pwnew.ShowDialog();
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
                var pwnotelp1 = new FormForgotPassEmail();
                pwnotelp1.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
