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
    }
}
