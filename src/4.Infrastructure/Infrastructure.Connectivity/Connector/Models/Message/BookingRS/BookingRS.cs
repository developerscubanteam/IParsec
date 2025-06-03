using ServiceReference;

namespace Infrastructure.Connectivity.Connector.Models.Message.BookingRS
{
    public class BookingRS
    {
        public OTA_BookingInfoRSHotelResList rs { get; set; }
        public OTA_BookingInfoRSResGlobalInfo rsGlobalInfo { get; set; }
        public cancelBookingResponse cancelRs { get; set; }
        public getBookingInfoResponse getRs { get; set; }

        //Nuevo
        public BookingInfoRs BookingInfoRs { get; set; }
    }
}