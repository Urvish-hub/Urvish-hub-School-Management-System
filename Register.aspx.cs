using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace schoolms
{
    public partial class Register : System.Web.UI.Page
    {
        string s = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataSource ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            getcon();   
        }
        void getcon()
        {
            con = new SqlConnection(s);
            con.Open(); 
        }
        void clen()
        {
            txtnm.Text = "";
            txteml.Text = "";
            txtpwd.Text = "";
            txtcompwd.Text = "";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("insert into Users(Name,Email,Password,ConfirmPassword) values('" + txtnm.Text+"','"+txteml.Text+"','"+txtpwd.Text+"','"+txtcompwd.Text+"')", con);
            cmd.ExecuteNonQuery();
            clen();
            Response.Redirect("Dashboard.aspx");
        }
    }
}