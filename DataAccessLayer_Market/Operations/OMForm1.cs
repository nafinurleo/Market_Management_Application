using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;
using System.Data;


namespace DataAccessLayer_Market.Operations
{
    public class OMForm1
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
        public int Signup(EMForm1 signup) 
        
        {
            Con.Open();
            string customer = "CUSTOMER";
            SqlCommand cmd = new SqlCommand("Insert into Logintbl(UserPhone,UsreName,UserPass,UserCategory) values('" + signup.UserPhone + "','" + signup.UserName + "','" + signup.UserPass + "','"+ customer.ToString() +"')", Con);
            int flag = cmd.ExecuteNonQuery();
            Con.Close();
            return flag;
        }
    }
}
