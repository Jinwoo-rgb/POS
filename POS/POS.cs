using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkStation;

namespace POS_System
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        public string Ordertype;
        private void POS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();
            
            ProductPanel.Controls.Clear();
            LoadProducts();
        }

        private void AddCategory()
        {
            string qry = "select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

           CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0 )
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(134, 45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();

                    b.Click += new EventHandler(b_Click);

                    CategoryPanel.Controls.Add(b);
                }
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;

            if(b.Text == "All Categories")
            {
                txtSearch.Text = "1";
                txtSearch.Text = "";
                return;
            }
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id, String proID, string name, string cat, string price, Image pimage)
        {
            var w = new ucProduct()
            {
                Pname = name,
                PPrice = price,
                PCategory = cat,
                PImage = pimage,
                id = Convert.ToInt32(proID)
            };

            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        return;

                    }
                }
                guna2DataGridView1.Rows.Add(new object[] { 0, 0, wdg.id, wdg.Pname, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        private void LoadProducts()
        {
            string qry = "select * from products inner join category on catID = CategoryID ";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] imagebytearray = imagearray;

                AddItems("0", item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                    item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }
            
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.Pname.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void GetTotal()
        {
            double total = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            lblTotal.Text = total.ToString("N2");
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lbTable.Text = "";
            lbWaiter.Text = "";
            lbTable.Visible = false;
            lbWaiter.Visible = false;
            lblTotal.Text = "00";
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lbTable.Text = "";
            lbWaiter.Text = "";
            lbTable.Visible = false;
            lbWaiter.Visible = false;
            Ordertype = "Delivery";
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            lbTable.Text = "";
            lbWaiter.Text = "";
            lbTable.Visible = false;
            lbWaiter.Visible = false;
            Ordertype = "Take Away";
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            Ordertype = "Din In";
            TableSelect tableSelect = new TableSelect();
            tableSelect.ShowDialog();
            if (tableSelect.TableName != "")
            {
                lbTable.Text = tableSelect.TableName;
                lbTable.Visible = true;
            }
            else
            {
                lbTable.Text = "";
                lbTable.Visible = false;
            }

            WaiterSelect waiterSelect = new WaiterSelect();
            waiterSelect.ShowDialog();
            if (waiterSelect.waiterName != "")
            {
                lbWaiter.Text = waiterSelect.waiterName;
                lbWaiter.Visible = true;
            }
            else
            {
                lbWaiter.Text = "";
                lbWaiter.Visible = false;
            }
        }

        private void btnKOT_Click(object sender, EventArgs e)
        {
            string qry1 = "";
            string qry2 = "";

            int detailID = 0;

            if (MainID == 0)
            {
                qry1 = @"insert into tblMain Values (@aDate, @aTime, @TableName, @WaiterName, @status, @ordertype, @total, @recieved, @change); select SCOPE_IDENTITY()";
            }
            else
            {
                qry1 = @"update tblMain set status = @status, total = @total, recieved = @recieved, change = @change where MainID = @ID";
            }

            Hashtable ht = new Hashtable(); 

            SqlCommand cmd = new SqlCommand(qry1, MainClass.con); 
            cmd.Parameters.AddWithValue("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate",Convert.ToDateTime(DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString()); 
            cmd.Parameters.AddWithValue("@TableName", lbTable.Text);
            cmd.Parameters.AddWithValue("@WaiterName", lbWaiter.Text);
            cmd.Parameters.AddWithValue("@status", "Pending");
            cmd.Parameters.AddWithValue("@orderType", Ordertype);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@recieved", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if (MainClass.con.State == ConnectionState.Closed)
            {
                MainClass.con.Open();
            }
            if (MainID == 0 )
            {
                MainID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                cmd.ExecuteNonQuery();
            }
            if (MainClass.con.State == ConnectionState.Open)
            {
                MainClass.con.Close();
            }

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if (detailID == 0)
                {
                    qry2 = @" insert into tblDetails values (@MainID, @proID , @qty, @price, @amount)";
                }
                else
                {
                    qry2 = @" update tblDetails set proID = @proID , qty = @qty, price = @price, amount = @amount where DetailID = @ID ";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32(row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed)
                {
                    MainClass.con.Open();
                }
                cmd2.ExecuteNonQuery();
                if (MainClass.con.State == ConnectionState.Open)
                {
                    MainClass.con.Close();
                }

                guna2MessageDialog1.Show("Saved Successfully");
                MainID = 0;
                detailID = 0;
                guna2DataGridView1.Rows.Clear();
                lbTable.Text = "";
                lbWaiter.Text = "";
                lbTable.Visible = false;
                lbWaiter.Visible = false;
                lblTotal.Text = "00";
            }
        }
    }
}
