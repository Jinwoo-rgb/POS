using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkStation;

namespace POS_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AddControls(new Form_Category());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddControls(new Product_View());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddControls(new Staff_View());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            POS pOS = new POS();
            pOS.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            AddControls(new KitchenView());
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void ControlsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            
        }

        private void tablebtn(object sender, EventArgs e)
        {
            AddControls(new TableView());
        }
    }
}
