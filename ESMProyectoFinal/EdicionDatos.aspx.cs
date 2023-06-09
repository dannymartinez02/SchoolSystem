using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESMProyectoFinal
{
    public partial class EdicionDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindUsuariosGrid();
                BindAlumnosGrid();
                BindProfesoresGrid();
                BindInscripcionesGrid();
                BindNotasGrid();
            }
        }

        // Método para obtener la cadena de conexión a la base de datos
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["EscuelaConnectionString"].ConnectionString;
        }

        // Método para obtener los datos de la tabla "usuarios" y enlazarlos al GridView
        private void BindUsuariosGrid()
        {
            string query = "SELECT * FROM usuarios";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        sda.Fill(dt);
                        gridUsuarios.DataSource = dt;
                        gridUsuarios.DataBind();
                    }
                }
            }
        }

        // Método para obtener los datos de la tabla "alumnos" y enlazarlos al GridView
        private void BindAlumnosGrid()
        {
            string query = "SELECT * FROM alumnos";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        sda.Fill(dt);
                        gridAlumnos.DataSource = dt;
                        gridAlumnos.DataBind();
                    }
                }
            }
        }

        // Método para obtener los datos de la tabla "profesores" y enlazarlos al GridView
        private void BindProfesoresGrid()
        {
            string query = "SELECT * FROM profesores";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        sda.Fill(dt);
                        gridProfesores.DataSource = dt;
                        gridProfesores.DataBind();
                    }
                }
            }
        }

        // Método para obtener los datos de la tabla "inscripciones" y enlazarlos al GridView
        private void BindInscripcionesGrid()
        {
            string query = "SELECT * FROM inscripciones";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        sda.Fill(dt);
                        gridInscripciones.DataSource = dt;
                        gridInscripciones.DataBind();
                    }
                }
            }
        }

        // Método para obtener los datos de la tabla "notas" y enlazarlos al GridView
        private void BindNotasGrid()
        {
            string query = "SELECT * FROM notas";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        sda.Fill(dt);
                        gridNotas.DataSource = dt;
                        gridNotas.DataBind();
                    }
                }
            }
        }

        // Evento disparado cuando se edita una fila del GridView 'gridUsuarios'
        protected void gridUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridUsuarios.EditIndex = e.NewEditIndex;
            BindUsuariosGrid();
        }

        // Evento disparado cuando se cancela la edición de una fila del GridView 'gridUsuarios'
        protected void gridUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridUsuarios.EditIndex = -1;
            BindUsuariosGrid();
        }

        // Evento disparado cuando se actualiza una fila del GridView 'gridUsuarios'
        protected void gridUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gridUsuarios.Rows[e.RowIndex];
            int id = Convert.ToInt32(gridUsuarios.DataKeys[e.RowIndex].Value);
            string nombre = ((TextBox)row.FindControl("txtNombre")).Text;
            string correo = ((TextBox)row.FindControl("txtCorreo")).Text;
            string contraseña = ((TextBox)row.FindControl("txtContraseña")).Text;
            string tipo = ((TextBox)row.FindControl("txtTipo")).Text;

            string query = "UPDATE usuarios SET nombre = @Nombre, correo = @Correo, contraseña = @Contraseña, tipo = @Tipo WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            gridUsuarios.EditIndex = -1;
            BindUsuariosGrid();
        }

        // Evento disparado cuando se borra una fila del GridView 'gridUsuarios'
        protected void gridUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gridUsuarios.DataKeys[e.RowIndex].Value);

            string query = "DELETE FROM usuarios WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            BindUsuariosGrid();
        }

        // Evento disparado cuando se edita una fila del GridView 'gridAlumnos'
        protected void gridAlumnos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridAlumnos.EditIndex = e.NewEditIndex;
            BindAlumnosGrid();
        }

        // Evento disparado cuando se cancela la edición de una fila del GridView 'gridAlumnos'
        protected void gridAlumnos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridAlumnos.EditIndex = -1;
            BindAlumnosGrid();
        }

        // Evento disparado cuando se actualiza una fila del GridView 'gridAlumnos'
        protected void gridAlumnos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gridAlumnos.Rows[e.RowIndex];
            int id = Convert.ToInt32(gridAlumnos.DataKeys[e.RowIndex].Value);
            string nombre = ((TextBox)row.FindControl("txtNombre")).Text;
            string correo = ((TextBox)row.FindControl("txtCorreo")).Text;
            string carrera = ((TextBox)row.FindControl("txtCarrera")).Text;

            string query = "UPDATE alumnos SET nombre = @Nombre, correo = @Correo, carrera = @Carrera WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Carrera", carrera);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            gridAlumnos.EditIndex = -1;
            BindAlumnosGrid();
        }

        // Evento disparado cuando se borra una fila del GridView 'gridAlumnos'
        protected void gridAlumnos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gridAlumnos.DataKeys[e.RowIndex].Value);

            string query = "DELETE FROM alumnos WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            BindAlumnosGrid();
        }

        // Evento disparado cuando se edita una fila del GridView 'gridProfesores'
        protected void gridProfesores_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridProfesores.EditIndex = e.NewEditIndex;
            BindProfesoresGrid();
        }

        // Evento disparado cuando se cancela la edición de una fila del GridView 'gridProfesores'
        protected void gridProfesores_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridProfesores.EditIndex = -1;
            BindProfesoresGrid();
        }

        // Evento disparado cuando se actualiza una fila del GridView 'gridProfesores'
        protected void gridProfesores_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gridProfesores.Rows[e.RowIndex];
            int id = Convert.ToInt32(gridProfesores.DataKeys[e.RowIndex].Value);
            string nombre = ((TextBox)row.FindControl("txtNombre")).Text;
            string correo = ((TextBox)row.FindControl("txtCorreo")).Text;
            string departamento = ((TextBox)row.FindControl("txtDepartamento")).Text;

            string query = "UPDATE profesores SET nombre = @Nombre, correo = @Correo, departamento = @Departamento WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Departamento", departamento);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            gridProfesores.EditIndex = -1;
            BindProfesoresGrid();
        }

        // Evento disparado cuando se borra una fila del GridView 'gridProfesores'
        protected void gridProfesores_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gridProfesores.DataKeys[e.RowIndex].Value);

            string query = "DELETE FROM profesores WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            BindProfesoresGrid();
        }

        // Evento disparado cuando se edita una fila del GridView 'gridInscripciones'
        protected void gridInscripciones_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridInscripciones.EditIndex = e.NewEditIndex;
            BindInscripcionesGrid();
        }

        // Evento disparado cuando se cancela la edición de una fila del GridView 'gridInscripciones'
        protected void gridInscripciones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridInscripciones.EditIndex = -1;
            BindInscripcionesGrid();
        }

        // Evento disparado cuando se actualiza una fila del GridView 'gridInscripciones'
        protected void gridInscripciones_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gridInscripciones.Rows[e.RowIndex];
            int id = Convert.ToInt32(gridInscripciones.DataKeys[e.RowIndex].Value);
            int idAlumno = Convert.ToInt32(((TextBox)row.FindControl("txtIDAlumno")).Text);
            int idCurso = Convert.ToInt32(((TextBox)row.FindControl("txtIDCurso")).Text);

            string query = "UPDATE inscripciones SET id_alumno = @IDAlumno, id_curso = @IDCurso WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IDAlumno", idAlumno);
                    cmd.Parameters.AddWithValue("@IDCurso", idCurso);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            gridInscripciones.EditIndex = -1;
            BindInscripcionesGrid();
        }

        // Evento disparado cuando se borra una fila del GridView 'gridInscripciones'
        protected void gridInscripciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gridInscripciones.DataKeys[e.RowIndex].Value);

            string query = "DELETE FROM inscripciones WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            BindInscripcionesGrid();
        }

        // Evento disparado cuando se edita una fila del GridView 'gridNotas'
        protected void gridNotas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridNotas.EditIndex = e.NewEditIndex;
            BindNotasGrid();
        }

        // Evento disparado cuando se cancela la edición de una fila del GridView 'gridNotas'
        protected void gridNotas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridNotas.EditIndex = -1;
            BindNotasGrid();
        }

        // Evento disparado cuando se actualiza una fila del GridView 'gridNotas'
        protected void gridNotas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gridNotas.Rows[e.RowIndex];
            int id = Convert.ToInt32(gridNotas.DataKeys[e.RowIndex].Value);
            int idAlumno = Convert.ToInt32(((TextBox)row.FindControl("txtIDAlumno")).Text);
            int idCurso = Convert.ToInt32(((TextBox)row.FindControl("txtIDCurso")).Text);
            int nota = Convert.ToInt32(((TextBox)row.FindControl("txtNota")).Text);

            string query = "UPDATE notas SET id_alumno = @IDAlumno, id_curso = @IDCurso, nota = @Nota WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@IDAlumno", idAlumno);
                    cmd.Parameters.AddWithValue("@IDCurso", idCurso);
                    cmd.Parameters.AddWithValue("@Nota", nota);
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            gridNotas.EditIndex = -1;
            BindNotasGrid();
        }

        // Evento disparado cuando se borra una fila del GridView 'gridNotas'
        protected void gridNotas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(gridNotas.DataKeys[e.RowIndex].Value);

            string query = "DELETE FROM notas WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            BindNotasGrid();
        }
    }
}