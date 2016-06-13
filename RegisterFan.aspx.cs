using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterFan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        NewRegisterFan();
    }

    protected void NewRegisterFan()
    {
        LoginRegistrationServiceReference.LoginServiceClient lsc =
            new LoginRegistrationServiceReference.LoginServiceClient();

        LoginRegistrationServiceReference.Fan f = new
            LoginRegistrationServiceReference.Fan();
        f.FanName = FanNameTextBox.Text;
        f.FanEmail = FanEmailTextBox.Text;
        f.FanDateEntered = DateTime.Now;
        
        LoginRegistrationServiceReference.FanLogin fl = new
            LoginRegistrationServiceReference.FanLogin();
        fl.FanLoginUserName = FanLoginUserNameTextBox.Text;
        fl.FanLoginPasswordPlain = FanLoginPasswordPlainTextBox.Text;

        bool result = lsc.NewRegisterFan(f, fl);

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