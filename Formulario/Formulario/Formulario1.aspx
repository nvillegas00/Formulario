<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario1.aspx.cs" Inherits="Formulario.Formulario1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Documento ID:<asp:Label ID="lblDocumento" runat="server"></asp:Label></p><br />
            <p>Nombre: <asp:Label ID="lblNombre" runat="server"></asp:Label></p><br />
            <p>Apellidos: <asp:Label ID="lblApellidos" runat="server"></asp:Label></p><br />
            <p>Dirección: <asp:Label ID="lblDireccion" runat="server"></asp:Label></p><br />
            <p>Teléfono: <asp:Label ID="lblTelefono" runat="server"></asp:Label></p><br />
            <p>Correo: <asp:Label ID="lblCorreo" runat="server"></asp:Label></p><br />
            <p>Fecha Nacimiento: <asp:Label ID="lblNacimiento" runat="server"></asp:Label></p><br />
            <p>Persona<asp:Label ID="lblPersona" runat="server"></asp:Label></p>
            <p>Ciudad de Origen:<asp:Label ID="lblCiudades" runat="server"></asp:Label></p>
        </div>
    </form>
</body>
</html>
