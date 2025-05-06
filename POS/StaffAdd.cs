using POS_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkStation
{
    public partial class StaffAdd : SampleAdd
    {
        public StaffAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void StaffAdd_Load(object sender, EventArgs e)
        {

        }

        public override void BtnSave(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into staff Values(@Name, @phone, @role)";
            }
            else
            {
                qry = "update staff set sName = @Name, sPhone = @phone, sRole= @role where staffID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully..");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();
            }
            else
            {
                guna2MessageDialog1.Show("Error Ocurred");
            }
        }
    }
}
