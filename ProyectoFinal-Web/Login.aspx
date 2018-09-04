<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProyectoFinal_Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="https://fonts.googleapis.com/css?family=Lato:400,900" rel="stylesheet"/>
    <link rel="stylesheet" href="./css/estilos.css"/>
</head>
<body>
    <div class="login">
        <div class="login__container">
            <div class="login__top">
                <img  class="login__img" src="./images/pokemoneda.png" alt=""/>
                <h2 class="login__title">Iniciar <span>Sesion</span></h2>
            </div>
            <form class="login__form" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Usuario" EnableTheming="True" ForeColor="#31B1E5" Font-Bold="True" Font-Italic="False"></asp:Label>
                <asp:TextBox ID="userTextbox" runat="server"></asp:TextBox>

                <asp:Label ID="Label2" runat="server" Text="Contraseña" ForeColor="#31B1E5" Font-Bold="True"></asp:Label>
                <asp:TextBox id="passwordTextbox" TextMode="password" runat="server"></asp:TextBox>
            
                <asp:Button ID="buttonEntrar" href="../Pages/menu.aspx" runat="server" Text="ENTRAR" OnClick="buttonEntrar_Click"/>
            </form>
        </div>
    </div>
</body>
</html>
