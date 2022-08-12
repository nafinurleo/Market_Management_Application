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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMForm1 EMF = new EMForm1();
            OMForm1 OMF = new OMForm1();

            EMF.UserName = Cnametxt.Text;
            EMF.UserPhone= CPhonetxt.Text;
            EMF.UserPass = Cpasstxt.Text;
            EMF.UserCategory = ccPasstxt.Text;
            if (Cpasstxt.Text != ccPasstxt.Text) 
            {
                MessageBox.Show("Please check the password again");
                    }
            else
            {
                int flag = OMF.Signup(EMF);
                if (flag > 0)
                {
                    MessageBox.Show("Sucessfully inserted");
                }
                else
                {
                    MessageBox.Show("Not Inserted ");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
