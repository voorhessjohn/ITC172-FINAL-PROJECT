<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login or Register</title>
</head>
<body background="http://science-all.com/images/wallpapers/koala-pictures/koala-pictures-15.jpg">
    <form id="form1" runat="server">
    <div>
        <h1>Login or Register</h1>
        <hr/>
        <table>
            <tr>
                <td>Venue Username</td>
                <td>
                    <asp:TextBox ID="VenueUserNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Venue Password</td>
                <td>
                    <asp:TextBox ID="VenuePasswordTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                   <asp:Button ID="LoginButton" runat="server" Text="Log In" OnClick="VenueLoginButton_Click" />
               </td> 
                <td>
                    <asp:Label ID="VenueErrorLabel" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Fan Username</td>
                <td>
                    <asp:TextBox ID="FanUserNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fan Password</td>
                <td>
                    <asp:TextBox ID="FanPasswordTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                   <asp:Button ID="FanLoginButton" runat="server" Text="Log In" OnClick="FanLoginButton_Click" />
               </td> 
                <td>
                    <asp:Label ID="FanErrorLabel" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
        <asp:LinkButton ID="RegisterLink" runat="server" PostBackUrl="Register.aspx">Register Venue</asp:LinkButton>
        <br/>
        <asp:LinkButton ID="AddShowLink" runat="server" PostBackUrl="AddShow.aspx">Add A Show</asp:LinkButton>
        <br/>
        <asp:LinkButton ID="ArtistLink" runat="server" PostBackUrl="AddArtist.aspx">Artists</asp:LinkButton>
        <br/>
         <asp:LinkButton ID="FanLink" runat="server" PostBackUrl="RegisterFan.aspx">Register Yourself As A Fan</asp:LinkButton>
        <br/>
        <asp:LinkButton ID="FanArtistLink" runat="server" PostBackUrl="ArtistFollow.aspx">Follow An Artist</asp:LinkButton>
    </div>
    </form>
</body>
</html>
