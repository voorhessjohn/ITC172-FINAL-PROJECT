using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddShow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        NewAddShow();
    }
    
    protected void NewAddShow()
    {
        LoginRegistrationServiceReference.LoginServiceClient asc =
            new LoginRegistrationServiceReference.LoginServiceClient();

        LoginRegistrationServiceReference.NewShow show = new
            LoginRegistrationServiceReference.NewShow();
        show.ShowName = ShowNameTextBox.Text;
        show.VenueKey = (int)Session["UserKey"];
        show.ShowDate = DateTime.Parse(ShowDateTextBox.Text);
        show.ShowTicketInfo = ShowTicketInfoTextBox.Text;
        show.ShowDateEntered =DateTime.Now;
       
        
        

        LoginRegistrationServiceReference.NewShowDetail showd = new
            LoginRegistrationServiceReference.NewShowDetail();
        showd.ArtistKey = int.Parse(ArtistKeyTextBox.Text);
        showd.ShowDetailArtistStartTime = TimeSpan.Parse(ShowDetailArtistStartTimeTextBox.Text);
        showd.ShowDetailAdditional = ShowDetailAdditionalTextBox.Text;


        bool result = asc.NewAddShow(show, showd);

        if (result)
        {
            ErrorLabel.Text = "Show Added";
        
        }
        else
        {
            ErrorLabel.Text = "Registration Failed";
        }

    }

    
}