using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ESMProyectoFinal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string correo = Request.Form["txtCorreo"];
                string contrasena = Request.Form["txtContrasena"];
                string connectionString = ConfigurationManager.ConnectionStrings["EscuelaConnectionString"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("sp_login", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Las credenciales son válidas
                    int usuarioId = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string tipo = reader.GetString(2);
                    Session["usuario_id"] = usuarioId;
                    Session["nombre"] = nombre;
                    Session["tipo"] = tipo;
                    switch (tipo)
                    {
                        case "admin":
                            Response.Redirect("Admin.aspx");
                            break;
                        case "usuario":
                            Response.Redirect("Alumno.aspx");
                            break;
                        case "maestro":
                            Response.Redirect("Maestro.aspx");
                            break;
                    }
                }
                else
                {
                    // Las credenciales son inválidas
                    lblMensaje.Text = "Credenciales inválidas. Por favor, inténtelo de nuevo.";
                }
                conn.Close();
            }
        }
    }
}