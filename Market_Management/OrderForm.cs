using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer_Market.Entities;
using DataAccessLayer_Market.Operations;
using System.Data.SqlClient;

namespace Market_Management
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OMOrder OMOr = new OMOrder();
            EMOreder EMOr = new EMOreder();

            EMOr.Product_id = OProdIDtxt.Text;
            EMOr.Prduct_name = ProdNametxt.Text;
            EMOr.Product_category = CatCB.SelectedText;
            EMOr.Product_quantity = Convert.ToDouble(Prod_QTYtxt.Text);
            EMOr.Product_price =Convert.ToInt32(ProdPrice.Text);
            


            MessageBox.Show("Product Name   "+ ProdNametxt.Text + "\nProduct Price    "+Convert.ToInt32(ProdPrice.Text)+"\n"+"Total cost          "+(Convert.ToInt32(Prod_QTYtxt.Text)*Convert.ToInt32(ProdPrice.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OMOrder OMOr = new OMOrder();
            EMOreder EMOr = new EMOreder();

            EMOr.Product_id = OProdIDtxt.Text;
            EMOr.Prduct_name = ProdNametxt.Text;
            EMOr.Product_category = CatCB.SelectedItem.ToString();
            EMOr.Product_quantity = Convert.ToDouble(Prod_QTYtxt.Text);
            EMOr.Product_price = Convert.ToInt32(ProdPrice.Text);

            int flag = OMOr.Order(EMOr);

            if (flag > 0)
            {
                MessageBox.Show("Sucessfully Ordered ");
            }
            else
            {
                MessageBox.Show("Can't Order ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OMOrder OMOr = new OMOrder();
            SqlDataAdapter sqlDataAdapter = OMOr.Show();
            
            DataTable OMOdata = new DataTable();
            sqlDataAdapter.Fill(OMOdata);
          
            ProductshowGDV.DataSource = OMOdata;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
