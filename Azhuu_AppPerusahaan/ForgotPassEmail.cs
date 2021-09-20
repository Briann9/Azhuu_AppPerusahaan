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
    public partial class FormForgotPassEmail : Form
    {
        public FormForgotPassEmail()
        {
            InitializeComponent();
        }

        FormWelcome fWelcome;
        //MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        //string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;
        public static string emailforgot = "";

        public void init(FormWelcome f)
        {
            fWelcome = f;
        }
        private void FormForgotPassEmail_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                //sqlConnect = new MySqlConnection(connectString);
                DataTable masuk = new DataTable();
                sqlQuery = "select user_email from user_azhuu where user_email = '" + tBoxEmail.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(masuk);

                if (masuk.Rows.Count == 0)
                {
                    labError.Text = "Email Tidak Terdaftar!";
                }
                else
                {
                    this.Hide();
                    emailforgot = tBoxEmail.Text;

                    var pwnotelp = new FormForgotPassTlpn();
                    pwnotelp.init(fWelcome);
                    pwnotelp.ShowDialog();
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
                var pwnotelp1 = new FormSignIn();
                pwnotelp1.init(fWelcome);
                pwnotelp1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
