using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoginService" in both code and config file together.
[ServiceContract]
public interface ILoginService
{
    [OperationContract]
    bool RegisterVenue(Venue v, VenueLogin vl);

    [OperationContract]
    int VenueLogin(string venueName, string password);

    [OperationContract]
    bool NewAddShow(NewShow s, NewShowDetail sd);

     [OperationContract]
     bool NewAddArtist(NewArtist a);

    [OperationContract]
    bool NewRegisterFan(Fan f, FanLogin fl);

    [OperationContract]
    int FanLogin(string FanUserName, string FanPasswordPlain);

    //[OperationContract]
    //bool FollowArtist(FanArtist fa);

    [OperationContract]
    int AddFanArtist(int fanKey, string artistName);
}

[DataContract]
public class Artists
{
    [DataMember]
    public int ArtistKey { set; get; }

    [DataMember]
    public string ArtistName { set; get; }

    [DataMember]
    public string ArtistEmail { set; get; }

    [DataMember]
    public string ArtistWebPage{set;get;}

    [DataMember]
    public DateTime DateEntered{set;get;}
}

//[DataContract]
//public class FanArtist
//{
//    [DataMember]
//    public int FanKey { set; get; }

//    [DataMember]
//    public int ArtistKey { set; get; }
//}

[DataContract]
public class NewShow
{
    [DataMember]
    public string ShowName { set; get; }

    [DataMember]
    public int VenueKey { set; get; }

    [DataMember]
    public DateTime ShowDate { set; get; }

    [DataMember]
    public TimeSpan ShowTime { set; get; }

    [DataMember]
    public string ShowTicketInfo { set; get; }

    [DataMember]
    public DateTime ShowDateEntered { set; get; }

}

[DataContract]
public class NewShowDetail
{
    [DataMember]
    public int ShowKey { set; get; }

    [DataMember]
    public int ArtistKey { set; get; }

    [DataMember]
    public TimeSpan ShowDetailArtistStartTime { set; get; }

    [DataMember]
    public string ShowDetailAdditional { set; get; }


}

[DataContract]
public class NewArtist
{
    [DataMember]
    public string ArtistName { set; get; }

    [DataMember]
    public string ArtistEmail { set; get; }

    [DataMember]
    public string ArtistWebPage { set; get; }

    [DataMember]
    public DateTime ArtistDateEntered { set; get; }
       
}

//public class VenueInfo
//{
//    [DataMember]
//    public string VenueKey { set; get; }

//    [DataMember]
//    public string VenueName { set; get; }

//    [DataMember]
//    public string VenueAddress { set; get; }

//    [DataMember]
//    public string VenueCity { set; get; }

//    [DataMember]
//    public string VenueState { set; get; }

//    [DataMember]
//    public string VenueZipCode { set; get; }

//    [DataMember]
//    public string VenuePhone { set; get; }

//    [DataMember]
//    public string VenueEmail { set; get; }

//    [DataMember]
//    public string VenueWebPage { set; get; }

//    [DataMember]
//    public int VenueAgeRestriction { set; get; }

//    [DataMember]
//    public DateTime VenueDateAdded { set; get; }

//    [DataMember]
//    public int VenueLoginKey { set; get; }

//    [DataMember]
//    public string VenueLoginUserName { set; get; }

//    [DataMember]
//    public string VenueLoginPasswordPlain { set; get; }
//}