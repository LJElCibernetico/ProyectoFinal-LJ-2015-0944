<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rTiposDePersonas.aspx.cs" Inherits="ProyectoFinal_Web.pages.Registros.rTiposDePersonas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../../css/estilos.css"/>
    <title></title>

</head>
<body>
    <div class="container" runat="server">
		<div class="form__top" runat="server">
			<h2>Registro de <span>Tipos de Personas</span></h2>
		</div>		
		<form class="form__reg" runat="server">
			<asp:Button ID="ButtonBuscar" runat="server" Text="BUSCAR" Width="63px" OnClick="ButtonBuscar_Click1"/>
            
            <asp:TextBox  class="input" ID="TextBoxID" placeholder="ID" runat="server" Width="30px"></asp:TextBox>
            
            <asp:TextBox class="input" ID="TextBoxTipo" placeholder="Tipo de Persona" runat="server"></asp:TextBox>
            
            <div class="btn__form" runat="server">
                <asp:Button ID="ButtonNuevo" type="submit" runat="server" Text="NUEVO" OnClick="ButtonNuevo_Click"/>
                <asp:Button ID="ButtonGuardar" type="submit" runat="server" Text="GUARDAR" OnClick="ButtonGuardar_Click"/>
                <asp:Button ID="ButtonEliminar" type="submit" runat="server" Text="ELIMINAR" OnClick="ButtonEliminar_Click"/>
            </div>
		</form>
	</div>
</body>
</html>

