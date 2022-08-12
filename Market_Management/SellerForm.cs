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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageCategory mc = new ManageCategory();
            mc.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMSeller EMS = new EMSeller();
            OMSeller OMS = new OMSeller();

         


            EMS.SellerPhone = SPHONEtxt.Text;
            EMS.SellerName = SNAMEtxt.Text;
            EMS.Sellerpass = Spass.Text;
          



            int flag = OMS.Add( EMS);

            if (flag > 0)
            {
                MessageBox.Show("Sucessfully inserted");
            }
            else
            {
                MessageBox.Show("Can't Insert ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMSeller EMS = new EMSeller();
            OMSeller OMS = new OMSeller();

           


            EMS.SellerPhone = SPHONEtxt.Text;
            EMS.SellerName = SNAMEtxt.Text;
            EMS.Sellerpass = Spass.Text;

            int flag = OMS.Edit(EMS);

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
            EMSeller EMS = new EMSeller();
            OMSeller OMS = new OMSeller();



            EMS.SellerPhone = SPHONEtxt.Text;
            EMS.SellerName = SNAMEtxt.Text;
            EMS.Sellerpass = Spass.Text;

            int flag = OMS.Delete(EMS);
        
            if (flag > 0)
            {
                MessageBox.Show("Sucessfully Deleted");
            }
            else
            {
                MessageBox.Show("Can't Delete");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            OMSeller OMS = new OMSeller();
            SqlDataAdapter sqlDataAdapter = OMS.Show();
           
            DataTable OMSdata = new DataTable();
            sqlDataAdapter.Fill(OMSdata);
            
            SELLERDVG.DataSource = OMSdata;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OMSeller OMS = new OMSeller();
            SqlDataAdapter sqlDataAdapter = OMS.Show();
            DataTable OMSdata = new DataTable();
            SELLERDVG.DataSource = OMSdata;

        }
    }
}
