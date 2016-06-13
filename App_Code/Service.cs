using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public List<string> GetArtists()
    {
        ShowTrackerEntities db = new ShowTrackerEntities();
        var arts = from a in db.Artists
                   select new { a.ArtistName };
        List<string> bands = new List<string>();
        foreach (var a in arts)
        {
            bands.Add(a.ArtistName);
        }

        return bands;
    }

    public List<string> GetVenues()
    {
        ShowTrackerEntities db = new ShowTrackerEntities();
        var vens = from v in db.Venues
                   select new { v.VenueName };
        List<string> names = new List<string>();
        foreach (var v in vens)
        {
            names.Add(v.VenueName);
        }

        return names;
    }

    public List<string> GetShows()
    {
        ShowTrackerEntities db = new ShowTrackerEntities();
        var sh = from s in db.Shows
                   select new { s.ShowName };
        List<string> shows = new List<string>();
        foreach (var s in sh)
        {
            shows.Add(s.ShowName);
        }

        return shows;
    }

    public List<ShowLite> ShowShows(string VenueName)
    {
        ShowTrackerEntities db = new ShowTrackerEntities();
        var sws = from b in db.Shows
                 
                  orderby b.ShowName
                  where b.Venue.VenueName.Equals(VenueName)
                  select new
                  {
                      b.ShowName,
                      b.ShowDate,
                      b.ShowTime
                  };
        List<ShowLite> shows = new List<ShowLite>();

        foreach (var bk in sws)
        {
            ShowLite sw = new ShowLite();
            sw.ShowName = bk.ShowName;
            sw.ShowDate = bk.ShowDate;
            sw.ShowTime = bk.ShowTime;
            shows.Add(sw);
        }
        return shows;
    }

    public List<ShowArtistLite> ShowArtistShows(string ArtistName)
    {
        ShowTrackerEntities db = new ShowTrackerEntities();
        var sws = from b in db.Shows
                  from a in b.ShowDetails
                  orderby b.ShowName
                  where a.Artist.ArtistName.Equals(ArtistName)
                  select new
                  {
                      b.ShowName,
                      b.ShowDate,
                      b.ShowTime,
                      b.Venue.VenueName
                  };
        List<ShowArtistLite> artistshows = new List<ShowArtistLite>();

        foreach (var bk in sws)
        {
            ShowArtistLite sw = new ShowArtistLite();
            sw.ShowName = bk.ShowName;
            sw.ShowDate = bk.ShowDate;
            sw.ShowTime = bk.ShowTime;
            sw.VenueName = bk.VenueName;
            artistshows.Add(sw);
        }
        return artistshows;
    }
}
