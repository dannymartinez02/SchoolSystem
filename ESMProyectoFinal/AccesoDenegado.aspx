<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccesoDenegado.aspx.cs" Inherits="ESMProyectoFinal.AccesoDenegado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Acceso Denegado</h1>
        <p>No tienes permiso para acceder a esta página.</p>
        <asp:Button ID="btnVolver" runat="server" Text="Volver a la página de bienvenida" OnClick="btnVolver_Click" />
    </div>
    </form>
</body>
</html>
