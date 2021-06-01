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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;


        private void FormRegister_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);

                DataTable dtcekemail = new DataTable();
                sqlQuery = "select * from po_bus where pobus_email = '" + tBoxEmail.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtcekemail);

                int ijinregister = 1;

                if (tBoxNama.Text == "" || tBoxEmail.Text == "" || tBoxNomorTlpn.Text == "" || tBoxAlamat.Text == "" || tBoxPassword.Text == "" || tBoxConfirmPassword.Text == "")
                {
                    labelError.Text = "Ada data yang kosong!";
                    ijinregister = 0;
                }
                else if (dtcekemail.Rows.Count == 1)
                {
                    labelError.Text = "Email sudah terdaftar";
                    ijinregister = 0;
                }
                else if (tBoxPassword.Text != tBoxConfirmPassword.Text)
                {
                    labelError.Text = "Password doesn't Match!";
                    ijinregister = 0;
                }

                if (ijinregister == 1)
                {
                    sqlQuery = "insert into po_bus values ('" + tBoxID.Text + "'.'" + tBoxNama.Text + "','" + tBoxNomorTlpn.Text + "','" + tBoxEmail.Text + "','" + tBoxConfirmPassword.Text + "','" + tBoxAlamat.Text + "','0')";

                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Selamat Register Berhasil!");


                    FormWelcome.pobusid = tBoxID.Text;
                    //lempar ke landing page
                    this.Hide();
                    var landing = new LandingPage();
                    landing.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelHereSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                FormSignIn formSignIn = new FormSignIn();
                formSignIn.Show();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxNama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                string hurufdepan;

                if(string.IsNullOrEmpty(tBoxNama.Text))
                {
                    tBoxID.Text = "";
                }
                else
                {
                    DataTable untukHurufDepan = new DataTable();

                    hurufdepan = tBoxNama.Text.Substring(0, 1).ToUpper();
                    sqlQuery = "select pobus_id, pobus_name from player where player_name like '"+hurufdepan+"'"; // belum bisaaaaaaaaaaaaaa 
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(untukHurufDepan);

                    int jumlahrows = untukHurufDepan.Rows.Count + 1;

                    if(untukHurufDepan.Rows.Count < 10)
                    {
                        hurufdepan += "00";
                        hurufdepan += jumlahrows.ToString();
                    }
                    else if(untukHurufDepan.Rows.Count >= 10 && untukHurufDepan.Rows.Count < 100)
                    {
                        hurufdepan += "0";
                        hurufdepan += jumlahrows.ToString();
                    }
                    else if(untukHurufDepan.Rows.Count >= 100)
                    {
                        hurufdepan += jumlahrows.ToString();
                    }
                    tBoxID.Text = hurufdepan;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
