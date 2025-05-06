using DevExpress.Pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class ProductAdd : SampleAdd
    {
        public ProductAdd()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;

        private void brwseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Images(.jpg; .jpeg; .png)|* .jpg;* .jpeg;* .png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                filePath = open.FileName;
                txtPic.Image = new Bitmap(filePath);
            }
        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "select catID 'id' , catName 'name' from category";
            MainClass.CBFill(qry, cbCat);

            if(cID > 0)
            {
                cbCat.SelectedValue = cID;
            }

            if(id > 0)
            {
                ForUpdateLoadData();
            }
        }

        string filePath;
        Byte[] imageByteArray;

        public override void BtnSave(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into products Values(@Name, @price, @cat, @img)";
            }
            else
            {
                qry = "update products set pName=@Name, pPrice=@price, CategpryID=@cat, pImage=@img where pID=@id";
            }

            Image temp = new Bitmap(txtPic.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@price", txtPrice.Text);
            ht.Add("@cat", Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@img", imageByteArray);

            if (MainClass.SQL(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully..");
                id = 0;
                cID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                cbCat.SelectedIndex = 0;
                cbCat.SelectedIndex = -1;
                txtPic.Image = POS_System.Properties.Resources.product;

                txtName.Focus();
            }
            else
            {
                guna2MessageDialog1.Show("Error Occured");
            }
        }

        private void ForUpdateLoadData()
        {
            string qry = "select * from products where pID = "+@id+"";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtName.Text = dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                byte[] imageByteArray = imageArray;
                txtPic.Image = Image.FromStream(new  MemoryStream(imageArray));
            }
        }
    }
}
