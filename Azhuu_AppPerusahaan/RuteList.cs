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

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        string fromto = "F";
        string time = "00:00";
        private void RuteList_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnect = new MySqlConnection(connectString);

                DataTable dtListAirport = new DataTable();
                sqlQuery = "select airport_id as `ID`, concat('[',`airport_id`,']',`airport_name`) as `Airport` from airport";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListAirport);

                cboxBandara.DataSource = dtListAirport;
                cboxBandara.DisplayMember = "Airport";
                cboxBandara.ValueMember = "ID";
                cboxBandara.SelectedIndex = -1;


                DataTable dtListKendaraan = new DataTable();
                sqlQuery = "select v_id, concat(v_brand, '  (',v_capacity,')  ', '[',v_license,']') as `Vehicle` from vehicle where pobus_id = '"+FormWelcome.pobusid+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListKendaraan);

                cboxKendaraan.DataSource = dtListKendaraan;
                cboxKendaraan.DisplayMember = "Vehicle";
                cboxKendaraan.ValueMember = "v_id";
                cboxKendaraan.SelectedIndex = -1;



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
                string destina = tboxDestination.Text.Substring(0, 3).ToUpper();
                string idd = "";


                if (cboxBandara.SelectedIndex == -1 || string.IsNullOrEmpty(tboxDestination.Text))
                {
                    tboxIDRute.Text = "";
                }
                else
                {
                    sqlConnect = new MySqlConnection(connectString);


                    DataTable dtjumlahrute = new DataTable();
                    sqlQuery = "select rute_id from rute where airport_id = '"+cboxBandara.ValueMember.ToString()+"'' and rute_fromto = '"+fromto+"' and rute_halte = '"+destina+"'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtjumlahrute);

                    int jumlahrowss = dtjumlahrute.Rows.Count;
                    if(jumlahrowss == -1)
                    {
                        tboxIDRute.Text = cboxBandara.ValueMember.ToString() + fromto + destina + "001";
                    }
                    else
                    {
                        string idterakhir = dtjumlahrute.Rows[jumlahrowss]["rute_id"].ToString();
                        int angkaterakhir = Convert.ToInt32(idterakhir.Substring(7, 3)) + 1;
                        string angka = angkaterakhir.ToString();

                        if(dtjumlahrute.Rows.Count < 10)
                        {
                            idd = cboxBandara.ValueMember.ToString() + fromto + destina + "00" + angka;
                        }
                        else if (dtjumlahrute.Rows.Count >= 10 && dtjumlahrute.Rows.Count < 100)
                        {
                            idd = cboxBandara.ValueMember.ToString() + fromto + destina + "0" + angka;
                        }
                        else if (dtjumlahrute.Rows.Count >= 100)
                        {
                            idd = cboxBandara.ValueMember.ToString() + fromto + destina + angka;
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

                sqlConnect = new MySqlConnection(connectString);

                DataTable dtListRute = new DataTable();

                sqlQuery = "select rute_id as `ID Rute`, airport_id as `Airport`, if(rute_fromto = 'F','From','To') as `From or To`, rute_halte as `Destination`, RUTE_WAKTUBERANGKAT as `Time` from rute where pobus_id = '"+FormWelcome.pobusid+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListRute);

                dgvRute.DataSource = dtListRute;

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
                sqlConnect = new MySqlConnection(connectString);
                DataTable cekrute = new DataTable();
                sqlQuery = "select * from rute where airport_id = '"+cboxBandara.ValueMember.ToString()+"' and v_id = '"+cboxKendaraan.SelectedValue.ToString()+"' and rute_destination = '"+tboxDestination.Text+"' and rute_price = '"+tboxPrice.Text.ToString()+"' and rute_fromto = '"+fromto+"' and rute_waktuberangkat = '"+time+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(cekrute);

                int datacount = cekrute.Rows.Count;

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

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
