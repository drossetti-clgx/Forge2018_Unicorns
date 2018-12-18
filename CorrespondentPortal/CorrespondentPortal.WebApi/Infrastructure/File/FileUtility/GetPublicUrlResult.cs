namespace CorrespondentPortal.WebApi.Infrastructure.File.FileUtility
{
    public class GetPublicUrlResult
    {
        public string PublicUrl { get; }

        public GetPublicUrlResult(string publicUrl)
        {
            PublicUrl = publicUrl;
        }
    }
}
