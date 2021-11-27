<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calcs.aspx.cs" Inherits="CSIS265PROJ08.Calcs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <p>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Rectangle Length: "></asp:Label>
    <asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Rectangle Width: "></asp:Label>
    <asp:TextBox ID="txtWidth" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnAddRectangle" runat="server" Text="Add Rectangle" OnClick="btnAddRectangle_Click" />
    <asp:Button ID="btnDisplayOutput" runat="server" Text="Display Output" OnClick="btnDisplayOutput_Click" />
</p>
<p>
    <asp:Label ID="dislpayOutput" runat="server"></asp:Label>
</p>
<p>
</p>
</asp:Content>
