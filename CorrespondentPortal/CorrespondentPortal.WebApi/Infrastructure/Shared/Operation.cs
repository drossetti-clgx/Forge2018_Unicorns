using System.Collections.Generic;
using System.Linq;

namespace CorrespondentPortal.WebApi.Infrastructure.Shared
{
    public class Operation
    {
        public bool OperationSuccessful { get; }
        public IEnumerable<string> ErrorMessages { get; }

        protected Operation(bool operationSuccessful, IEnumerable<string> errorMessages = null)
        {
            OperationSuccessful = operationSuccessful;
            ErrorMessages = errorMessages ?? new string[] { };
        }

        protected Operation(bool operationSuccessful, string errorMessage) : this(operationSuccessful, new[] { errorMessage })
        {

        }

        public static Operation CreateSuccessfulOperation()
        {
            return new Operation(true);
        }

        public static Operation CreateErrorOperation(string errorMessage)
        {
            return new Operation(false, errorMessage);
        }

        public static Operation CreateErrorOperation(IEnumerable<string> errorMessages)
        {
            return new Operation(false, errorMessages);
        }

        public string AggregateErrorMessages()
        {
            return ErrorMessages.Any() ? ErrorMessages.Aggregate((a, b) => $"{a}, {b}") : "";
        }
    }
}
