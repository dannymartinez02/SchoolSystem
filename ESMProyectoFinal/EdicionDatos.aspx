<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EdicionDatos.aspx.cs" Inherits="ESMProyectoFinal.EdicionDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Edición de Datos</h1>
        
        <!-- Formulario para la tabla "usuarios" -->
        <h2>Usuarios</h2>
        <asp:GridView ID="gridUsuarios" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="correo" HeaderText="Correo" />
                <asp:BoundField DataField="contraseña" HeaderText="Contraseña" />
                <asp:BoundField DataField="tipo" HeaderText="Tipo" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        
        <!-- Formulario para la tabla "alumnos" -->
        <h2>Alumnos</h2>
        <asp:GridView ID="gridAlumnos" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="correo" HeaderText="Correo" />
                <asp:BoundField DataField="carrera" HeaderText="Carrera" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        
        <!-- Formulario para la tabla "profesores" -->
        <h2>Profesores</h2>
        <asp:GridView ID="gridProfesores" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="correo" HeaderText="Correo" />
                <asp:BoundField DataField="departamento" HeaderText="Departamento" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        
        <!-- Formulario para la tabla "inscripciones" -->
        <h2>Inscripciones</h2>
        <asp:GridView ID="gridInscripciones" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="alumno_id" HeaderText="ID Alumno" />
                <asp:BoundField DataField="profesor_id" HeaderText="ID Profesor" />
                <asp:BoundField DataField="fecha_inscripcion" HeaderText="Fecha Inscripción" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        
        <!-- Formulario para la tabla "notas" -->
        <h2>Notas</h2>
        <asp:GridView ID="gridNotas" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="inscripcion_id" HeaderText="ID Inscripción" />
                <asp:BoundField DataField="nota" HeaderText="Nota" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
