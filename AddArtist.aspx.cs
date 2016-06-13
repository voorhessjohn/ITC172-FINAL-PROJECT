using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddArtist : System.Web.UI.Page
{
    Website2Reference.ServiceClient swc
        = new Website2Reference.ServiceClient { };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            FillArtistDropDownList();
    }

    protected void FillArtistDropDownList()
    {
        string[] artists = swc.GetArtists();
        ArtistDropDownList.DataSource = artists;
        ArtistDropDownList.DataBind();
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        NewAddArtist();
    }
    //need to make sure that user is logged in before they can add artists.
    protected void NewAddArtist()
    {
        LoginRegistrationServiceReference.LoginServiceClient asc =
            new LoginRegistrationServiceReference.LoginServiceClient();

        LoginRegistrationServiceReference.NewArtist art = new
            LoginRegistrationServiceReference.NewArtist();
        art.ArtistName = ArtistNameTextBox.Text;
        art.ArtistEmail = ArtistEmailTextBox.Text;
        art.ArtistWebPage = ArtistWebPageTextBox.Text;
        art.ArtistDateEntered = DateTime.Now;

       


        bool result = asc.NewAddArtist(art);

        if (result)
        {
            Response.Redirect("AddArtist.aspx");
        }
        else
        {
            ErrorLabel.Text = "Registration Failed";
        }

    }
}