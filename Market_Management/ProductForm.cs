using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer_Market.Operations;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;
namespace Market_Management
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageCategory mc = new ManageCategory();
            mc.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SellerForm sel = new SellerForm();
            sel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMProduct pro = new EMProduct();
            OMProduct OMP = new OMProduct();

            pro.ProdId = PIDtxt.Text;
            pro.ProdName = PNAMEtxt.Text;
            pro.ProdQuantity = PQUANTITYtxt.Text;
            pro.ProdPrice = PPRICEtxt.Text;
            pro.ProdCategory = ProCatCB.SelectedItem.ToString();
            int flag = OMP.Add(pro);
            if (flag > 0)
            {
                MessageBox.Show("Sucessfully Inserted");
            }
            else
            {
                MessageBox.Show("Can't Insert ");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OMProduct OMP = new OMProduct();
            SqlDataAdapter sqlDataAdapter = OMP.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            PROGDV.DataSource = dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMProduct pro = new EMProduct();
            OMProduct OMP = new OMProduct();

            pro.ProdId = PIDtxt.Text;
            pro.ProdName = PNAMEtxt.Text;
            pro.ProdQuantity = PQUANTITYtxt.Text;
            pro.ProdPrice = PPRICEtxt.Text;
            pro.ProdCategory = ProCatCB.SelectedItem.ToString();

            int flag = OMP.Edit(pro);
            if (flag > 0)
            {
                MessageBox.Show("Sucessfully Edited");
            }
            else
            {
                MessageBox.Show("Can't Edit ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMProduct pro = new EMProduct();
            OMProduct OMP = new OMProduct();

            pro.ProdId = PIDtxt.Text;
            pro.ProdName = PNAMEtxt.Text;
            pro.ProdQuantity = PQUANTITYtxt.Text;
            pro.ProdPrice = PPRICEtxt.Text;
            pro.ProdCategory = ProCatCB.SelectedItem.ToString();
        

            int flag = OMP.Delete(pro);
            if (flag > 0)
            {
                MessageBox.Show("Sucessfully Deleted");
            }
            else
            {
                MessageBox.Show("Can't Delete ");
            }
        }
    }
}
