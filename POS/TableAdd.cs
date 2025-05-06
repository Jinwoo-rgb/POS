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

namespace POS_System
{
    public partial class TableAdd : SampleAdd
    {
        public TableAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void BtnSave(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into tables Values(@Name)";
            }
            else
            {
                qry = "update tables Set tname=@Name where tID=@id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully..");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
            else
            {
                guna2MessageDialog1.Show("Error Occured");
            }
        }

        private void TableAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
