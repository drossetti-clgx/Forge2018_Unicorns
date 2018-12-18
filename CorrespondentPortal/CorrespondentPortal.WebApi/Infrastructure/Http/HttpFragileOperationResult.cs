using System;
using System.Collections.Generic;
using System.Net;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Http
{
    public class HttpFragileOperationResult<T> : HttpFragileOperation 
    {
        public T Result { get; }

        private HttpFragileOperationResult(T result, HttpStatusCode statusCode, string responseStringContent) : base(statusCode, responseStringContent, Status.Success)
        {
            Result = result;
        }

        private HttpFragileOperationResult(HttpStatusCode statusCode, string responseStringContent, Status status, string errorMessage) : base(statusCode, responseStringContent, status, errorMessage)
        {

        }

        private HttpFragileOperationResult(HttpStatusCode statusCode, string responseStringContent, Status status, IEnumerable<string> errorMessages) : base(statusCode, responseStringContent, status, errorMessages)
        {

        }

        public static HttpFragileOperationResult<T> CreateSuccessfulResult(T result, HttpStatusCode statusCode, string responseStringContent)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result), "Object cannot be null");
            }

            return new HttpFragileOperationResult<T>(result, statusCode, responseStringContent);
        }

        public new static HttpFragileOperationResult<T> CreateFailedResult(HttpStatusCode statusCode, string responseStringContent, string errorMessage)
        {
            return new HttpFragileOperationResult<T>(statusCode, responseStringContent, Status.Failed, errorMessage);
        }

        public new static HttpFragileOperationResult<T> CreateFailedResult(HttpStatusCode statusCode, string responseStringContent, IEnumerable<string> errorMessages)
        {
            return new HttpFragileOperationResult<T>(statusCode, responseStringContent, Status.Failed, errorMessages);
        }

        public new static HttpFragileOperationResult<T> CreateErrorResult(HttpStatusCode statusCode, string responseStringContent, string errorMessage)
        {
            return new HttpFragileOperationResult<T>(statusCode, responseStringContent, Status.Error, errorMessage);
        }

        public new static HttpFragileOperationResult<T> CreateErrorResult(HttpStatusCode statusCode, string responseStringContent, IEnumerable<string> errorMessages)
        {
            return new HttpFragileOperationResult<T>(statusCode, responseStringContent, Status.Error, errorMessages);
        }
    }
}
