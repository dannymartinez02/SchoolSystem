<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ESMProyectoFinal.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>..:: Administrador || ESM ::..</title>
    <link rel="stylesheet" type="text/css" href="Style/Admin.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <nav>
            <div class="logo">
                <h1>Bienvenido</h1>
                <p>¡Has iniciado sesión con éxito!</p>
            </div>
            <ul class="nav-links">

                <li><asp:Button CssClass="boton-futurista" ID="Button2" runat="server" Text="Alumnos" OnClick="btnAlumnos_Click" /></li>
                <li><asp:Button CssClass="boton-futurista" ID="Button3" runat="server" Text="Profesores" OnClick="btnProfesores_Click" /></li>
                <li><asp:Button CssClass="boton-futurista" ID="btnBusquedaDatos" runat="server" Text="Búsqueda de datos" OnClick="btnBusquedaDatos_Click" /></li>
                <li><asp:Button CssClass="boton-futurista" ID="btnEdicionDatos" runat="server" Text="Edición de datos" OnClick="btnEdicionDatos_Click" /></li>
            </ul>
            <div class="logout">
                <asp:Button CssClass="boton-futuristaCerrar"  ID="Button5" runat="server" Text="Cerrar sesión" OnClick="btnCerrarSesion_Click" />
            </div>
        </nav>
    </div>
    </form>
</body>
</html>
