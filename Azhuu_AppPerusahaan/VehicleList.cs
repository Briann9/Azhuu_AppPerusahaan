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
    public partial class VehicleList : Form
    {
        public VehicleList()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        private void VehicleList_Load(object sender, EventArgs e)
        {
            try
            {
                cboxType.Items.Add("Mobil");
                cboxType.Items.Add("Mini Bus");
                cboxType.Items.Add("Bus Single Deck");
                cboxType.Items.Add("Bus Double Deck");

                cboxType.SelectedIndex = -1;


                sqlConnect = new MySqlConnection(connectString);

                DataTable dtV_List = new DataTable();
                sqlQuery = "select v_brand as `Brand`, v_jenis as `Type`, v_capacity as `Capacity`, v_license as `License Plate` from vehicle where pobus_id = '" + FormWelcome.pobusid + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtV_List);

                dgvVList.DataSource = dtV_List;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void untukID()
        {
            string hurufdepanmerk;
            string depanID;


            if (string.IsNullOrEmpty(tboxBrand.Text) || string.IsNullOrEmpty(tboxCapacity.Text))
            {
                tboxV_ID.Text = "";
            }
            else
            {
                hurufdepanmerk = tboxBrand.Text.Substring(0, 1).ToUpper();
                depanID = FormWelcome.pobusid.Substring(0, 1).ToUpper() + hurufdepanmerk; // 2huruf  3angka urutan + C + kapasitas


                sqlConnect = new MySqlConnection(connectString);
                DataTable untukIDkendaraan = new DataTable();
                sqlQuery = "select v_id, v_capacity from vehicle where pobus_id = '" + FormWelcome.pobusid + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(untukIDkendaraan);

                int jumlahrows = untukIDkendaraan.Rows.Count - 1;
                if (jumlahrows == -1)
                {
                    tboxV_ID.Text = depanID + "001C" + tboxCapacity.Text.ToString();
                }
                else
                {
                    string idterakhir = untukIDkendaraan.Rows[jumlahrows]["v_id"].ToString();
                    int angkaterakhir = Convert.ToInt32(idterakhir.Substring(2, 3)) + 1;
                    string angka = angkaterakhir.ToString();

                    if (untukIDkendaraan.Rows.Count < 10)
                    {
                        depanID += "00";
                        depanID += angka;
                        depanID += "C";
                        depanID += tboxCapacity.Text.ToString();
                    }
                    else if (untukIDkendaraan.Rows.Count >= 10 && untukIDkendaraan.Rows.Count < 100)
                    {
                        depanID += "0";
                        depanID += angka;
                        depanID += "C";
                        depanID += tboxCapacity.Text.ToString();
                    }
                    else if (untukIDkendaraan.Rows.Count >= 100)
                    {
                        depanID += angka;
                        depanID += "C";
                        depanID += tboxCapacity.Text.ToString();
                    }
                    tboxV_ID.Text = depanID.ToString();
                }
            }
        }

        private void tboxBrand_TextChanged(object sender, EventArgs e)
        {
            untukID();
        }
        
        private void tboxCapacity_TextChanged(object sender, EventArgs e)
        {
            untukID();
        }

        private void tboxCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if(tboxV_ID.Text == "" || tboxBrand.Text == "" || cboxType.SelectedIndex == -1 || tboxCapacity.Text == "" || tboxPlate.Text == "")
                {
                    labError.Text = "Ada data yang kosong!";
                }
                else
                {
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "insert into vehicle values ('"+tboxV_ID.Text+"','"+FormWelcome.pobusid+"','"+tboxPlate.Text+"','"+cboxType.SelectedItem+"','"+tboxCapacity.Text+"','"+tboxBrand.Text+"','0')";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    sqlConnect = new MySqlConnection(connectString);

                    DataTable dtV_List = new DataTable();
                    sqlQuery = "select v_brand as `Brand`, v_jenis as `Type`, v_capacity as `Capacity`, v_license as `License Plate` from vehicle where pobus_id = '" + FormWelcome.pobusid + "'";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtV_List);

                    dgvVList.DataSource = dtV_List;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
