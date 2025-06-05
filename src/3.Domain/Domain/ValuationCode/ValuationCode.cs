namespace Domain.ValuationCode
{
    public class ValuationCode
    {
        public string EstablishmentId { get; set; }
        public string[] BokingCode { get; set; }
        public int[] RoomsRef { get; set; }
        public string Checking { get; set; }
    }
}
