<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="pokedex_web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-6">
        <div class="mb-3">
            <asp:Label CssClass="form-label" Text="Usuario" class="form-label" runat="server" />
            <asp:TextBox CssClass="form-control" placeholder="nombre usuario" ID="txtUsuario" runat="server" />
        </div>
    </div>
    <div class="col-6">
        <div class="mb-3">
            <asp:Label CssClass="form-label" Text="Contraseña" class="form-label" runat="server" />
            <asp:TextBox CssClass="form-control" TextMode="Password" placeholder="*****" ID="txtPassword" runat="server" />
        </div>
    </div>
    <div class="col-6">
        <div class="mb-3">
            <asp:Button Text="Ingresar" CssClass="btn btn-primary" OnClick="btnIngresar_Click" id="btnIngresar" runat="server" />     
        </div>
    </div>
</asp:Content>
