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
    public partial class RuteList : Form
    {
        public RuteList()
        {
            InitializeComponent();
        }

        FormWelcome fWelcome;
        //MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        //string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        string fromto = "F";
        string time = "00:00";

        string IDdelete = "";
        public void init(FormWelcome f)
        {
            fWelcome = f;
        }
        private void RuteList_Load(object sender, EventArgs e)
        {
            try
            {
                //sqlConnect = new MySqlConnection(connectString);

                DataTable dtListAirport = new DataTable();
                sqlQuery = "select airport_id, concat('[',`airport_id`,']',`airport_name`) as `Airport` from airport";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListAirport);

                cboxBandara.DataSource = dtListAirport;
                cboxBandara.DisplayMember = "Airport";
                cboxBandara.ValueMember = "airport_id";
                cboxBandara.SelectedIndex = -1;


                DataTable dtListKendaraan = new DataTable();
                sqlQuery = "select v_id, concat(v_brand, '  (',v_capacity,')  ', '[',v_license,']') as `Vehicle` from vehicle where pobus_id = '"+FormWelcome.pobusid+"'";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListKendaraan);

                cboxKendaraan.DataSource = dtListKendaraan;
                cboxKendaraan.DisplayMember = "Vehicle";
                cboxKendaraan.ValueMember = "v_id";
                cboxKendaraan.SelectedIndex = -1;


                rbutDari.Checked = true;
                refreshDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void generateID()
        {
            try
            {
                if (cboxBandara.SelectedIndex == -1 || tboxDestination.TextLength < 3)
                {
                    tboxIDRute.Text = "";
                }
                else
                {
                    string destina = tboxDestination.Text.Substring(0, 3).ToUpper();
                    string idd = "";
                    string pobuss = FormWelcome.pobusid.ToString();
                    //sqlConnect = new MySqlConnection(connectString);


                    DataTable dtjumlahrute = new DataTable();
                    sqlQuery = "select * from rute where airport_id = '"+cboxBandara.SelectedValue.ToString()+"' and rute_halte like '"+tboxDestination.Text+"%' and RUTE_FROMTO = '"+fromto+"'";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtjumlahrute);

                    int jumlahrowss = dtjumlahrute.Rows.Count -1;
                    if(jumlahrowss == -1)
                    {
                        tboxIDRute.Text = pobuss + cboxBandara.SelectedValue.ToString() + fromto + destina + "001";
                    }
                    else
                    {
                        string idterakhir = dtjumlahrute.Rows[jumlahrowss]["rute_id"].ToString();
                        int angkaterakhir = Convert.ToInt32(idterakhir.Substring(11, 3)) + 1;
                        string angka = angkaterakhir.ToString();

                        if(dtjumlahrute.Rows.Count < 10)
                        {
                            idd += pobuss;
                            idd += cboxBandara.SelectedValue.ToString();
                            idd += fromto;
                            idd += destina;
                            idd += "00";
                            idd += angka;
                        }
                        else if (dtjumlahrute.Rows.Count >= 10 && dtjumlahrute.Rows.Count < 100)
                        {
                            idd += pobuss;
                            idd += cboxBandara.SelectedValue.ToString();
                            idd += fromto;
                            idd += destina;
                            idd += "0";
                            idd += angka;
                        }
                        else if (dtjumlahrute.Rows.Count >= 100)
                        {
                            idd += pobuss;
                            idd += cboxBandara.SelectedValue.ToString();
                            idd += fromto;
                            idd += destina;
                            idd += angka;
                        }
                        tboxIDRute.Text = idd.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refreshDGV()
        {
            try
            {

                //sqlConnect = new MySqlConnection(connectString);

                DataTable dtListRute = new DataTable();

                sqlQuery = "select rute_id as `ID Rute`,concat(v_brand,'  /  ',v_jenis,'  [',v_capacity,']') as `Vehicle`, airport_id as `Airport`, if(rute_fromto = 'F','From','To') as `From or To`, rute_halte as `Destination`, RUTE_WAKTUBERANGKAT as `Time`, rute_price as `Harga` from rute r, vehicle v where v.pobus_id = '"+FormWelcome.pobusid+"' and r.v_id = v.v_id";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListRute);

                dgvRute.DataSource = dtListRute;

                dgvRute.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbutDari_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fromto = "F";
                generateID();
                labKeDari.Text = "Ke";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbutKe_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                fromto = "T";
                generateID();
                labKeDari.Text = "Dari";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxBandara_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                generateID();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tboxDestination_TextChanged(object sender, EventArgs e)
        {
            try
            {
                generateID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //sqlConnect = new MySqlConnection(connectString);
                DataTable cekrute = new DataTable();
                sqlQuery = "select * from rute where airport_id = '"+ cboxBandara.SelectedValue.ToString() + "' and v_id = '"+cboxKendaraan.SelectedValue.ToString()+"' and rute_halte = '"+tboxDestination.Text+"' and rute_price = '"+tboxPrice.Text.ToString()+"' and rute_fromto = '"+fromto+"' and rute_waktuberangkat = '"+time+"'";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(cekrute);

                int datacount = cekrute.Rows.Count;

                time = cboxJam.SelectedItem.ToString() + ":" + cboxMenit.SelectedItem.ToString();
                

                if(tboxIDRute.Text == "" || time == "00:00" || cboxKendaraan.SelectedIndex == -1 || tboxPrice.Text == "")
                {
                    MessageBox.Show("Data ada yang kosong!");
                }
                else if(datacount != 0)
                {
                    MessageBox.Show("Rute sudah tersedia!");
                }
                else
                {
                    //sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into rute values ('"+tboxIDRute.Text+"','"+cboxBandara.SelectedValue.ToString()+"','"+cboxKendaraan.SelectedValue.ToString()+"','"+tboxDestination.Text+"','"+tboxPrice.Text+"','"+fromto+"','"+time+"','0')";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();

                    DataTable ceksudahada = new DataTable();
                    sqlQuery = "select * from airport_pobus where airport_id = '" + cboxBandara.SelectedValue.ToString() + "' and pobus_id = '" + FormWelcome.pobusid + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(ceksudahada);

                    if(ceksudahada.Rows.Count == 0)
                    {
                        sqlQuery = "insert into airport_pobus values ('" + cboxBandara.SelectedValue.ToString() + "','" + FormWelcome.pobusid + "')";
                        sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                        fWelcome.conn.Open();
                        sqlCommand.ExecuteNonQuery();
                        fWelcome.conn.Close();
                    }
                    //sqlConnect = new MySqlConnection(connectString);

                    refreshDGV();

                    tboxIDRute.Text = "";
                    rbutDari.Checked = true;
                    cboxBandara.SelectedIndex = -1;
                    tboxDestination.Text = "";
                    cboxJam.SelectedIndex = -1;
                    cboxMenit.SelectedIndex = -1;
                    cboxKendaraan.SelectedIndex = -1;
                    tboxPrice.Text = "";
                    labError.Text = "-";
                }
            }
            catch (Exception ex)
            {
                fWelcome.conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cboxJam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxMenit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDdelete = dgvRute.Rows[e.RowIndex].Cells["ID Rute"].Value.ToString();
                butDelete.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Remove this route?", "Route Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // di cek dulu adakah rute yang menggunakan v_id tersebut, kalau ada 
                    // di kasih pilihan, ganti kendaraan atau insert kendaraan(langsung menggantikan v_id di rute)
                    // ada cancel

                    // delete logical pesan transaksi dsb yang berhubungan



                    //sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "delete from rute where rute_id = '" + IDdelete + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();
                    MessageBox.Show("Route has been removed!");
                    IDdelete = "";

                    refreshDGV();
                    butDelete.Enabled = false;
                }
                else
                {
                    IDdelete = "";
                    butDelete.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                fWelcome.conn.Close();
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            var pwnotelp1 = new LandingPage();
            pwnotelp1.ShowDialog();
        }
    }
}
