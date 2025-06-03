using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.Common
{
    public class Msg
    {
        [XmlText]
        public string Text { get; set; }
    }
}
