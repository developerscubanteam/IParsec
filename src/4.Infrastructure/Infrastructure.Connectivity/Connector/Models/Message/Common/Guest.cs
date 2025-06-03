using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.Common
{
    public enum GuestAgeCode
    {
        A,
        C
    }

    public class Guest
    {
        [XmlAttribute]
        public GuestAgeCode AgeCode { get; set; }
        [XmlAttribute]
        public int Age { get; set; }
        [XmlAttribute]
        public bool LeadGuest { get; set; }
        public PersonName PersonName { get; set; }

    }

    public class PersonName
    {
        public string NamePrefix { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
    }

}
