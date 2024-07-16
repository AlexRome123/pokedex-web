<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MiPerfil.aspx.cs" Inherits="pokedex_web.MiPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .validator {
            color: red;
            font-size: 16px;
        }
    </style>
    <script>
        function validar() {
            const txtNombre = document.getElementById("txtNombre");
            if (txtNombre.value == "") {
                txtNombre.classList.add("is-invalid");
                return false;
            }
            txtNombre.classList.remove("is-invalid");
            return true;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Mi Perfil</h2>
    <div class="row">
        <div class="col-md-4">
            <div class="mb-3">
                <label class="form-label">Email</label>
                <asp:TextBox runat="server" TextMode="Email" ID="txtEmail" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label class="form-label">Nombre</label>
                <asp:TextBox runat="server" ClientIDMode="Static" ID="txtNombre" CssClass="form-control" />
<%--                <asp:RequiredFieldValidator CssClass="validator" ErrorMessage="Campo Requerido" ControlToValidate="txtNombre" runat="server" />--%>
            </div>
            <div class="mb-3">
                <label class="form-label">Apellido</label>
                <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
<%--                <asp:RegularExpressionValidator ErrorMessage="Formato Email incorrecto." ControlToValidate="txtApellido" runat="server"
                    ValidationExpression="^[^@]+@[^@]+\.[a-zA-Z]{2,}$" CssClass="validator" />--%>
<%--                <asp:RangeValidator ErrorMessage="Fuera de Rango." ControlToValidate="txtApellido" Type="Integer"
                    MinimumValue="1" MaximumValue="20" CssClass="validator" runat="server" />--%>
            </div>
            <div class="mb-3">
                <label class="form-label">Fecha de Nacimiento</label>
                <asp:TextBox runat="server" TextMode="Date" ID="txtNacimieto" CssClass="form-control" />
            </div>
        </div>

        <div class="col-md-4">
            <div class="mb-3">
                <label class="fomr-label">Imagen Perfil</label>
                <input type="file" class="form-control" runat="server" id="txtImagen" />
            </div>
            <asp:Image ImageUrl="https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png"
                ID="imgNewPerfil" runat="server" CssClass="img-fluid mb-3" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <asp:Button Text="Guardar" OnClientClick="return validar()" CssClass="btn btn-primary" ID="btnGuardar" OnClick="btnGuardar_Click" runat="server" />
            <a href="/">Cancelar</a>
        </div>
    </div>
</asp:Content>
