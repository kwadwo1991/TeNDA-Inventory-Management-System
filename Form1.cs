using System;
using System.Windows.Forms;

namespace TeNDA_Inventory_Management_System
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked == true)
                pass.UseSystemPasswordChar = true;

            else
                pass.UseSystemPasswordChar = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            user.Text = "";
            pass.Text = "";
        }
    }
}
