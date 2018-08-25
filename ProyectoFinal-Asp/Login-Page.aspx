<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login-Page.aspx.cs" Inherits="ProyectoFinal_Asp.Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://fonts.googleapis.com/css?family=Lato:400,900" rel="stylesheet"/>
    <link rel="stylesheet" href="../css/estilos.css"/>
        <title>Mi proyecto En Asp</title>
    </head>
    <body>
        <div class="login__container">
           <div class="login__top">
              <img  class="login__img" src="./images/pokemoneda.png" alt=""/>
              <h2 class="login__title">Form <span>Name</span></h2>
           </div>
        
            <form class="login__form">
                <input id="username" type="text" placeholder="&#128100; username" required = "required"/>
                <input id="password" type="password" placeholder="&#x1F512; password" required = "required" />
                <input class="btn__submit" type="submit" value="ENTRAR"/>
            </form>
        </div>
    </body>
</html>
