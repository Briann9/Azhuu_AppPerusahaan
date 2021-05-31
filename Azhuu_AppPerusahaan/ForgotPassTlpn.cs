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
    public partial class FormForgotPassTlpn : Form
    {
        public FormForgotPassTlpn()
        {
            InitializeComponent();
        }

        private void FormForgotPassTlpn_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            try
            {
                FormNewPassword formNewPassword = new FormNewPassword();
                formNewPassword.Show();
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
