<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddArtist.aspx.cs" Inherits="AddArtist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="http://science-all.com/images/wallpapers/koala-pictures/koala-pictures-15.jpg">
    <form id="form1" runat="server">
    <div>
    <asp:DropDownList ID="ArtistDropDownList" runat="server"></asp:DropDownList>
   <br>
        <h1>Add An Artist!</h1>
        <hr />
    <table>
        <tr>
            <td>Artist Name</td>
            <td>
                <asp:TextBox ID="ArtistNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
               
            </td>
        </tr>       
        <tr>
            <td>Artist Email</td>
            <td>
                <asp:TextBox ID="ArtistEmailTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Artist Web Page</td>
            <td>
                <asp:TextBox ID="ArtistWebPageTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
            </table>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        <br/>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
         </div>
    </form>
</body>
</html>
