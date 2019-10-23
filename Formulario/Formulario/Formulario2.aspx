<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario2.aspx.cs" Inherits="Formulario.Formulario2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>   
            <label>Documento de ID: </label>
            <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
            <br />
            <label>Nombre: </label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <br />
            <label>Apellidos: </label>
            <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
            <br />
            <label>Dirección: </label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <br />
            <label>Telefono: </label>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <br />
            <label>Correo Electronico: </label>
            <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
            <br />
            <label>Fecha Nacimiento: </label>
            <asp:TextBox ID="txtNacimiento" runat="server"></asp:TextBox>           
            <br />
            <br />
            <asp:RadioButton ID="rbNatural" runat="server" Text="Natural" />
            <asp:RadioButton ID="rbJuridico" runat="server" Text="Juridico" />
            <br />
            <br />
            <asp:DropDownList ID="ddlpersona" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
            <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" />
            
        </div>
    </form>
</body>
</html>
