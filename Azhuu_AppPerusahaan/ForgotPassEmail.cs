using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azhuu_AppPerusahaan
{
    public partial class FormForgotPassEmail : Form
    {
        public FormForgotPassEmail()
        {
            InitializeComponent();
        }

        private void FormForgotPassEmail_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                FormForgotPassTlpn formForgotPassTlpn = new FormForgotPassTlpn();
                formForgotPassTlpn.Show();
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
    }
}
