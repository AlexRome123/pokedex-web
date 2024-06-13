<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaPoke.aspx.cs" Inherits="pokedex_web.ListaPoke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lista Pokemon</h1>
    <asp:GridView ID="dgvPokemon"  CssClass="table"  AutoGenerateColumns="false" runat="server" 
        OnPageIndexChanging="dgvPokemon_PageIndexChanging" AllowPaging="true" PageSize="5"
        OnSelectedIndexChanged ="dgvPokemon_SelectedIndexChanged" DataKeyNames="Id" >
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Número" DataField="Numero" />
            <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
            <asp:CommandField HeaderText="Acción" ShowSelectButton="true" SelectText="Modificar" />
        </Columns>
    </asp:GridView>
    <a class="btn btn-primary" href="DetallePoke.aspx">Agregar</a>
</asp:Content>
