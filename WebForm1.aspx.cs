using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Printing;
using System.Runtime.Remoting.Messaging;

namespace Tarea1_Wander_Aaron
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mainconn = @"Data Source=db-aaron-wander.cf4srkshiegg.us-east-1.rds.amazonaws.com,1433;
                                Initial Catalog=db-aaron-wander;
                                User ID=admin;
                                Password=Wanderjose#2";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            SqlCommand sqlcomm = new SqlCommand("[dbo].[listar_articulos]", sqlconn);
            sqlcomm.CommandType = CommandType.StoredProcedure;
            sqlconn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            gridArticulos.DataSource = dt;
            gridArticulos.DataBind();
            sqlconn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}