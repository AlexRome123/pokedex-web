<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MenuLoginEjemplo.aspx.cs" Inherits="pokedex_web.MenuLoginEjemplo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>ESTAS LOGEADO</h1>
    <hr />
    <div class="row">
        <div class="col-4">
            <asp:Button Text="Pagina 1" ID="btnPagina1" OnClick="btnPagina1_Click" CssClass="btn btn-primary" runat="server" />
        </div>
        <%dominio.Usuario user = ((dominio.Usuario)Session["usuario"]);
          if(user!=null && user.esAdmin(user.TipoUsuario))
          {%>
        <div class="col-4">
            <asp:Button Text="Pagina 2" ID="btnPagina2" OnClick="btnPagina2_Click" CssClass="btn btn-primary" runat="server" />
            <p>tenes que ser admin</p>
        </div>
        <%} %>
    </div>
</asp:Content>
