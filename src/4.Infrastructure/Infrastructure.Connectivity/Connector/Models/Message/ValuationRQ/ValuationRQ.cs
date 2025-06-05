using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.ValuationRQ
{
    [XmlRoot("BookingRQ")]
    public class ValuationRQ: BookingRQ.BookingRQ
    { }
}