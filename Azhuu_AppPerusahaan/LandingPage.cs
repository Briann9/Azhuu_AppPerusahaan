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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        private void LandingPage_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connectString);

            DataTable dtProfile = new DataTable();
            sqlQuery = "select pobus_id, pobus_name, pobus_telp, pobus_email, pobus_address from po_bus where pobus_id = '"+FormWelcome.pobusid+"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtProfile);

            tBoxID.Text = dtProfile.Rows[0]["pobus_id"].ToString();
            tBoxNama.Text = dtProfile.Rows[0]["pobus_name"].ToString();
            tBoxEmail.Text = dtProfile.Rows[0]["pobus_email"].ToString();
            tBoxNomorTlpn.Text = "0" + dtProfile.Rows[0]["pobus_telp"].ToString();
            tBoxAlamat.Text = dtProfile.Rows[0]["pobus_address"].ToString();


        }
        private void enablesavebutton()
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);

                DataTable dtProfile = new DataTable();
                sqlQuery = "select pobus_id, pobus_name, pobus_telp, pobus_email, pobus_address from po_bus where pobus_id = '" + FormWelcome.pobusid + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtProfile);

                butSave.Enabled = false;
                if (tBoxNama.Text != dtProfile.Rows[0]["pobus_name"].ToString())
                {
                    butSave.Enabled = true;
                }
                else if (tBoxEmail.Text != dtProfile.Rows[0]["pobus_email"].ToString())
                {
                    butSave.Enabled = true;
                }
                else if (tBoxNomorTlpn.Text != "0" + dtProfile.Rows[0]["pobus_telp"].ToString())
                {
                    butSave.Enabled = true;
                }
                else if (tBoxAlamat.Text != dtProfile.Rows[0]["pobus_address"].ToString())
                {
                    butSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tBoxNama_TextChanged(object sender, EventArgs e)
        {
            enablesavebutton();
        }

        private void tBoxEmail_TextChanged(object sender, EventArgs e)
        {
            enablesavebutton();
        }

        private void tBoxNomorTlpn_TextChanged(object sender, EventArgs e)
        {
            enablesavebutton();
        }

        private void tBoxAlamat_TextChanged(object sender, EventArgs e)
        {
            enablesavebutton();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Apa anda yakin ingin menghapus akun anda?", "Hapus Akun", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "delete from po_bus where pobus_id = '" + tBoxID.Text + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                    MessageBox.Show("Akun Telah Di Hapus!");

                    //delete rute
                    //delete transaksi
                    //delete semua yang berhubungan dengan pobus_id



                    this.Close();

                    var welcome = new FormWelcome();
                    welcome.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
