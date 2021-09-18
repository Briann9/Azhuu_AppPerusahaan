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
        private void LandingPage_Load(object sender, EventArgs e)
        {
            //sqlConnect = new MySqlConnection(connectString);

            DataTable dtProfile = new DataTable();
            sqlQuery = "select pobus_id, pobus_name, pobus_telp, pobus_email, pobus_address from po_bus where pobus_id = '"+FormWelcome.pobusid+"'";
            sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
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
                //sqlConnect = new MySqlConnection(connectString);

                DataTable dtProfile = new DataTable();
                sqlQuery = "select pobus_id, pobus_name, pobus_telp, pobus_email, pobus_address from po_bus where pobus_id = '" + FormWelcome.pobusid + "'";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
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
                    //sqlConnect = new MySqlConnection(connectString);



                    //delete transaksi_penumpang
                    sqlQuery = "DELETE FROM transaksi_penumpang WHERE tp_bookingid IN (select tp.tp_bookingid from transaksi_penumpang tp, pesan_transaksi pt, rute r, vehicle v where tp.TP_BOOKINGID = pt.TP_BOOKINGID and pt.RUTE_ID = r.RUTE_ID and r.V_ID = v.v_id and pobus_id = '"+FormWelcome.pobusid+"')";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();

                    //delete pesan_transaksi
                    sqlQuery = "DELETE FROM pesan_transaksi WHERE tp_bookingid IN (select tp_bookingid from pesan_transaksi pt, rute r, vehicle v where pt.RUTE_ID = r.RUTE_ID and r.V_ID = v.v_id and pobus_id = '"+FormWelcome.pobusid+"')";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();

                    //delete rute
                    sqlQuery = "DELETE FROM rute WHERE rute_id IN (select rute_id from rute r, vehicle v where r.V_ID = v.v_id and pobus_id = '"+FormWelcome.pobusid+"')";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();

                    // delete vehicle
                    sqlQuery = "DELETE FROM vehicle WHERE v_id IN (select v_id from vehicle v where pobus_id = '"+FormWelcome.pobusid+"')";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();

                    // delete airport_pobus
                    sqlQuery = "delete from airport_pobus where pobus_id = '"+FormWelcome.pobusid+"'";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();


                    // delete account
                    sqlQuery = "delete from po_bus where pobus_id = '" + tBoxID.Text + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();

                    
                    MessageBox.Show("Akun Telah Di Hapus!");

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

        private void butVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                var kendaraan = new VehicleList();
                kendaraan.init(fWelcome);
                kendaraan.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butRute_Click(object sender, EventArgs e)
        {
            var riti = new RuteList();
            riti.init(fWelcome);
            riti.ShowDialog();
        }

        private void butUpcoming_Click(object sender, EventArgs e)
        {
            var ipcimingtrip = new UpcomingTrip();
            ipcimingtrip.init(fWelcome);
            ipcimingtrip.ShowDialog();
        }
        

        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {
                //sqlConnect = new MySqlConnection(connectString);
                DataTable dtPOBUS = new DataTable();
                sqlQuery = "select pobus_id, pobus_name, pobus_telp, pobus_email, POBUS_ADDRESS from po_bus where pobus_id = '"+FormWelcome.pobusid+"'";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPOBUS);


                if (tBoxID.Text == "" || tBoxNama.Text == "" || tBoxAlamat.Text == "" || tBoxEmail.Text == "" || tBoxNomorTlpn.Text == "")
                {
                    MessageBox.Show("Data ada yang kosong!");
                }
                else if (tBoxNama.Text == dtPOBUS.Rows[0]["pobus_name"].ToString() && tBoxAlamat.Text == dtPOBUS.Rows[0]["POBUS_ADDRESS"].ToString() && tBoxEmail.Text == dtPOBUS.Rows[0]["pobus_email"].ToString() && tBoxNomorTlpn.Text == dtPOBUS.Rows[0]["pobus_telp"].ToString())
                {
                    MessageBox.Show("Data tidak ada yang diubah!");
                }
                else
                {
                    //sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "update po_bus set pobus_name = '"+tBoxNama.Text+"', pobus_address = '"+tBoxAlamat.Text+"', pobus_telp = '"+tBoxNomorTlpn.Text+"', pobus_email = '"+tBoxEmail.Text+"' where pobus_id = '"+tBoxID.Text+"';";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();
                    MessageBox.Show("Data sudah diubah!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butSignOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                this.Close();
                var welcomee = new FormWelcome();
                welcomee.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
