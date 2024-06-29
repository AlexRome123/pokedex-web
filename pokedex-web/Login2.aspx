<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="pokedex_web.Login2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2>Login</h2>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label CssClass="form-label" Text="Email" runat="server" />
                <asp:TextBox CssClass="form-control" TextMode="Email" ID="txtEmail" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label CssClass="form-label" Text="Contraseña" runat="server" />
                <asp:TextBox CssClass="form-control" TextMode="Password" placeholder="*****" ID="txtContraseña" runat="server" />
            </div>
            <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnIngresar" OnClick="btnIngresar_Click" runat="server" />
            <a href="/">Cancelar</a>
        </div>
    </div>
</asp:Content>
