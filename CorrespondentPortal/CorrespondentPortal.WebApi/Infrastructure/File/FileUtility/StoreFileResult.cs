namespace CorrespondentPortal.WebApi.Infrastructure.File.FileUtility
{
    public class StoreFileResult
    {
        public string Identifier { get; }

        public StoreFileResult(string identifier)
        {
            Identifier = identifier;
        }
    }
}
