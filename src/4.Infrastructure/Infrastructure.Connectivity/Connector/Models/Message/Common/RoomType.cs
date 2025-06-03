using System.Collections.Generic;
using System.Xml.Serialization;

namespace Infrastructure.Connectivity.Connector.Models.Message.Common
{
    public class RoomType
    {
        [XmlAttribute]
        public string Code { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        public string Special { get; set; }
        public List<Common.Msg> ExtraInfo { get; set; }
    }
}
