using ServiceReference;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.BookingRQ
{
    public class BookingRQ
    {
        public BookingSecurityRQ Header { get; set; }
        public BookingBodyRQ Body { get; set; }
        public cancelBookingRequest cancelRq { get; set; }
        public getBookingInfoRequest searchRq { get; set; }

    }

    [XmlType(AnonymousType = true, Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
    public class BookingSecurityRQ
    {
        public SysSecurity CRSysSecurity { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public class BookingBodyRQ
    {
        public HotelResRQ OTA_HotelResRQ { get; set; }
        public ReadRQ OTA_ReadRQ { get; set; }
        public CancelRQ OTA_CancelRQ { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public class ReadRQ
    {
        public UniqueID UniqueID { get; set; }
    }


    [XmlType(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public class CancelRQ
    {
        [XmlAttribute]
        public string Transaction { get; set; }
        public UniqueID UniqueID { get; set; }
    }

    [XmlType(AnonymousType = true, Namespace = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd")]
    public class SysSecurity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [XmlElement(Namespace = "")]
        public string Context { get; set; }
    }

    public enum Transaction
    {
        PreBooking,
        Booking,
    }

    [XmlType(AnonymousType = true, Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public class HotelResRQ
    {
        public UniqueID UniqueID { get; set; }
        public HotelRes HotelRes { get; set; }
        [XmlAttribute]
        public bool RoomInfo { get; set; }
        [XmlAttribute]
        public int DetailLevel { get; set; }
        [XmlAttribute]
        public bool RateDetails { get; set; }
        [XmlAttribute]
        public Transaction Transaction { get; set; }
    }

    public class HotelRes
    {
        public List<Room> Rooms { get; set; }
    }

    public class Room
    {
        public RoomRate RoomRate { get; set; }
        public List<Common.Guest> Guests { get; set; }
    }

    public class RoomRate
    {
        [XmlAttribute]
        public string BookingCode { get; set; }
    }

    public enum UniqueIDType
    {
        ClientReference,
        Reservation,
        Locator
    }

    public class UniqueID
    {
        [XmlAttribute]
        public string ID { get; set; }
        [XmlAttribute]
        public UniqueIDType Type { get; set; }
    }
}