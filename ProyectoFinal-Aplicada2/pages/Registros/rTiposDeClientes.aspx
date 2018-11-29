﻿<%@ Page Title="" Language="C#" MasterPageFile="~/pages/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="rTiposDeClientes.aspx.cs" Inherits="ProyectoFinal_Aplicada2.pages.Registros.rTiposDeClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="page-header text-center">
            <h2 style="color: #358CCE">Registro de Tipos de Clientes</h2>
        </div>

        <hr style="color: #358CCE" />

        <label for="TextBoxTipoClienteID">ID</label>
        <div class="form-row">
            <div class="form-group col-lg-1">
                <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxTipoClienteID" runat="server" placeholder="ID"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="id" SetFocusOnError="true" ForeColor="Red" ID="RequiredFieldValidator1" ControlToValidate="TextBoxTipoClienteID" runat="server" Display="Dynamic" ErrorMessage="Introduzca un id"></asp:RequiredFieldValidator>
            </div>
            <div class="btn-group-col-md-1">
                <asp:Button class="btn btn-primary" ValidationGroup="id" ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxTipoDeCliente">Tipo de Cliente</label>
                <asp:TextBox class="form-control" ID="TextBoxTipoCliente" runat="server" placeholder="Tipo de Cliente" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" SetFocusOnError="true" ForeColor="Red" ID="RequiredFieldValidator2" ControlToValidate="TextBoxTipoCliente" runat="server" Display="Dynamic" ErrorMessage="Introduzca un Tipo de Cliente"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="btn-block text-center">
            <asp:Button class="btn btn-primary" ID="ButtonNuevo" runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" />
            <asp:Button class="btn btn-success" ValidationGroup="save" ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click" />
            <asp:Button class="btn btn-danger" ValidationGroup="id" ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
        </div>
    </div>
</asp:Content>
