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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            String Nombre = tbNombre.Text;
            String Precio = tbPrecio.Text;
            if (!Nombre.Equals("")){
                if (Regex.IsMatch(Precio, @"\d")) {
                    SqlConnection conection = new SqlConnection("Data Source=db-aaron-wander.cf4srkshiegg.us-east-1.rds.amazonaws.com,1433;Initial Catalog=db-aaron-wander;User ID=admin;Password=Wanderjose#2");
                    conection.Open();
                    SqlCommand com = new SqlCommand("insertar_articulo", conection);
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                    com.Parameters.AddWithValue("@Precio", int.Parse(tbPrecio.Text));
                    com.ExecuteNonQuery();
                    conection.Close();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Se registro')", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", @"alert('Que introducir un precio como número')", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Tienes que introducir un nombre de articulo')", true);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}