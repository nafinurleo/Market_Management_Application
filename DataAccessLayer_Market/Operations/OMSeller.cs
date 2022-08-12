using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_Market.Entities;
using System.Data.SqlClient;



namespace DataAccessLayer_Market.Operations
{
    public class OMSeller
    {
        
        
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
            public int Add(EMSeller add)
            {
                
                Con.Open();
            
            string categoty = "SELLER";
            SqlCommand cmd = new SqlCommand(" INsert into Logintbl (UserPhone, UsreName, UserPass,UserCategory) values('"+add.SellerPhone+"','"+add.SellerName+"','"+add.Sellerpass+"','"+ categoty + "')", Con);    
            int flag = cmd.ExecuteNonQuery();
                Con.Close();
                return flag;
            }
            public SqlDataAdapter Show()
            {
                Con.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from  Logintbl where UserCategory= 'SELLER'", Con);
                return sqlDataAdapter;
            }
            public int Edit(EMSeller edit)
            {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf";Integrated Security=True;Connect Timeout=30
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
                Con.Open();
      
            SqlCommand cmd = new SqlCommand("UPDATE Logintbl SET UsreName ='" + edit.SellerName + "',  UserPass ='" + edit.Sellerpass +  "' WHERE UserPhone ='" + edit.SellerPhone + "';", Con);


            int flag = cmd.ExecuteNonQuery();
                Con.Close();
                return flag;
            }
            public int Delete(EMSeller dlt)
            {
                
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Fifth Semester\OOP2\Project Work\Project Code\market_management(project)\market_management\MarketDATABASE.mdf;Integrated Security=True;Connect Timeout=30");
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE Logintbl WHERE UserPhone ='" + dlt.SellerPhone + "'", Con);
                int flag = cmd.ExecuteNonQuery();
                Con.Close();
                return flag;
            }
        }

    }

