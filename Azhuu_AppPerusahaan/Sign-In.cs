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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }
        FormWelcome fWelcome;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        public void init(FormWelcome f)
        {
            fWelcome = f;
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                int cekemail = 0;
                int cekpassword = 0;

                

                DataTable dtLogin = new DataTable();
                sqlQuery = "select pobus_email from po_bus where pobus_email = '" + tBoxEmail.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtLogin);


                if (dtLogin.Rows.Count == 1)
                {
                    cekemail = 1;
                }

                DataTable dtpassword = new DataTable();
                sqlQuery = "select pobus_email, pobus_password from po_bus where pobus_password = '" + tBoxPassword.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtpassword);
                

                if (dtpassword.Rows.Count == 1)
                {
                    cekpassword = 1;
                }


                if (cekemail == 0)
                {
                    labelError.Text = "Email Tidak Terdaftar!";
                }
                else if (cekpassword == 0)
                {
                    labelError.Text = "Password Salah!";
                }
                else
                {
                    this.Hide();
                    DataTable pobusid = new DataTable();
                    sqlQuery = "select pobus_id from po_bus where pobus_email = '"+tBoxEmail.Text+"'";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(pobusid);

                    FormWelcome.pobusid = pobusid.Rows[0]["pobus_id"].ToString();
                    var landing = new LandingPage();
                    landing.init(fWelcome);
                    landing.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                FormForgotPassEmail formForgotPassEmail = new FormForgotPassEmail();
                formForgotPassEmail.init(fWelcome);
                formForgotPassEmail.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelHereRegister_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormRegister formRegister = new FormRegister();
                formRegister.init(fWelcome);
                formRegister.Show();
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
                var pwnotelp1 = new FormWelcome();
                pwnotelp1.ShowDialog();
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
    }
}
