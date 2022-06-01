using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJE1OKULKAYIT
{
    public partial class KayitOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnectionClass.ChedkedConnection();
            SqlCommand commandregister = new SqlCommand("insert into ogrencitablo(ISIM,MAIL,SEHIR,SIFRE)values(@puser,@pmail,@psehir,@psifre)",SqlConnectionClass.connection);
            commandregister.Parameters.AddWithValue("@puser", tboxname.Text);
            commandregister.Parameters.AddWithValue("@pmail", tboxmail.Text);
            commandregister.Parameters.AddWithValue("@psehir", tboxcity.Text);
            commandregister.Parameters.AddWithValue("@psifre", tboxpassword.Text);
            commandregister.ExecuteNonQuery();
            
            Response.Redirect("login.aspx");
        }
    }
}