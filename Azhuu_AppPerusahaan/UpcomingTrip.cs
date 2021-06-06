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
    public partial class UpcomingTrip : Form
    {
        public UpcomingTrip()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        private void UpcomingTrip_Load(object sender, EventArgs e)
        {
            try
            {
                refreshDGV();
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

                DataTable dtUTrip = new DataTable();
                sqlQuery = "select tp_bookingid as `Booking ID`, pt.rute_id as `Rute ID`,concat(airport_id,' ', if(rute_fromto = 'F','From','To'),' ',rute_halte) as `Trip`, tp_tanggaltransksi as `Tanggal Transaksi`, tp_tanggalbooking as `Tanggal Booking`,TP_TOTALPRICE as `Harga` from pesan_transaksi pt, vehicle v, rute r where pt.rute_id = r.rute_id and r.v_id = v.v_id and pobus_id = '"+FormWelcome.pobusid+ "' group by pt.rute_id";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtUTrip);

                dgvUpcomingTrip.DataSource = dtUTrip;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvUpcomingTrip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // keluarkan di dgv baru siapa2 saja penumpangnya
                string ruteid = dgvDaftarPenumpang.Rows[e.RowIndex].Cells["Rute ID"].ToString();

                sqlConnect = new MySqlConnection(connectString);

                DataTable dtListPenumpang = new DataTable();
                sqlQuery = "";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListPenumpang);

                dgvDaftarPenumpang.DataSource = dtListPenumpang;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDaftarPenumpang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // muncul messagebox penumpang sudah ada?, oke, cancel
                // ganti status transaksi_penumpang
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butDone_Click(object sender, EventArgs e)
        {
            try
            {
                // ganti semua transaksi_penumpang
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            var pwnotelp1 = new LandingPage();
            pwnotelp1.ShowDialog();
        }
    }
}
