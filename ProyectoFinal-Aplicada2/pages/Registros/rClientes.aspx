﻿<%@ Page Title="" Language="C#" MasterPageFile="~/pages/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="rClientes.aspx.cs" Inherits="ProyectoFinal_Aplicada2.pages.Registros.rClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="page-header text-center">
            <h2 style="color: #358CCE">Registro de Clientes</h2>
        </div>

        <hr style="color: #358CCE" />

        <label for="TextBoxClienteID">ID</label>
        <div class="form-row">
            <div class="form-group col-lg-1">
                <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxClienteID" runat="server" placeholder="ID"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="id" SetFocusOnError="true" ForeColor="Red" ID="RequiredFieldValidator7" ControlToValidate="TextBoxClienteID" runat="server" Display="Dynamic" ErrorMessage="Introduzca un id"></asp:RequiredFieldValidator>
            </div>
            <div class="btn-group-col-md-1">
                <asp:Button class="btn btn-primary" ValidationGroup="id" ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="DropDownListTipoCliente">Tipo de Cliente</label>
                <asp:DropDownList ID="DropDownListTipoCliente" CssClass="form-control" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator6" ControlToValidate="DropDownListTipoCliente" runat="server" Display="Dynamic" ErrorMessage="Seleccione el Tipo de Cliente"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxNombre">Nombre</label>
                <asp:TextBox class="form-control" ID="TextBoxNombre" runat="server" placeholder="Nombre del Cliente" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator1" ControlToValidate="TextBoxNombre" runat="server" Display="Dynamic" ErrorMessage="Introduzca el Nombre del Cliente"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxApellido">Apellidos</label>
                <asp:TextBox class="form-control" ID="TextBoxApellido" runat="server" placeholder="Apellido del Cliente" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator2" ControlToValidate="TextBoxApellido" runat="server" Display="Dynamic" ErrorMessage="Introduzca el Apellido del Cliente"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxTelefono">Telefono</label>
                <asp:TextBox class="form-control" ID="TextBoxTelefono" runat="server" placeholder="Telefono del Cliente" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator3" ControlToValidate="TextBoxTelefono" runat="server" Display="Dynamic" ErrorMessage="Introduzca el Telefono del Cliente"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxDireccion">Direccion</label>
                <asp:TextBox class="form-control" ID="TextBoxDireccion" runat="server" placeholder="Direccion del Cliente" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator4" ControlToValidate="TextBoxDireccion" runat="server" Display="Dynamic" ErrorMessage="Introduzca la Direccion del Cliente"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxEmail">Email</label>
                <asp:TextBox TextMode="Email" class="form-control" ID="TextBoxEmail" runat="server" placeholder="Email del Cliente" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator5" ControlToValidate="TextBoxEmail" runat="server" Display="Dynamic" ErrorMessage="Introduzca el Email del Cliente"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="btn-block text-center">
            <asp:Button class="btn btn-primary" ID="ButtonNuevo" runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" />
            <asp:Button class="btn btn-success" ValidationGroup="save" ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click" />
            <asp:Button class="btn btn-danger" ValidationGroup="id" ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
        </div>
    </div>
</asp:Content>
