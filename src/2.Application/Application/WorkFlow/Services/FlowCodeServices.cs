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

        public static string GetValuationCode(StringBuilder vc, string establishmentId, string bookingCode, int roomsRef)
        {
            vc.Append(establishmentId).Append(FieldValuationSeparator);
            vc.Append(bookingCode).Append(FieldValuationSeparator);
            vc.Append(roomsRef).Append(FieldValuationSeparator);

           /* for (int i = 0; i < bookingCode.Length; i++)
            {
                vc.Append(bookingCode[i]);
                if (i < bookingCode.Length - 1)
                {
                    vc.Append(RowFieldSeparator);
                }
            }

            vc.Append(FieldValuationSeparator);

            for (int i = 0; i < roomsRef.Length; i++)
            {
                vc.Append(roomsRef[i]);
                if (i < roomsRef.Length - 1)
                {
                    vc.Append(RowFieldSeparator);
                }
            }*/

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
                RoomsRef = roomFields.ToArray()
            };

            return vc;
        }

        public static string GetBookingCode(string vc, string bookCode)
        {
            var bc = new StringBuilder();
            bc.Append(vc).Append(FieldBookingSeparator);
            bc.Append(bookCode);           
            return bc.ToString();
        }

        public static BookingCode DecodeBookingCode(string bookingCode)
        {
            var bcParams = bookingCode.Split(FieldBookingSeparator);

            var bc = new BookingCode()
            {
               ValuationCode = bcParams[0],
               BookCode = bcParams[1]
            };

            return bc;
        }
    }
}
