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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand commanLogin=new SqlCommand("select * from ogrencitablo where ISIM=@puser and SIFRE=@psifre",SqlConnectionClass.connection);
            SqlConnectionClass.ChedkedConnection();
            commanLogin.Parameters.AddWithValue("@puser", tboxisim.Text);
            commanLogin.Parameters.AddWithValue("@psifre", tboxsifre.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commanLogin);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (tboxisim.Text == "Emre Koc" && tboxsifre.Text=="admin")
                {
                    Response.Redirect("Messages.aspx");
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }
            }
            else
            {
                Response.Write("Wrong e-mail or password! Try again!.");
            }
        }
    }
}