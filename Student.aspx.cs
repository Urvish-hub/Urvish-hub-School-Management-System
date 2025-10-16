using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolms
{
    public partial class Student : System.Web.UI.Page
    {
        string s = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlDataAdapter da;
        SqlDataSource ds;
        SqlCommand cmd;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void getcon()
        {

            con = new SqlConnection(s);
            con.Open();

        }
        void clen()
        {
            txtEnrlNo.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            txtCity.Text = "";
            txtpwd.Text = "";
        }
        private void BindGrid()
        {
            getcon();
            SqlCommand cmd = new SqlCommand("SELECT EnrlNo, Name, Age, City, Password FROM Stud", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            clen();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("INSERT INTO Stud(EnrlNo, Name, Age, City, Password) VALUES('" + txtEnrlNo.Text + "','" + txtName.Text + "'," + txtAge.Text + ",'" + txtCity.Text + "','" + txtpwd.Text + "')", con);

            cmd.ExecuteNonQuery();
            clen();
            BindGrid();
        }

        protected void BunUpdate_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("UPDATE Stud SET Name = '" + txtName.Text + "', Age = " + txtAge.Text + ", City = '" + txtCity.Text + ",Password='" + txtpwd.Text + "' WHERE EnrlNo = '" + txtEnrlNo.Text + "'", con);
            cmd.ExecuteNonQuery();
            clen();
            BindGrid();
        }

        protected void BunDelet_Click(object sender, EventArgs e)
        {
            getcon();
            cmd = new SqlCommand("DELETE FROM Stud WHERE EnrlNo = '" + txtEnrlNo.Text + "'", con);
            cmd.ExecuteNonQuery();
            clen();
            BindGrid();
        }

        protected void BunReset_Click(object sender, EventArgs e)
        {
            clen();
            BindGrid();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }
    }
}