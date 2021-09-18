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
    public partial class FormWelcome : Form
    {
        public MySqlConnection conn;
        public FormWelcome()
        {
            InitializeComponent();
        }
        private void openDBConn()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=139.255.11.84; uid=student; pwd=isbmantap; database=KMMI8;";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                MessageBox.Show("Sukses terKONEKSI ke Database!");
                //FormMenu fMenu = new FormMenu();
                //fMenu.init(this);
                //fMenu.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        public static string pobusid;

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                openDBConn();
                this.Hide();
                FormSignIn formSignIn = new FormSignIn();
                formSignIn.init(this);
                LandingPage landing = new LandingPage();
                landing.init(this);
                formSignIn.Show();

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
                openDBConn();
                this.Hide();
                FormRegister formRegister = new FormRegister();
                formRegister.init(this);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
