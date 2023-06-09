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
    public partial class BusquedaDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["EscuelaConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT a.id, a.nombre, a.correo, a.carrera, i.id AS inscripcion_id, i.profesor_id, i.fecha_inscripcion, n.nota
                             FROM alumnos a
                             LEFT JOIN inscripciones i ON a.id = i.alumno_id
                             LEFT JOIN notas n ON i.id = n.inscripcion_id
                             WHERE 1 = 1";

                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    query += " AND a.id = @id";
                }

                if (!string.IsNullOrEmpty(txtNombre.Text))
                {
                    query += " AND a.nombre LIKE '%' + @nombre + '%'";
                }

                if (!string.IsNullOrEmpty(txtCarrera.Text))
                {
                    query += " AND a.carrera LIKE '%' + @carrera + '%'";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (!string.IsNullOrEmpty(txtID.Text))
                    {
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
                    }

                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    }

                    if (!string.IsNullOrEmpty(txtCarrera.Text))
                    {
                        cmd.Parameters.AddWithValue("@carrera", txtCarrera.Text);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    gridAlumnos.DataSource = ds;
                    gridAlumnos.DataBind();
                }
            }
        }
    }
}