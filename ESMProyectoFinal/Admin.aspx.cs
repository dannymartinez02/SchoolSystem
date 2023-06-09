using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ESMProyectoFinal
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario_id"] == null)
                {
                    Response.Redirect("login.aspx");
                }
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");
        }

        protected void btnAlumnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("alumnos.aspx");
        }

        protected void btnProfesores_Click(object sender, EventArgs e)
        {
            Response.Redirect("profesores.aspx");
        }

        protected void btnBusquedaDatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("busquedaDatos.aspx");
        }

        protected void btnEdicionDatos_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para redirigir a la página de edición de datos
            Response.Redirect("edicionDatos.aspx");
        }
    }
}