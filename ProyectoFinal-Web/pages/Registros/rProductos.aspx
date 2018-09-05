<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rProductos.aspx.cs" Inherits="ProyectoFinal_Web.pages.Registros.rProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../../css/estilos.css"/>
    <title></title>
</head>
<body>
    <div class="container" runat="server">
		<div class="form__top" runat="server">
			<h2>Registro de <span>Productos</span></h2>
		</div>		
		<form class="form__reg" runat="server">
			<asp:Button ID="ButtonBuscar" runat="server" Text="BUSCAR" Width="63px"/>
            
            <asp:TextBox  class="input" ID="TextBoxID" placeholder="ID" runat="server" Width="30px"></asp:TextBox>
            
            <!--<asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                ControlToValidate="TextBoxID" runat="server"
                ErrorMessage="Only Numbers allowed"
                ValidationExpression="\d+">
            </asp:RegularExpressionValidator>-->
            <asp:TextBox class="input" ID="TextBoxUsername" placeholder="Username" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxPassword" placeholder="Password" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxConfirmacion" placeholder="Confirmacion" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxFecha" placeholder="Fecha" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxNombre" placeholder="Nombre" runat="server"></asp:TextBox>
            <asp:TextBox class="input" ID="TextBoxComentario" placeholder="Comentario" runat="server"></asp:TextBox>
            <div class="btn__form" runat="server">
                
            </div>
		</form>
	</div>
</body>
</html>
