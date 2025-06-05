using Domain.BookingCode;
using Domain.ValuationCode;
using System.Text;

namespace Application.WorkFlow.Services
{
    public static class FlowCodeServices
    {
        private const string FieldValuationSeparator = "^[";
        private const string FieldBookingSeparator = "^]";
        private const string RowSeparator = "__";
        private const string RowFieldSeparator = "~,";

        public static string GetValuationCode(StringBuilder vc, string establishmentId, string bookingCode, int roomsRef, string checking)
        {
            vc.Append(establishmentId).Append(FieldValuationSeparator);
            vc.Append(bookingCode).Append(FieldValuationSeparator);
            vc.Append(roomsRef).Append(FieldValuationSeparator);
            vc.Append(checking);
            var valuationCode = vc.ToString();
            vc.Clear();

            return valuationCode;
        }

        public static string SumValuationCodes(string valuationCode1, string valuationCode2)
        {
            // Dividir las cadenas de entrada utilizando el separador.
            string[] values1 = valuationCode1.Split(new[] { FieldValuationSeparator }, StringSplitOptions.None);
            string[] values2 = valuationCode2.Split(new[] { FieldValuationSeparator }, StringSplitOptions.None);

            // Asegurarse de que ambas cadenas tengan el mismo número de campos.
            if (values1.Length != values2.Length)
            {
                throw new ArgumentException("Las cadenas de valoración deben tener el mismo número de campos.");
            }

            var tupleToadd1 = values2[1].Split(RowSeparator);
           
            for (int i = 0; i < tupleToadd1.Length; i++)
            {
                values1[1] = values1[1] + RowSeparator + tupleToadd1[i];
            }

            var tupleToadd2 = values2[2].Split(RowSeparator);

            for (int i = 0; i < tupleToadd2.Length; i++)
            {
                values1[2] = values1[2] + RowSeparator + tupleToadd2[i];
            }

            var consolidatedVC = string.Join(FieldValuationSeparator, values1);
            return consolidatedVC;
        }

        public static ValuationCode DecodeValuationCode(string valuationCode)
        {
            var vcParams = valuationCode.Split(FieldValuationSeparator);

            var bookingCodeList = vcParams[1].Split(RowSeparator);
            var bookingCodeFields = new List<string>();

            foreach (var bookingCode in bookingCodeList)
            {
                bookingCodeFields.Add(bookingCode);
            }

            var roomsRefsList = vcParams[2].Split(RowSeparator);
            var roomFields = new List<int>();

            foreach (var room in roomsRefsList)
            {              
               roomFields.Add(int.Parse(room));
            }
            var vc = new ValuationCode()
            {
                EstablishmentId = vcParams[0],
                BokingCode = bookingCodeFields.ToArray(),
                RoomsRef = roomFields.ToArray(),
                Checking = vcParams[3]
            };

            return vc;
        }

        public static string GetBookingCode(string vc)
        {
            var bc = new StringBuilder();
            bc.Append(vc);           
            return bc.ToString();
        }

        public static BookingCode DecodeBookingCode(string bookingCode)
        {
            var bcParams = bookingCode.Split(FieldValuationSeparator);

            var bc = new BookingCode()
            {
               ValuationCode = bookingCode,
               BookCode = bcParams[1]
            };

            return bc;
        }
    }
}
