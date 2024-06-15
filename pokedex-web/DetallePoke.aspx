<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DetallePoke.aspx.cs" Inherits="pokedex_web.DetallePoke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="scriptManager1" runat="server" />
    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">ID</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNumero" class="form-label">Número</label>
                <asp:TextBox runat="server" ID="txtNumero" CssClass="form-control" />
            </div>

            <div class="mb-3">
                <label for="dpDebilidad" class="form-label">Debilidad</label>
                <asp:DropDownList ID="dpDebilidad" class="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <label for="dpTipo" class="form-label">Tipo</label>
                <asp:DropDownList ID="dpTipo" class="form-select" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnAceptar" class="btn btn-primary" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
                <a class="btn btn-primary" href="ListaPoke.aspx">Cancelar</a>
                <asp:Button Text="Desactivar" ID="btnInactivar" OnClick="btnInactivar_Click" CssClass="btn btn-warning" runat="server" />
            </div>
        </div>

        <div class="col-6">
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripción</label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" CssClass="form-control" />
            </div>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="txtUrlImagen" class="form-label">URL Imagen</label>
                        <asp:TextBox runat="server" ID="txtUrlImagen" CssClass="form-control"
                            AutoPostBack="true" OnTextChanged="UrlImagen_TextChanged" />
                    </div>
                    <div>
                        <asp:Image ImageUrl="https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg"
                            ID="ImagePoke" runat="server" Width="43%" />
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    <div class="row">
        <div class="col-6">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <asp:Button ID="btnEliminar" class="btn btn-danger" OnClick="btnEliminar_Click" runat="server" Text="Eliminar" />
                    </div>
                    <%if (ConfirmarElimin)
                      {%>
                    <div class="mb-3">
                        <asp:CheckBox Text="Confirmar eliminación" ID="chkConfirmaElimin" runat="server" />
                        <asp:Button ID="btnConfirmar" class="btn btn-outline-danger" OnClick="btnConfirmar_Click" runat="server" Text="Eliminar" />
                    </div>
                    <%} %>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
