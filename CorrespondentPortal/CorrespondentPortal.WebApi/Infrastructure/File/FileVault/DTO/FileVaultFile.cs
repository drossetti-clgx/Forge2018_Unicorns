using System;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileVault.DTO
{
    public class FileVaultFile
    {
        /// <summary>
        /// Enumerable of file modes supported in FileVault.
        /// </summary>
        public enum FileVaultFileMode
        {
            /// <summary>
            /// Indicates the file is read-only.  Content cannot be changed, but metadata can by the owning application.
            /// </summary>
            ReadOnly = 440,
            /// <summary>
            /// Indicates the file is read-write.  Content and metadata can be changed by the owning application.
            /// </summary>
            ReadWrite = 640,
            /// <summary>
            /// Indicates the file is private and read-only.  The file cannot be accessed by other applications.  Content cannot be changed, but metadata can by the owning application.
            /// </summary>
            PrivateReadOnly = 400,
            /// <summary>
            /// Indicates the file is private and read-write.  The file cannot be accessed by other applications.  Content and metadata can be changed by the owning application.
            /// </summary>
            PrivateReadWrite = 600
        };

        /// <summary>
        /// Gets or sets a value indicating whether [information only].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [information only]; otherwise, <c>false</c>.
        /// </value>
        public bool InfoOnly { get; set; }
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        public System.Guid Guid { get; set; }
        /// <summary>
        /// Gets or sets the port identifier.
        /// </summary>
        /// <value>
        /// The port identifier.
        /// </value>
        public string PortId { get; set; }
        /// <summary>
        /// Gets or sets the application owner identifier.
        /// </summary>
        /// <value>
        /// The application owner identifier.
        /// </value>
        public long AppOwnerId { get; set; }
        /// <summary>
        /// Gets or sets the name of the application owner.
        /// </summary>
        /// <value>
        /// The name of the application owner.
        /// </value>
        public string AppOwnerName { get; set; }
        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        /// <value>
        /// The filename.
        /// </value>
        public string Filename { get; set; }
        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        public FileVaultFileMode Mode { get; set; }
        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public System.DateTime CreatedDate { get; set; }
        /// <summary>
        /// Gets or sets the last accessed date.
        /// </summary>
        /// <value>
        /// The last accessed date.
        /// </value>
        public System.DateTime LastAccessedDate { get; set; }
        /// <summary>
        /// Gets or sets the expiration date.
        /// </summary>
        /// <value>
        /// The expiration date.
        /// </value>
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public FileAttributeSet Attributes { get; set; }
        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public string FullPath { get; set; }
        /// <summary>
        /// Gets or sets the file as byte array.
        /// </summary>
        /// <value>
        /// The file as byte array.
        /// </value>
        public byte[] FileAsByteArray { get; set; }
        /// <summary>
        /// Gets or sets the file size in bytes.
        /// </summary>
        /// <value>
        /// The file size in bytes.
        /// </value>
        public long FileSizeInBytes { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is file bank green file.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is file bank green file; otherwise, <c>false</c>.
        /// </value>
        public bool IsFileBankGreenFile { get; set; }
        /// <summary>
        /// Gets or sets the e tag.
        /// </summary>
        /// <value>
        /// The e tag.
        /// </value>
        public string ETag { get; set; }
        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        /// <value>
        /// The last modified date.
        /// </value>
        public System.DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetFileContentAsBase64String()
        {
            try
            {
                if (FileAsByteArray != null)
                {
                    return Convert.ToBase64String(FileAsByteArray);
                }
                throw new Exception("FileVault: Cannot convert file content to Base64Encoded string. FileAsByteArray is null.");
            }
            catch (Exception e)
            {
                throw new Exception($"FileVault: Cannot convert file contents to Base64Encoded string. FileVaultId: {Guid}. Message:{e.Message}." );
            }
        }
    }
}
