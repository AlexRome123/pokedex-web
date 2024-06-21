<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListaPoke.aspx.cs" Inherits="pokedex_web.ListaPoke" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="scriptManager1" runat="server" />
    <h1>Lista Pokemon</h1>
    <div class="col-6">
        <div class="mb-3">
            <asp:Label Text="Buscar" class="form-label" runat="server" />
            <asp:TextBox runat="server" AutoPostBack="true" CssClass="form-control" OnTextChanged="busqueda_TextChanged" ID="txtBusqueda" />
        </div>
    </div>
    <div class="col-6">
        <div class="mb-3">
            <asp:CheckBox Text="Filtro Avanzado" AutoPostBack="true" OnCheckedChanged="cbFiltroAvanzado_CheckedChanged"
                ID="cbFiltroAvanzado" CssClass="fomr-control" runat="server" />
        </div>
    </div>
    <%if (cbFiltroAvanzado.Checked)
        {%>
    <div class="row">
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Campo" class="form-label" runat="server" />
                <asp:DropDownList ID="ddlCampo" CssClass="form-control" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged"
                    AutoPostBack="true" runat="server">
                    <asp:ListItem Text="Nombre" />
                    <asp:ListItem Text="Tipo" />
                    <asp:ListItem Text="Número" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Criterio" class="form-label" runat="server" />
                <asp:DropDownList ID="ddlCriterio" CssClass="form-control" runat="server">
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Filtro" class="form-label" runat="server" />
                <asp:TextBox runat="server" CssClass="form-control" ID="txtFiltro" />
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Label Text="Estado" class="form-label" runat="server" />
                <asp:DropDownList ID="ddlEstado" CssClass="form-control" runat="server">
                    <asp:ListItem Text="Todos" />
                    <asp:ListItem Text="Activo" />
                    <asp:ListItem Text="Inactivo" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-3">
            <div class="mb-3">
                <asp:Button ID="btnBuscar2" CssClass="btn btn-primary" OnClick="btnBuscar2_Click" Text="Buscar" runat="server" />
            </div>
        </div>
    </div>
    <%} %>
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
