<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="EnvioMail.aspx.cs" Inherits="pokedex_web.EnvioMail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <asp:Label CssClass="form-label" Text="Correo Electrónico" runat="server" />
                <asp:TextBox CssClass="form-control" TextMode="Email" ID="txtEmail" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label CssClass="form-label" Text="Asunto" runat="server" />
                <asp:TextBox CssClass="form-control" ID="txtAsunto" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Label CssClass="form-label" Text="Mensaje" runat="server" />
                <asp:TextBox CssClass="form-control" TextMode="MultiLine" ID="txtMensaje" runat="server" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Enviar" ID="btnEnviar" CssClass="btn btn-primary" OnClick="btnEnviar_Click" runat="server" />
            </div>
        </div>
        <div class="col"></div>
    </div>
</asp:Content>
