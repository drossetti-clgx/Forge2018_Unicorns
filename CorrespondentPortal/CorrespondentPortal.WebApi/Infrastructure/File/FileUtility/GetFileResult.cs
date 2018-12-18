using System.Collections.Generic;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileUtility
{
    public class GetFileResult
    {
        public IEnumerable<byte> Bytes { get; }
        public string FileName { get; }

        public GetFileResult(IEnumerable<byte> bytes, string fileName)
        {
            Bytes = bytes;
            FileName = fileName;
        }
    }
}
