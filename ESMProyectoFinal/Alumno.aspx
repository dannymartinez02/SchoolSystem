<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="ESMProyectoFinal.Alumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Alumnos</h1>
        <asp:GridView ID="AlumnosGridView" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="correo" HeaderText="Correo" />
                <asp:BoundField DataField="carrera" HeaderText="Carrera" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
