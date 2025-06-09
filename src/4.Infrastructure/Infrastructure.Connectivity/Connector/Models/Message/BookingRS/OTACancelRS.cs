using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Connectivity.Connector.Models.Message.BookingRS
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "OTA_CancelRS", Namespace = "http://parsec.es/hotelapi/OTA2014Compact")]
    public class OTACancelRS
    {
        [XmlAttribute("TimeStamp")]
        public DateTime TimeStamp { get; set; }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlArray("Errors")]
        [XmlArrayItem("Error")]
        public List<ErrorOTACancel> Errors { get; set; }
    }

    public class ErrorOTACancel
    {
        [XmlAttribute("Status")]
        public string Status { get; set; }

        [XmlAttribute("Language")]
        public string Language { get; set; }

        [XmlText]
        public string Message { get; set; }
    }

}
