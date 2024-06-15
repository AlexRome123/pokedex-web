<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaPoke.aspx.cs" Inherits="pokedex_web.ListaPoke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="scriptManager2" runat="server" />
    <h1>Lista Pokemon</h1>
    <div class="col-6">
        <div class="mb-3">
            <asp:Label Text="Buscar" For="txtBusqueda" class="form-label" runat="server" />
            <asp:TextBox runat="server" AutoPostBack="true" CssClass="form-control" OnTextChanged="busqueda_TextChanged" ID="txtBusqueda" />
        </div>
    </div>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="dgvPokemon" CssClass="table" AutoGenerateColumns="false" runat="server"
                OnPageIndexChanging="dgvPokemon_PageIndexChanging" AllowPaging="true" PageSize="5"
                OnSelectedIndexChanged="dgvPokemon_SelectedIndexChanged" DataKeyNames="Id">
                <Columns>
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Número" DataField="Numero" />
                    <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
                    <asp:CheckBoxField HeaderText="Activo" DataField="Activo" />
                    <asp:CommandField HeaderText="Acción" ShowSelectButton="true" SelectText="Modificar" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
    <a class="btn btn-primary" href="DetallePoke.aspx">Agregar</a>
</asp:Content>
