using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static CorrespondentPortal.WebApi.Infrastructure.File.FileVault.DTO.FileVaultFile;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileVault.DTO
{
    /// <summary>
    /// DTO containing file upload parameters.
    /// </summary>
    public class UploadFileParametersDto
    {
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
        public long? AppOwnerId { get; set; }
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
        public FileVaultFile.FileVaultFileMode Mode { get; set; }
        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public FileAttributeSet Attributes { get; set; }
        /// <summary>
        /// Gets or sets the expiration in days.
        /// </summary>
        /// <value>
        /// The expiration in days.
        /// </value>
        public int? ExpirationInDays { get; set; }

        /// <summary>
        /// Validates the data contained in the DTO and throws an exception if there is a problem.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">
        /// Filename cannot be null or empty.
        /// or
        /// Filename is missing extension.
        /// or
        /// PortId cannot be longer than 50 characters.
        /// or
        /// AppOwnerName cannot be longer than 50 characters.
        /// or
        /// Filename cannot be longer than 500 characters.
        /// or
        /// Expiration in days cannot be less than one.
        /// </exception>
        public bool ValidateAndThrow()
        {
            //Nulls
            if (string.IsNullOrEmpty(Filename)) throw new Exception("Filename cannot be null or empty.");

            //Bad format
            if (!Path.HasExtension(Filename)) throw new Exception("Filename is missing extension.");

            //Lengths
            if (string.IsNullOrWhiteSpace(PortId)) PortId = null;
            if (PortId != null && PortId.Length > 50) throw new Exception("PortId cannot be longer than 50 characters.");
            if (AppOwnerName != null && AppOwnerName.Length > 50) throw new Exception("AppOwnerName cannot be longer than 50 characters.");
            if (Filename.Length > 500) throw new Exception("Filename cannot be longer than 500 characters.");

            //Min/max
            if (ExpirationInDays.HasValue && ExpirationInDays.Value <= 0) throw new Exception("Expiration in days cannot be less than one.");

            //Mode
            if (Mode != FileVaultFileMode.ReadOnly && Mode != FileVaultFileMode.ReadWrite && Mode != FileVaultFileMode.PrivateReadOnly && Mode != FileVaultFileMode.PrivateReadWrite)
            {
                throw new Exception("Mode cannot be set to " + Mode);
            }

            //Clean
            Filename = Filename?.Trim();
            PortId = PortId?.Trim();
            AppOwnerName = AppOwnerName?.Trim();

            return true;
        }
    }
}
