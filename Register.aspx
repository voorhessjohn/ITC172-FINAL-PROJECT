<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Your Venue</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>REGISTER YOUR VENUE!</h1>
        <hr />
    <table>
        <tr>
            <td>Venue Name</td>
            <td>
                <asp:TextBox ID="VenueNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="VenueNameTextBox" ErrorMessage="Venue Name Is Required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>VenueAddress</td>
            <td>
                <asp:TextBox ID="VenueAddressTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>City</td>
            <td>
                <asp:TextBox ID="VenueCityTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>State</td>
            <td>
                <asp:TextBox ID="VenueStateTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Zip Code</td>
            <td>
                <asp:TextBox ID="VenueZipCodeTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Phone Number</td>
            <td>
                <asp:TextBox ID="VenuePhoneTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="VenueEmailTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ErrorMessage="Email is required" ControlToValidate="VenueEmailTextBox"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Not a valid email" ControlToValidate="VenueEmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Web Page Address</td>
            <td>
                <asp:TextBox ID="VenueWebPageTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>Age Restriction?</td>
            <td>
                <asp:TextBox ID="VenueAgeRestrictionTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>User Name</td>
            <td>
                <asp:TextBox ID="VenueLoginUserNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="VenueLoginUserNameTextBox" ErrorMessage="User Name Is Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="VenueLoginPasswordPlainTextBox" runat="server"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="VenueLoginPasswordPlainTextBox" ErrorMessage="Password Is Required"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="ConfirmPasswordTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must match" ControlToCompare="VenueLoginPasswordPlainTextBox" ControlToValidate="ConfirmPasswordTextBox"></asp:CompareValidator></td>
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
