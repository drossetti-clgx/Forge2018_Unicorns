using System;
using System.Collections.Generic;

namespace CorrespondentPortal.WebApi.Infrastructure.Shared
{
    public class OperationResult<T> : Operation
    {
        public T Result { get; }

        private OperationResult(T result) : base(true)
        {
            Result = result;
        }

        private OperationResult(bool operationSuccessful, IEnumerable<string> errorMessages = null) : base(operationSuccessful, errorMessages)
        {

        }

        public static OperationResult<T> CreateSuccessfulResult(T result)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result), "Object cannot be null");
            }

            return new OperationResult<T>(result);
        }

        public static OperationResult<T> CreateErrorResult(string errorMessage)
        {
            return new OperationResult<T>(false, new[] { errorMessage });
        }

        public static OperationResult<T> CreateErrorResult(IEnumerable<string> errorMessages)
        {
            return new OperationResult<T>(false, errorMessages);
        }
    }
}
