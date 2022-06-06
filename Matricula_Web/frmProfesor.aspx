<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProfesor.aspx.cs" Inherits="Matricula_Web.frmProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 249px;
        }
        .auto-style2 {
            width: 202px;
        }
        .auto-style3 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style3">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:DropDownList ID="ddlProfesor" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Cedula</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProfesor_cedula" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnCargarDatos" runat="server" Text="CARGAR DATOS" OnClick="btnCargarDatos_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Nombre</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProfesor_nombre" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Primer apellido</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProfesor_primerApellido" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Segundo apellido</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProfesor_segundoApellido" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Telefono</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProfesor_telefono" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Correo electronico</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProfesor_correoElectronico" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Direccion</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtProfesor_direccion" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnInsertar" runat="server" OnClick="btnInsertar_Click" Text="INSERTAR" />
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnModificar" runat="server" Text="MODIFICAR" OnClick="btnModificar_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
        <asp:GridView ID="gvProfesor" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
