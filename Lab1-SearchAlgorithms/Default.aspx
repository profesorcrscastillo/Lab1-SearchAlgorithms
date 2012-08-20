<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Lab1_SearchAlgorithms._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
       Ejemplo Algoritmos de busqueda:
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>

    <table>
    <tr>
    <td>
        <asp:Label ID="lblOriginCity" runat="server" Text="Ciudad de origen:"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="ddlOriginCity" runat="server">
        </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
        <asp:Label ID="lblDestinyCity" runat="server" Text="Ciudad de destino:"></asp:Label>
    </td>
    <td>
        <asp:DropDownList ID="ddlDestinyCity" runat="server">
        </asp:DropDownList>
    </td>
    </tr>
    <tr>
    <td>
    </td>
    <td class="search-button-container">
        <asp:Button ID="btnSearch" runat="server" Text="Buscar" 
            onclick="btnSearch_Click" />
    </td>
    </tr>
    </table>
    <br />
    <br />
    <asp:Label ID="lblRouteTitle" runat="server" Text="La ruta mas corta es:" Visible="false"></asp:Label>
    <br />
    <asp:Label ID="lblRoute" runat="server" Text=""  Visible="false"></asp:Label>
</asp:Content>
