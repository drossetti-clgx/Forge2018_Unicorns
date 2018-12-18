using System.Collections.Generic;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileVault.DTO
{
    /// <summary>
    /// This class provides methods to manipulate sets of FileAttributes.  A FileAttributeSet is a generic List of FileAttribute objects that is unique based on the lower case version of the FileAttribute.Name property.  Manipulating this list with standard List methods is strongly discouraged, instead use the SetAttribute, GetAttribute, and DeleteAttribute methods.
    /// </summary>
    public class FileAttributeSet : List<FileAttribute>
    {

    }
}
