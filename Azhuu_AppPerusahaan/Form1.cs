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
    public partial class FormTransaksiTerlaris : Form
    {
        public FormTransaksiTerlaris()
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
        private void FormTransaksiTerlaris_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTerlaris = new DataTable();
                sqlQuery = "select * from transaksi_terlaris ";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTerlaris);
                dgvTerlaris.DataSource = dtTerlaris;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var pwnotelp1 = new LandingPage();
                pwnotelp1.init(fWelcome);
                pwnotelp1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butTT_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTerlaris = new DataTable();
                sqlQuery = "select * from transaksi_terlaris ";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTerlaris);
                dgvTerlaris.DataSource = dtTerlaris;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void but_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTerlaris = new DataTable();
                sqlQuery = "select * from airport_maxcapacity";
                sqlCommand = new MySqlCommand(sqlQuery, fWelcome.conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtTerlaris);
                dgvTerlaris.DataSource = dtTerlaris;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
