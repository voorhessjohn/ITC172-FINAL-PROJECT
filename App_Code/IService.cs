using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    List<string> GetArtists();

    [OperationContract]
    List<string> GetVenues();

    [OperationContract]
    List<string> GetShows();

    [OperationContract]
    List<ShowLite> ShowShows(string VenueName);

    [OperationContract]
    List<ShowArtistLite> ShowArtistShows(string ArtistName);
}

[DataContract]
public class ShowLite
{
    [DataMember]
    public string ShowName { set; get; }

    [DataMember]
    public DateTime ShowDate { set; get; }

    [DataMember]
    public TimeSpan ShowTime { set; get; }
}

[DataContract]
public class ShowArtistLite
{
    [DataMember]
    public string ShowName { set; get; }

    [DataMember]
    public DateTime ShowDate { set; get; }

    [DataMember]
    public TimeSpan ShowTime { set; get; }

    [DataMember]
    public string VenueName { set; get; }
}
