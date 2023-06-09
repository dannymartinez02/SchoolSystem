using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESMProyectoFinal
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario_id"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                BindGrid();
            }
        }

        private void BindGrid()
        {
            // Obtener la cadena de conexión desde Web.config
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["EscuelaConnectionString"].ConnectionString;

            // Crear la consulta SQL
            string query = "SELECT id, nombre, correo, carrera FROM alumnos";

            // Crear la conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando
                SqlCommand command = new SqlCommand(query, connection);

                // Ejecutar el comando y obtener los datos en un SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // Asignar los datos al GridView
                AlumnosGridView.DataSource = reader;
                AlumnosGridView.DataBind();

                // Cerrar el SqlDataReader y la conexión
                reader.Close();
                connection.Close();
            }
        }
    }
}