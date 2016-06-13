using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ArtistFollow : System.Web.UI.Page
{
    LoginRegistrationServiceReference.LoginServiceClient sc = new LoginRegistrationServiceReference.LoginServiceClient();
    protected void Page_Load(object sender, EventArgs e)

    {
        //I hard coded the key in so I didn't have to do the login 
        //for this example
        //Session["key"] = (int)Session["UserKey"];
        if (Session["UserKey"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        if (!IsPostBack)
            PopulateArtists();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AddArtists();
    }

    protected void AddArtists()
    {
        //get the fan's key
        int key = (int)Session["Userkey"];

        //loop through the checkboxList
        //to see what's checked
        foreach (ListItem i in CheckBoxList1.Items)
        {
            //if it is checked call the service method to add
            //it to the database
            if (i.Selected)
            {
                int x = sc.AddFanArtist(key, i.Text);
            }
        }
        Label1.Text = "Artist have been added";
        CheckBoxList1.Items.Clear();
    }

    Website2Reference.ServiceClient scc = new Website2Reference.ServiceClient();

    protected void PopulateArtists()
    {
        //this method populates the CheckboxList
        //with artist names
        string[] artists = scc.GetArtists();
        CheckBoxList1.DataSource = artists;
        CheckBoxList1.DataBind();
    }

   
}