<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ArtistFollow.aspx.cs" Inherits="ArtistFollow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="http://science-all.com/images/wallpapers/koala-pictures/koala-pictures-15.jpg">
    <form id="form1" runat="server">
    <div>
        <p>Select your artists and click enter to add them</p>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="3"></asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Add Artists" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>