using Domain.BookingCode;
using Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRS;
using ServiceReference;
using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.AvailabilityRQ
{
    public class AvailabilityRQ
    {
        public getAvailableHotelsRequest rq { get; set; }
        public int RequestedAccommodations { get; set; }
    }
}