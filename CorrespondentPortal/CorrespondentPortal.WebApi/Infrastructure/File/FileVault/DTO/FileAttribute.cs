using System;
using Newtonsoft.Json;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileVault.DTO
{
    public class FileAttribute 
    {
        /// <summary>
        /// A file attribute can be represented as 1 of these enumerated types
        /// </summary>
        public enum FileAttributeType
        {
            /// <summary>
            /// The long
            /// </summary>
            Long,
            /// <summary>
            /// The double
            /// </summary>
            Double,
            /// <summary>
            /// The date time
            /// </summary>
            DateTime,
            /// <summary>
            /// The string
            /// </summary>
            String,
        }

        /// <summary>
        /// Gets or sets the attribute name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the value as a long.
        /// </summary>
        /// <value>
        /// The value long.
        /// </value>
        public long? ValueLong { get; private set; }

        /// <summary>
        /// Gets the value as a double.
        /// </summary>
        /// <value>
        /// The value double.
        /// </value>
        public double? ValueDouble { get; private set; }

        /// <summary>
        /// Gets the value as a date time.
        /// </summary>
        /// <value>
        /// The value date time.
        /// </value>
        public DateTime? ValueDateTime { get; private set; }

        /// <summary>
        /// Gets the value as a string.
        /// </summary>
        /// <value>
        /// The value string.
        /// </value>
        public string ValueString { get; private set; }

        /// <summary>
        /// Gets the enumerated type of the value.
        /// </summary>
        /// <value>
        /// The type of the value.
        /// </value>
        public FileAttributeType ValueType { get; private set; }

        /// <summary>
        /// This constructor is intended to be used by the Newtonsoft.Json library.  It is preferred that devs use one of the other 4 provided constructors.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="valueLong">The value long.</param>
        /// <param name="valueDouble">The value double.</param>
        /// <param name="valueDateTime">The value date time.</param>
        /// <param name="valueString">The value string.</param>
        /// <param name="valueType">Type of the value.</param>
        [JsonConstructor]
        public FileAttribute(string name, long? valueLong, double? valueDouble, DateTime? valueDateTime, string valueString, FileAttributeType valueType)
        {
            Name = Name;
            ValueType = valueType;
            if (ValueType == FileAttributeType.Long)
                ValueLong = valueLong;
            else if (ValueType == FileAttributeType.Double)
                ValueDouble = valueDouble;
            else if (ValueType == FileAttributeType.DateTime)
                ValueDateTime = valueDateTime;
            else
                ValueString = valueString;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public FileAttribute(string name, long value)
        {
            Name = name;
            ValueLong = value;
            ValueType = FileAttributeType.Long;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public FileAttribute(string name, double value)
        {
            Name = name;
            ValueDouble = value;
            ValueType = FileAttributeType.Double;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public FileAttribute(string name, DateTime value)
        {
            Name = name;
            ValueDateTime = value;
            ValueType = FileAttributeType.DateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public FileAttribute(string name, string value)
        {
            Name = name;
            ValueString = value;
            ValueType = FileAttributeType.String;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetValue(long value)
        {
            ValueLong = value;
            ValueDouble = null;
            ValueDateTime = null;
            ValueString = null;
            ValueType = FileAttributeType.Long;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetValue(double value)
        {
            ValueLong = null;
            ValueDouble = value;
            ValueDateTime = null;
            ValueString = null;
            ValueType = FileAttributeType.Double;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetValue(DateTime value)
        {
            ValueLong = null;
            ValueDouble = null;
            ValueDateTime = value;
            ValueString = null;
            ValueType = FileAttributeType.DateTime;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetValue(string value)
        {

            ValueLong = null;
            ValueDouble = null;
            ValueDateTime = null;
            ValueString = value;
            ValueType = FileAttributeType.String;
        }
    }
}
