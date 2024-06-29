<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="pokedex_web.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <h2>Creá tu perfil Trainee</h2>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label CssClass="form-label" Text="Email" runat="server" />
                <asp:TextBox CssClass="form-control" TextMode="Email" ID="txtEmail" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label CssClass="form-label" Text="Contraseña" runat="server" />
                <asp:TextBox CssClass="form-control" TextMode="Password" placeholder="*****" ID="txtContraseña" runat="server" />
            </div>
            <asp:Button Text="Registrarse" CssClass="btn btn-primary" ID="btnRegistrarse" OnClick="btnRegistrarse_Click" runat="server" />
            <a href="/">Cancelar</a>
        </div>
    </div>
</asp:Content>
