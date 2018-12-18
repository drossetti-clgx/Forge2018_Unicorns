using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Forge2018Connectivity
{
    public class HelperMethods
    {
        public static string SerializeXml(object order)
        {
            var req = new XmlSerializer(order.GetType());

            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb))
            {
                req.Serialize(writer, order);
            }
            return sb.ToString();
        }

        public static T DeserializeXml<T>(string xmlObj)
        {
            var req = new XmlSerializer(typeof(T));
            var tr = new StringReader(xmlObj);
            var reader = XmlReader.Create(tr);
            return (T)req.Deserialize(reader);
        }
    }
}
