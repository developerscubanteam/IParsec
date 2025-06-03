using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Dto.Common
{
    public enum RateType { Net = 1, Commissionable = 2 }
    public class ExternalSupplier
    {
        public required string Code { get; set; }
        public required Dictionary<string, string> Connection { get; set; }
        public Dictionary<string, string>? Params { get; set; }

        public ConnectionData GetConnection()
        {
            var connection = new ConnectionData()
            {
                Url = Connection["Url"],
                Username = Connection["Username"],
                Password = Connection["Password"],
                Context = Connection["Context"]
            };
            return connection;
        }

    }
}
