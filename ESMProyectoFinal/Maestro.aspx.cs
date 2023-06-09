using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESMProyectoFinal
{
    public partial class Maestro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Session["usuario_id"] == null)
                {
                    Response.Redirect("login.aspx");
                }
                CargarDatosProfesores();
            }
        }

        private void CargarDatosProfesores()
        {
            // Establecer la conexión con la base de datos
            string connectionString = ConfigurationManager.ConnectionStrings["EscuelaConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear la consulta SQL
                string query = "SELECT id, nombre, correo, departamento FROM profesores";
                SqlCommand command = new SqlCommand(query, connection);

                // Abrir la conexión y ejecutar la consulta
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Vincular los datos devueltos por la consulta con el GridView
                ProfesoresGridView.DataSource = reader;
                ProfesoresGridView.DataBind();

                // Cerrar el lector de datos
                reader.Close();
            }
        }
    }
}