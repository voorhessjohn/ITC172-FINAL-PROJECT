using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in code, svc and config file together.
public class LoginService : ILoginService
{
    ShowTrackerEntities1 db = new ShowTrackerEntities1();

    public bool RegisterVenue(Venue v, VenueLogin vl)
    {
        bool result = true;
        int pass = db.usp_RegisterVenue(
            v.VenueName,
            v.VenueAddress,
            v.VenueCity,
            v.VenueState,
            v.VenueZipCode,
            v.VenuePhone,
            v.VenueEmail,
            v.VenueWebPage,
            v.VenueAgeRestriction,
            vl.VenueLoginUserName,
            vl.VenueLoginPasswordPlain);
        if (pass == -1)
        {
            result = false;
        }

        return result;
    }

    public bool NewRegisterFan(Fan f, FanLogin fl)
    {
        bool result = true;
        int pass = db.usp_RegisterFan(
            f.FanName,
            f.FanEmail,
           fl.FanLoginUserName,
           fl.FanLoginPasswordPlain);
        if (pass == -1)
        {
            result = false;
        }

        return result;
    }

    public bool NewAddShow(NewShow s, NewShowDetail sd)
    {
        Show show = new Show();
        ShowDetail showd = new ShowDetail();
        show.ShowName = s.ShowName;
        show.VenueKey = s.VenueKey;
        show.ShowDate = s.ShowDate;
        show.ShowTime = s.ShowTime;
        show.ShowTicketInfo = s.ShowTicketInfo;
        show.ShowDateEntered = DateTime.Now;
        show.ShowKey = sd.ShowKey;
        showd.ArtistKey = sd.ArtistKey;
        showd.ShowDetailArtistStartTime = sd.ShowDetailArtistStartTime;
        showd.ShowDetailAdditional = sd.ShowDetailAdditional;
        bool result = true;
        try
        {
            db.Shows.Add(show);
            db.SaveChanges();
            db.ShowDetails.Add(showd);
            db.SaveChanges();
        }
        catch { result = false; }
        return result;
    }

    public bool NewAddArtist(NewArtist a)
    {
        Artist art = new Artist();
        art.ArtistName = a.ArtistName;
        art.ArtistEmail = a.ArtistEmail;
        art.ArtistWebPage = a.ArtistWebPage;
        art.ArtistDateEntered = DateTime.Now;
        bool result = true;
        try
        {
            db.Artists.Add(art);
            db.SaveChanges();
        }
        catch { result = false; }
        return result;
    }

    //public bool FollowArtist(FanArtist fa)
    //{
    //    FanArtist fart = new FanArtist();
    //    fart.FanKey = fa.FanKey;
    //    fart.ArtistKey = fa.ArtistKey;
    //    bool result = true;
    //    try
    //    {
    //        db.FanArtists.Add(fart);
    //        db.SaveChanges();
    //    }
    //    catch { result = false; }
    //    return result;
    //}

    public int VenueLogin(string username, string password)
    {
        int venueKey = 0;
        int result = db.usp_venueLogin(username, password);
        if (result != -1)
        {
            var key = (from vl in db.VenueLogins
                       where vl.VenueLoginUserName.Equals(username)
                       select new { vl.VenueKey }).FirstOrDefault();


            venueKey = (int)key.VenueKey;

        }
        return venueKey;
    }

    public int FanLogin(string FanUserName, string FanPassword)
    {
        int fanKey = 0;
        int result = db.usp_FanLogin(FanUserName, FanPassword);
        if (result != -1)
        {
            var key = (from fl in db.FanLogins
                       where fl.FanLoginUserName.Equals(FanUserName)
                       select new { fl.FanKey }).FirstOrDefault();


            fanKey = (int)key.FanKey;

        }
        return fanKey;
    }

    //public int AddFanArtist(int fanKey, string artistName)
    //{
    //    /*********************************
    //     * This method will add an artist to the artistFan
    //     * table. First we have to find the fan
    //     * and then the particular artist
    //     * Then we add the artist to the Fan's list
    //     * of artists to follow
    //     * **********************************/
    //    int result = 1;

    //    //get the fan. the key can come from their login
    //    FanArtist myFan = (from f in db.FanArtists
    //                 where f.FanKey == fanKey
    //                 select f).First();

    //    //get the artist by name
    //    Artist myArtist = (from a in db.Artists
    //                       where a.ArtistName.Equals(artistName)
    //                       select a).First();

    //    //add the artist to the fan;'s collection of artists
    //    myFan.Artists.Add(myArtist);

    //    //save the changes
    //    db.SaveChanges();

    //    return result;
    //}
    public int AddFanArtist(int fanKey, string artistName)
    {
        /*********************************
         * This method will add an artist to the artistFan
         * table. First we have to find the fan
         * and then the particular artist
         * Then we add the artist to the Fan's list
         * of artists to follow
         * **********************************/
        int result = 1;

        //get the fan. the key can come from their login
        //Fan myFan = (from f in db.Fans
        //             where f.FanKey == fanKey
        //             select f).First();

        ////get the artist by name
        //Artist myArtist = (from a in db.Artists
        //                   where a.ArtistName.Equals(artistName)
        //                   select a).First();

        ////add the artist to the fan;'s collection of artists
        //myFan.Artists.Add(myArtist);
        var Akey= (from A in db.Artists
                   where A.ArtistName == artistName
            select new { A.ArtistKey}).FirstOrDefault();

        int key = (int)Akey.ArtistKey;

        FanArtist fa = new FanArtist();
        fa.FanKey = fanKey;
        fa.ArtistKey = key;
        db.FanArtists.Add(fa);
        //save the changes
        db.SaveChanges();
        
        return result;


    }

}



