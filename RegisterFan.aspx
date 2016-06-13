<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterFan.aspx.cs" Inherits="RegisterFan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>REGISTER YOURSELF AS A FAN!</h1>
        <hr />
    <table>
        <tr>
            <td>Your Name</td>
            <td>
                <asp:TextBox ID="FanNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FanNameTextBox" ErrorMessage="Your Name Is Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Your Email Address</td>
            <td>
                <asp:TextBox ID="FanEmailTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="FanEmailTextBox" ErrorMessage="Your Email Is Required"></asp:RequiredFieldValidator>
            </td>
        </tr>      
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="FanLoginUserNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FanLoginUserNameTextBox" ErrorMessage="User Name Is Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="FanLoginPasswordPlainTextBox" runat="server"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="FanLoginPasswordPlainTextBox" ErrorMessage="Password Is Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must match" ControlToCompare="FanLoginPasswordPlainTextBox" ControlToValidate="ConfirmPasswordTextBox"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            </td>
            <td>
                <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>


    </table>
    </div>
    </form>
</body>
</html>
