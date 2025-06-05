using System.Collections.Generic;
using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.ValuationRS
{
    [XmlRoot(Namespace = "http://parsec.es/hotelapi/OTA2014Compact", ElementName = "OTA_BookingInfoRS")]
    public class HotelValuationRS
    {
        [XmlArray("Errors")]
        [XmlArrayItem("Error")]
        public List<Common.SupplierErrorRS> Errors { get; set; }
        public List<Common.Msg> Warnings { get; set; }
        public string Success { get; set; }
        public List<Room> Rooms { get; set; }
    }

    public class Room
    {
        public string Status { get; set; }
        [XmlAttribute]
        public string RPH { get; set; }
        public Common.RoomType RoomType { get; set; }
        public List<Common.RoomRate> RoomRates { get; set; }
    }
}
