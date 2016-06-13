using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        RegisterVenue();
    }

    protected void RegisterVenue()
    {
        LoginRegistrationServiceReference.LoginServiceClient lsc =
            new LoginRegistrationServiceReference.LoginServiceClient();

        LoginRegistrationServiceReference.Venue v = new
            LoginRegistrationServiceReference.Venue();
        v.VenueName = VenueNameTextBox.Text;
        v.VenueAddress = VenueAddressTextBox.Text;
        v.VenueCity = VenueCityTextBox.Text;
        v.VenueState = VenueStateTextBox.Text;
        v.VenueZipCode = VenueZipCodeTextBox.Text;
        v.VenuePhone = VenuePhoneTextBox.Text;
        v.VenueEmail = VenueEmailTextBox.Text;
        v.VenueWebPage = VenueWebPageTextBox.Text;
        v.VenueAgeRestriction = int.Parse(VenueAgeRestrictionTextBox.Text);

        LoginRegistrationServiceReference.VenueLogin vl = new
            LoginRegistrationServiceReference.VenueLogin();
        vl.VenueLoginUserName = VenueLoginUserNameTextBox.Text;
        vl.VenueLoginPasswordPlain = VenueLoginPasswordPlainTextBox.Text;

        bool result = lsc.RegisterVenue(v, vl);

        if (result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            ErrorLabel.Text = "Registration Failed";
        }

    }

}