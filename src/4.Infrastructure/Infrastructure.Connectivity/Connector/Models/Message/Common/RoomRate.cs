using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.Common
{
    public class RoomRate
    {
        [XmlAttribute]
        public string MealPlan { get; set; }
        [XmlAttribute]
        public string BookingCode { get; set; }
        public Total Total { get; set; }
        public CancelPenalties CancelPenalties { get; set; }
        public List<Rate> Rates { get; set; }
    }

    public class Rate
    {
        [XmlAttribute]
        public DateTime EffectiveDate { get; set; }
        [XmlAttribute]
        public DateTime ExpireDate { get; set; }
        public Total Total { get; set; }
    }

    public class Total
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

    public class CancelPenalties
    {
        [XmlAttribute]
        public bool NonRefundable { get; set; }
        [XmlElement]
        public List<CancelPenalty> CancelPenalty { get; set; }
        public string Description { get; set; }
    }

    public class CancelPenalty
    {
        public Deadline Deadline { get; set; }
        public Charge Charge { get; set; }
        public string Msg { get; set; }
    }

    public class Deadline
    {
        [XmlAttribute]
        public string TimeUnit { get; set; }
        [XmlAttribute]
        public int Units { get; set; }
    }

    public class Charge
    {
        [XmlAttribute]
        public decimal Amount { get; set; }
        [XmlAttribute]
        public string Currency { get; set; }
    }
}
