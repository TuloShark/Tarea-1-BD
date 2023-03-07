using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prueba_de_ASP.NET
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            String Nombre = tbNombre.Text;
            String Precio = tbPrecio.Text;
            String MainConex = @"Data Source=db-aaron-wander.cf4srkshiegg.us-east-1.rds.amazonaws.com,1433;
            Initial Catalog=db-aaron-wander;
            User ID=admin;
            Password=Wanderjose#2";
            if (!Nombre.Equals(""))
            {
                if (Regex.IsMatch(Precio, @"\d") && int.Parse(Precio)>=0)
                {
                    try { 
                        SqlConnection conection = new SqlConnection(MainConex);
                        conection.Open();
                        SqlCommand com = new SqlCommand("insertar_articulo", conection);
                        com.CommandType = System.Data.CommandType.StoredProcedure;
                        com.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                        com.Parameters.AddWithValue("@Precio", int.Parse(tbPrecio.Text));
                        com.ExecuteNonQuery();
                        conection.Close();
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Se registro')", true);
                        Response.Redirect("Index.aspx");
                    }
                    catch
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Alerta", "alert('Problema para conectar la base')", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "err_número", @"alert('Que introducir un precio como número positivo')", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "err_nombre", "alert('Tienes que introducir un nombre de articulo')", true);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}