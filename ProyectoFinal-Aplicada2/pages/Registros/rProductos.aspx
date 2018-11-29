<%@ Page Title="" Language="C#" MasterPageFile="~/pages/MasterPage/Menu.Master" AutoEventWireup="true" CodeBehind="rProductos.aspx.cs" Inherits="ProyectoFinal_Aplicada2.pages.Registros.rProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="page-header text-center">
            <h2 style="color: #358CCE">Registro de Productos</h2>
        </div>

        <hr style="color: #358CCE"/>

        <label for="TextBoxProductoID">ID</label>
        <div class="form-row">
            <div class="form-group col-lg-1">
                <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxProductoID" runat="server" placeholder="ID"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="id" SetFocusOnError="true" ForeColor="Red" ID="RequiredFieldValidator7" ControlToValidate="TextBoxProductoID" runat="server" Display="Dynamic" ErrorMessage="Introduzca un id"></asp:RequiredFieldValidator>
            </div>
            <div class="btn-group-col-md-1">
                <asp:Button class="btn btn-primary" ValidationGroup="id" ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="DropDownListDepartamentos">Departamento</label>
                <asp:DropDownList ID="DropDownListDepartamentos" CssClass="form-control" runat="server" placeholder="Seleccione un Departamento"></asp:DropDownList>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator6" ControlToValidate="DropDownListDepartamentos" runat="server" Display="Dynamic" ErrorMessage="Seleccione el Departamento del producto"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxNombreProducto">Nombre</label>
                <asp:TextBox class="form-control" ID="TextBoxNombreProducto" runat="server" placeholder="Nombre del Producto" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator1" ControlToValidate="TextBoxNombreProducto" runat="server" Display="Dynamic" ErrorMessage="Introduzca un Nombre al producto"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxFechaVencimiento">Fecha de Vencimiento</label>
                <asp:TextBox TextMode="Date" class="form-control" ID="TextBoxFechaVencimiento" runat="server" placeholder="Fecha de Vencimiento del Producto"></asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator2" ControlToValidate="TextBoxFechaVencimiento" runat="server" Display="Dynamic" ErrorMessage="Introduzca una Fecha de Vencimiento al producto"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxExistencia">Existencia</label>
                <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxExistencia" runat="server" placeholder="Existencia del Producto" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator3" ControlToValidate="TextBoxExistencia" runat="server" Display="Dynamic" ErrorMessage="Introduzca una Existencia al producto"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxCosto">Costo</label>
                <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxCosto" runat="server" placeholder="Costo del Producto" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator4" ControlToValidate="TextBoxExistencia" runat="server" Display="Dynamic" ErrorMessage="Introduzca un Costo al producto"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="row">
            <div class="form-group col-md-7 col-md-offset-3">
                <label for="TextBoxPrecio">Precio</label>
                <asp:TextBox TextMode="Number" class="form-control" ID="TextBoxPrecio" runat="server" placeholder="Precio del Producto" autocomplete="off"> </asp:TextBox>
                <asp:RequiredFieldValidator ValidationGroup="save" ForeColor="Red" ID="RequiredFieldValidator5" ControlToValidate="TextBoxPrecio" runat="server" Display="Dynamic" ErrorMessage="Introduzca un Precio al producto"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="btn-block text-center">
            <asp:Button class="btn btn-primary" ID="ButtonNuevo" runat="server" Text="Nuevo" OnClick="ButtonNuevo_Click" />
            <asp:Button class="btn btn-success" ValidationGroup="save" ID="ButtonGuardar" runat="server" Text="Guardar" OnClick="ButtonGuardar_Click" />
            <asp:Button class="btn btn-danger" ValidationGroup="id" ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
        </div>
    </div>
</asp:Content>
