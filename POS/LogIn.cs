using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoreUI.Controls;

namespace POS_System
{
    public partial class LogIn: Form
    {
  
        public LogIn()
        {
            InitializeComponent();
        }

        private void cuiButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            if(MainClass.IsValidUser(txtUser.Text, txtPass.Text) == false)
            {
                MessageBox.Show("invalid Username or password");
                return;
            }
            else
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
        }

        private void txtUser_ContentChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_ContentChanged_1(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void dungeonLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
