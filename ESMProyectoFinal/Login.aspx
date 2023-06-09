<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ESMProyectoFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="Style/Login.css"/>
    <title>..:: Login || ESM ::..</title>

    <!-- FAVICON -->
	<link rel="apple-touch-icon" sizes="57x57" href="images/apple-icon-57x57.png">
	<link rel="apple-touch-icon" sizes="60x60" href="images/apple-icon-60x60.png">
	<link rel="apple-touch-icon" sizes="72x72" href="images/apple-icon-72x72.png">
	<link rel="apple-touch-icon" sizes="76x76" href="images/apple-icon-76x76.png">
	<link rel="apple-touch-icon" sizes="114x114" href="images/apple-icon-114x114.png">
	<link rel="apple-touch-icon" sizes="120x120" href="images/apple-icon-120x120.png">
	<link rel="apple-touch-icon" sizes="144x144" href="images/apple-icon-144x144.png">
	<link rel="apple-touch-icon" sizes="152x152" href="images/apple-icon-152x152.png">
	<link rel="apple-touch-icon" sizes="180x180" href="images/apple-icon-180x180.png">
	<link rel="icon" type="image/png" sizes="192x192"  href="images/android-icon-192x192.png">
	<link rel="icon" type="image/png" sizes="32x32" href="images/favicon-32x32.png">
	<link rel="icon" type="image/png" sizes="96x96" href="images/favicon-96x96.png">
	<link rel="icon" type="image/png" sizes="16x16" href="images/favicon-16x16.png">
	<link rel="manifest" href="images/manifest.json">
	<meta name="msapplication-TileColor" content="#ffffff">
	<meta name="msapplication-TileImage" content="images/ms-icon-144x144.png">
	<meta name="theme-color" content="#ffffff">

</head>
<body>
    <img class="fondocurvo" src="Image/fondocurvo.png">
    <div class="contenedor">
        <div class="imagen_fondo_principal">
            <img class="iconprincipal" src="Image/platoicon2.svg">
        </div>

        <div class="contenedor_login">
            <form id="form1" name="logingeneral" runat="server">
                <img src="Image/iconusuarios.svg">
                <h2 class="tituloprincipal">¡BIENVENIDO!</h2>
                <div class="contenedor_campos nombre_usuario">
                    <div class="iconos_personalizados">
           		   		<i class="fas fa-user"></i>
           		   </div>
                    <!-- POSTERIORMENTE SE AGREGARA LA VALIDACION DINAMICA -->
                    <div class="subcontenedor_campos">
                        <h5>Nombre de Usuario</h5>
                        <input type="text" class="input" id="txtCorreo" name="txtCorreo" minlength="4" maxlength="" required>
                    </div>
                </div>
                <div class="contenedor_campos clave_usuario">
                    <div class="iconos_personalizados"> 
           		    	<i class="fas fa-lock"></i>
           		   </div>
                    <div class="subcontenedor_campos">
           		    	<h5>Contrase&ntilde;a</h5>
           		    	<input type="password" class="input" id="txtContrasena" name="txtContrasena" minlength="4" maxlength="" required>
            	   </div>
                </div>
                <p><button class="boton-ingresar" type="submit">Iniciar sesión</button></p>
                <p><asp:Label ID="lblMensaje" runat="server" ForeColor="Red" /></p>

                <!--<div>
                    <p><label for="txtCorreo">Correo electrónico:</label> <input type="email" id="txtCorreo" name="txtCorreo" required /></p>
                    <p><label for="txtContrasena">Contraseña:</label> <input type="password" id="txtContrasena" name="txtContrasena" required /></p>
                    
                    
                </div>-->
            </form>
        </div>
        
    </div>
    <script src="https://kit.fontawesome.com/a81368914c.js"></script>
    <script type="text/javascript" src="Js/efectofucus.js"></script>
</body>
</html>
