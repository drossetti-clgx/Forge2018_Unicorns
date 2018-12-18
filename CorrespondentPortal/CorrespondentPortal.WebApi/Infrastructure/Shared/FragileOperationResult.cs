using System;
using System.Collections.Generic;

namespace CorrespondentPortal.WebApi.Infrastructure.Shared
{
    public class FragileOperationResult<T> : FragileOperation
    {
        public T Result { get; }

        private FragileOperationResult(T result) : base(Status.Success)
        {
            Result = result;
        }

        private FragileOperationResult(Status status, string errorMessage) : base(status, new List<string>() { errorMessage })
        {

        }

        private FragileOperationResult(Status status, IEnumerable<string> errorMessages) : base(status, errorMessages)
        {

        }

        public static FragileOperationResult<T> CreateSuccessfulResult(T result)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result), "Object cannot be null");
            }

            return new FragileOperationResult<T>(result);
        }

        public static FragileOperationResult<T> CreateFailedResult(string errorMessage)
        {
            return new FragileOperationResult<T>(Status.Failed, errorMessage);
        }

        public static FragileOperationResult<T> CreateFailedResult(IEnumerable<string> errorMessages)
        {
            return new FragileOperationResult<T>(Status.Failed, errorMessages);
        }

        public static FragileOperationResult<T> CreateErrorResult(string errorMessage)
        {
            return new FragileOperationResult<T>(Status.Error, errorMessage);
        }

        public static FragileOperationResult<T> CreateErrorResult(IEnumerable<string> errorMessages)
        {
            return new FragileOperationResult<T>(Status.Error, errorMessages);
        }
    }
}
