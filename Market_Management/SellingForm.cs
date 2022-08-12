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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OMSelling OMC = new OMSelling();
            SqlDataAdapter sqlDataAdapter = OMC.Show();
            
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView2.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            EMSelling EMSE = new EMSelling();
            OMSelling OMSE = new OMSelling();
          

            EMSE.Bill_no = Bill_Notxt.Text;
            EMSE.Prod_name = Product_Nametxt.Text;
            EMSE.Sell_Quantity = Convert.ToInt32(Quantitytxt.Text);
            EMSE.Prod_Price =Convert.ToDouble( Pricetxt.Text);
            
            datelable.Text=    DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            EMSE.Sell_date = datelable.Text;

            int flag = OMSE.Add(EMSE);
            
            if (flag > 0)
            {
                MessageBox.Show("Sucessfully inserted");
            }
            else
            {
                MessageBox.Show("Not Inserted ");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OMSelling OMC = new OMSelling();
            SqlDataAdapter sqlDataAdapter = OMC.ShowSelling();
           
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            SELLING_DGV.DataSource = dataTable;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void SELLING_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OMSelling OMC = new OMSelling();
            SqlDataAdapter sqlDataAdapter = OMC.counting();
           
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            
            TotalamountGDV.DataSource = dataTable;

        }

        private void datelable_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
