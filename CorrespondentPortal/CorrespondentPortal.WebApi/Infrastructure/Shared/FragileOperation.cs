using System.Collections.Generic;
using System.Linq;

namespace CorrespondentPortal.WebApi.Infrastructure.Shared
{
    public class FragileOperation
    {
        public Status Status { get; protected set; }
        public IEnumerable<string> ErrorMessages { get; protected set; }

        protected FragileOperation(Status status, IEnumerable<string> errorMessages = null)
        {
            Status = status;
            ErrorMessages = errorMessages ?? new string[] { };
        }

        protected FragileOperation(Status status, string errorMessage) : this(status, new[] { errorMessage })
        {

        }

        protected FragileOperation(Status status) : this(status, new string[] { })
        {

        }

        public static FragileOperation CreateSuccessfulOperation()
        {
            return new FragileOperation(Status.Success);
        }

        public static FragileOperation CreateFailedOperation(string errorMessage)
        {
            return new FragileOperation(Status.Failed, errorMessage);
        }

        public static FragileOperation CreateFailedOperation(IEnumerable<string> errorMessages)
        {
            return new FragileOperation(Status.Failed, errorMessages);
        }

        public static FragileOperation CreateErrorOperation(string errorMessage)
        {
            return new FragileOperation(Status.Error, errorMessage);
        }

        public static FragileOperation CreateErrorOperation(IEnumerable<string> errorMessages)
        {
            return new FragileOperation(Status.Error, errorMessages);
        }

        public string AggregateErrorMessages()
        {
            return ErrorMessages.Aggregate((a, b) => $"{a}, {b}");
        }
    }
}
