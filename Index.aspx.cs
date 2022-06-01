using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJE1OKULKAYIT
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsub_Click(object sender, EventArgs e)
        {
            SqlConnectionClass.ChedkedConnection();
            SqlCommand commandMessage = new SqlCommand("insert into tablomesaj(FirstName,LastName,MobileNumber,Mesaj)values(@pfname,@plname,@pmpfone,@pmsg)", SqlConnectionClass.connection);
            commandMessage.Parameters.AddWithValue("@pfname", tboxinisim.Text);
            commandMessage.Parameters.AddWithValue("@plname", tboxinlastname.Text);
            commandMessage.Parameters.AddWithValue("@pmpfone", tboxphone.Text);
            commandMessage.Parameters.AddWithValue("@pmsg", tboxmesaj.Text);
            commandMessage.ExecuteNonQuery();
            Response.Write("You have been successfully send your messaj!");
        }
    }
}