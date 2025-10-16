using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolms
{
    public partial class Student_Login : System.Web.UI.Page
    {
        string s = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataSource ds;
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void getcon()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("select id from Stud where EnrlnO= '" + txtenr.Text + "'and Password = '" + txtpwd.Text + "'", con);
            cmd.ExecuteNonQuery();
            if (txtenr.Text != null && txtpwd.Text != null)
            {
                cmd = new SqlCommand("select count(*) from Stud where EnrlNo='" + txtenr.Text + "'and Password='" + txtpwd.Text + "'", con);
                i = Convert.ToInt32(cmd.ExecuteScalar());

                if (i > 0)
                {
                    Session["Stud"] = txtenr.Text;
                    Response.Redirect("Dashboard.aspx");
                }
            }
        }

        protected void Teacher_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher_login.aspx");
        }

        protected void Admin_Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}