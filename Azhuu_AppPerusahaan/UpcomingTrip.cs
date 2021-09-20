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
        FormWelcome fWelcome;
        //MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        //string connectString = "server=localhost;uid=root;pwd=;database=airport_shuttle;";
        string sqlQuery;

        int cekdgvklik = 0;
        string ruteidddddd = "";
        string tanggalbookkk = "";
        public void init(FormWelcome f)
        {
            fWelcome = f;
        }
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
                DataTable tanggallll = new DataTable();
                //sqlConnect = new MySqlConnection(connectString);
                sqlQuery = "select curdate() -1";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(tanggallll);

                string okelah = tanggallll.Rows[0][0].ToString();

                string tanggalkemaren = okelah.Substring(0, 4) + "-" + okelah.Substring(4, 2) + "-" + okelah.Substring(6, 2);

                //sqlConnect = new MySqlConnection(connectString);

                DataTable dtUTrip = new DataTable();
                sqlQuery = "select tp_bookingid as `Booking ID`, pt.rute_id as `Rute ID`,concat(airport_id,' ', if(rute_fromto = 'F','From','To'),' ',rute_halte) as `Trip`, tp_tanggaltransksi as `Tanggal Transaksi`, tp_tanggalbooking as `Tanggal Booking`,TP_TOTALPRICE as `Harga` from pesan_transaksi pt, vehicle v, rute r where pt.rute_id = r.rute_id and r.v_id = v.v_id and pobus_id = '"+FormWelcome.pobusid+ "' and TP_TANGGALBOOKING > '"+tanggalkemaren+"' group by pt.rute_id";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
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
                


                string ruteid = dgvUpcomingTrip.Rows[e.RowIndex].Cells["Rute ID"].Value.ToString();
                MessageBox.Show(ruteid);

                //sqlConnect = new MySqlConnection(connectString);

                DataTable dtListTrip = new DataTable();
                sqlQuery = "select pt.rute_id as `Rute ID`, concat(airport_id,'  ', if(rute_fromto = 'F','Ke','Dari'),'  ', rute_halte) as `Trip`, TP_TANGGALBOOKING as `Tanggal Berangkat` from pesan_transaksi pt, rute r where pt.rute_id = '"+ruteid+"' and r.rute_id = pt.rute_id";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListTrip);

                dgvListTrip.DataSource = dtListTrip;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        

        private void dgvListTrip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cekdgvklik = 1;
                // keluarkan di dgv baru siapa2 saja penumpangnya
                string ruteid = dgvListTrip.Rows[e.RowIndex].Cells["Rute ID"].Value.ToString();
                string tanggalbook1 = dgvListTrip.Rows[e.RowIndex].Cells["Tanggal Berangkat"].Value.ToString();
                ruteidddddd = ruteid;

                DateTime tanggalbook = Convert.ToDateTime(tanggalbook1);
                string tanggalbeneran = tanggalbook.ToString("yyyy-MM-dd");
                tanggalbookkk = tanggalbeneran;

                //sqlConnect = new MySqlConnection(connectString);

                DataTable dtListPenumpang = new DataTable();
                sqlQuery = "select p.p_nik as `NIK`, p_nama as `Nama`,tp.tp_bookingid as `Booking ID` from penumpang p, transaksi_penumpang tp, pesan_transaksi pt where p.p_nik = tp.P_NIK and pt.TP_BOOKINGID = tp.TP_BOOKINGID and pt.RUTE_ID = '"+ruteid+"' and pt.tp_tanggalbooking = '"+tanggalbeneran+ "' and pt.tp_bookingstatus = 'O'";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtListPenumpang);

                dgvListPenumpang.DataSource = dtListPenumpang;

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
                if (cekdgvklik == 1)
                {
                    MessageBox.Show(ruteidddddd);
                    MessageBox.Show(tanggalbookkk);
                    //sqlConnect = new MySqlConnection(connectString);
                    sqlQuery = "update pesan_transaksi set tp_bookingstatus = 'F' where rute_id = '"+ruteidddddd+"' and tp_tanggalbooking = '"+tanggalbookkk+"'";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    fWelcome.conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    fWelcome.conn.Close();
                    MessageBox.Show("Perjalanan Sudah Selesai!");

                    //sqlConnect = new MySqlConnection(connectString);

                    DataTable dtListPenumpang = new DataTable();
                    sqlQuery = "select p.p_nik as `NIK`, p_nama as `Nama`,tp.tp_bookingid as `Booking ID` from penumpang p, transaksi_penumpang tp, pesan_transaksi pt where p.p_nik = tp.P_NIK and pt.TP_BOOKINGID = tp.TP_BOOKINGID and pt.RUTE_ID = '" + ruteidddddd + "' and pt.tp_tanggalbooking = '" + tanggalbookkk + "' and pt.tp_bookingstatus = 'O'";
                    sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtListPenumpang);

                    dgvListPenumpang.DataSource = dtListPenumpang;
                }
                else
                {
                    MessageBox.Show("Trip Belum di Pilih!");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            var pwnotelp1 = new LandingPage();
            pwnotelp1.init(fWelcome);
            pwnotelp1.ShowDialog();
        }
    }
}
