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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            try
            {
                FormForgotPassEmail formForgotPassEmail = new FormForgotPassEmail();
                formForgotPassEmail.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelHereRegister_Click(object sender, EventArgs e)
        {
            try
            {
                FormRegister formRegister = new FormRegister();
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
    }
}
