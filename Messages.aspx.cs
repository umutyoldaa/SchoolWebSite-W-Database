using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJE1OKULKAYIT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnectionClass.ChedkedConnection(); // baglantiyi eger kapaliysa acmak icin 

            SqlCommand commandList = new SqlCommand("Select FirstName,Lastname,MobileNumber,Mesaj,okundu from tablomesaj", SqlConnectionClass.connection); // burada carconfirmation ile eger true ise yayinlaniyor yani admin onayina gidiyor
            SqlCommand commandokundu = new SqlCommand("Select okundu from tablomesaj", SqlConnectionClass.connection);
           int a = Convert.ToInt32(commandokundu.ExecuteScalar());
            
           
            if (a==1) 
            {
                SqlDataReader dr1 = commandList.ExecuteReader();
                DataList1.DataSource = dr1;
                DataList1.DataBind();
                dr1.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnectionClass.ChedkedConnection();
            SqlCommand commandList1 = new SqlCommand("update tablomesaj set okundu=1  where FirstName=FirstName ", SqlConnectionClass.connection);
            commandList1.ExecuteNonQuery();

        }
    }
}