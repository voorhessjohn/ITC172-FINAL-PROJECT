using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void VenueLoginButton_Click(object sender, EventArgs e)
    {
        VenueLogin();
    }

    protected void FanLoginButton_Click(object sender, EventArgs e)
    {
        FanLogin();
    }

    protected void VenueLogin()
    {
        LoginRegistrationServiceReference.LoginServiceClient rs =
            new LoginRegistrationServiceReference.LoginServiceClient();
        int key = rs.VenueLogin(VenueUserNameTextBox.Text, VenuePasswordTextBox.Text);
        if (key != 0)
        {
            VenueErrorLabel.Text = "Welcome";
            Session["Userkey"] = key;
        }
        else
        {
            VenueErrorLabel.Text = "Invalid Login";
        }
    }

    protected void FanLogin()
    {
        LoginRegistrationServiceReference.LoginServiceClient rs =
            new LoginRegistrationServiceReference.LoginServiceClient();
        int fanKey = rs.FanLogin(FanUserNameTextBox.Text, FanPasswordTextBox.Text);
        if (fanKey != 0)
        {
            FanErrorLabel.Text = "Welcome Fan";
            Session["Userkey"] = fanKey;
        }
        else
        {
            FanErrorLabel.Text = "Invalid Login";
        }
    }

}