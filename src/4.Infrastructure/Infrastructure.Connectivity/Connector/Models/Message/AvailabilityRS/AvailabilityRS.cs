using System.Collections.Generic;
using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRS
{
    [XmlRoot(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", ElementName = "OTA_HotelAvailRS")]
    public class AvailabilityRS
    {
        [XmlAttribute]
        public string PrimaryLangID { get; set; }
        [XmlAttribute]
        public string Id { get; set; }
        public Hotels Hotels { get; set; }
        [XmlArray("Errors")]
        [XmlArrayItem("Error")]
        public List<Common.SupplierErrorRS> Errors { get; set; }
    }

    public class Hotels
    {
        [XmlAttribute]
        public int HotelCount { get; set; }
        [XmlElement("Hotel")]
        public List<Hotel> Hotel { get; set; }
    }

    public class Hotel
    {
        public Info Info { get; set; }
        public List<Room> Rooms { get; set; }
    }

    public class Info
    {
        [XmlAttribute]
        public string HotelCode { get; set; }
        public List<Common.Msg> Warnings { get; set; }
    }

    public class Room
    {
        [XmlAttribute]
        public string Status { get; set; }
        [XmlAttribute]
        public string RPH { get; set; }
        public Common.RoomType RoomType { get; set; }
        public List<Common.RoomRate> RoomRates { get; set; }
    }

}
