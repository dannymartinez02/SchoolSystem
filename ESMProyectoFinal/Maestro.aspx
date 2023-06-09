<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Maestro.aspx.cs" Inherits="ESMProyectoFinal.Maestro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h1>Profesores</h1>
         <asp:GridView ID="ProfesoresGridView" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="correo" HeaderText="Correo" />
                <asp:BoundField DataField="departamento" HeaderText="Departamento" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Literal ID="AccesoDenegadoLiteral" runat="server" Visible="false">
            <p>Acceso denegado. No tienes permiso para ver esta página.</p>
        </asp:Literal>
    </div>
    </form>
</body>
</html>
