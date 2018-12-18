using System.IO;
using System.Text;

namespace CorrespondentPortal.WebApi.Infrastructure.Http
{
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
