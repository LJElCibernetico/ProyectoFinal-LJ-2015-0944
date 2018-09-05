<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cDepartamentos.aspx.cs" Inherits="ProyectoFinal_Web.pages.Consultas.cDepartamentos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../../css/estilos.css"/>
    <title></title>
</head>
<body>
    <div class="container" runat="server">
		<div class="form__top" runat="server">
			<h2>Registro de <span>Usuarios</span></h2>
		</div>		
		<form class="form__reg" runat="server">
			<asp:Button ID="ButtonBuscar" runat="server" Text="BUSCAR" Width="63px" OnClick="ButtonBuscar_Click"/>
            
            <asp:TextBox  class="input" ID="FiltroTextBox" placeholder="¿ID o Descripcion?" runat="server" Width="154px"></asp:TextBox>
            <asp:TextBox class="input" ID="CriterioTextBox" placeholder="Metodo de busqueda" runat="server" Height="16px" Width="282px"></asp:TextBox>
           
            <asp:GridView ID="GridView" runat="server" HorizontalAlign="Center"></asp:GridView>
		</form>
	</div>
</body>
</html>
