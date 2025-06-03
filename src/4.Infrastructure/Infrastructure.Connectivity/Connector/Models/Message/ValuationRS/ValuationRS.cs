using Domain.ValuationCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Connectivity.Connector.Models.Message.ValuationRS
{
    public class ValuationRS
    {
        // public OTA_HotelAvailRSHotels rp { get; set; }      
        //public OTA_BookingInfoRSRooms rp { get; set; }
        public HotelValuationRS results { get; set; }
        public ValuationCode vc { get; set; }
    }
}