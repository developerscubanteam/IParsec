using ServiceReference;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.BookingRS
{
    [XmlRoot(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", ElementName = "OTA_BookingInfoRS")]
    public class BookingInfoRs
    {
        [XmlArray("Errors")]
        [XmlArrayItem("Error")]
        public List<Common.SupplierErrorRS> Errors { get; set; }
        public List<Common.Msg> Warnings { get; set; }
        public string Success { get; set; }
        public List<HotelRes> HotelResList { get; set; }
        public ResGlobalInfo ResGlobalInfo { get; set; }
    }

    public class HotelRes
    {
        [XmlAttribute]
        public string ResStatus { get; set; }
        [XmlArray("Rooms")]
        [XmlArrayItem("Room")]
        public List<BookingRoom> Rooms { get; set; }
        public Info Info { get; set; }
        public HotelResInfo HotelResInfo { get; set; }
    }
    public class BookingRoom
    {
        public Common.RoomType RoomType { get; set; }
        public Common.RoomRate RoomRate { get; set; }
        public List<Common.Guest> Guests { get; set; }
    }

    public class Info
    {
        [XmlAttribute]
        public string HotelCode { get; set; }
        [XmlAttribute]
        public string HotelName { get; set; }
        public List<Common.Msg> Warnings { get; set; }
    }

    public class HotelResInfo
    {   
        public DataRange DataRange { get; set; }
        public BookingTotal Total { get; set; }
        [XmlArray("HotelResIDs")]
        [XmlArrayItem("HotelResID")]
        public List<ResID> HotelResIDs { get; set; }
    }



    public class ResGlobalInfo
    {
        public DataRange DataRange { get; set; }
        public BookingTotal Total { get; set; }   
        public List<ResID> ResIDs { get; set; }
    }

    public class ResID
    {
        [XmlAttribute]
        public string Type { get; set; }
        [XmlAttribute]
        public string ID { get; set; }
    }

    public class DataRange
    { 
        [XmlAttribute]
        public string Start { get; set; }
        [XmlAttribute]
        public string End { get; set; }

    }
    public class BookingTotal
    {
        [XmlAttribute]
        public decimal Amount { get; set; }
        [XmlAttribute]
        public decimal Commission { get; set; }
        [XmlAttribute]
        public decimal MinPrice { get; set; }
        [XmlAttribute]
        public string Currency { get; set; }
    }

}
