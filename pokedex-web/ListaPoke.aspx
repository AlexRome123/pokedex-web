<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaPoke.aspx.cs" Inherits="pokedex_web.ListaPoke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Lista Pokemon</h1>
    <asp:GridView ID="dgvPokemon" CssClass="table" AutoGenerateColumns="false" runat="server">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
        </Columns>
    </asp:GridView>
</asp:Content>
