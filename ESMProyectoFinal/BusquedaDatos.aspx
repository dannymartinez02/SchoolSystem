 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusquedaDatos.aspx.cs" Inherits="ESMProyectoFinal.BusquedaDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Búsqueda de datos</h1>
        <asp:Label ID="lblID" runat="server" Text="ID del alumno:" AssociatedControlID="txtID"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblNombre" runat="server" Text="Nombre del alumno:" AssociatedControlID="txtNombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblCarrera" runat="server" Text="Carrera del alumno:" AssociatedControlID="txtCarrera"></asp:Label>
        <asp:TextBox ID="txtCarrera" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        <br />
        <br />
        <asp:GridView ID="gridAlumnos" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="correo" HeaderText="Correo" />
                <asp:BoundField DataField="carrera" HeaderText="Carrera" />
                <asp:BoundField DataField="inscripcion_id" HeaderText="ID de inscripción" />
                <asp:BoundField DataField="profesor_id" HeaderText="ID de profesor" />
                <asp:BoundField DataField="fecha_inscripcion" HeaderText="Fecha de inscripción" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:BoundField DataField="nota" HeaderText="Nota" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
