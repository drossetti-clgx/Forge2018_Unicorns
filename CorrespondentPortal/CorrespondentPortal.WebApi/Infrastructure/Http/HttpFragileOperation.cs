using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Http
{
    public class HttpFragileOperation : FragileOperation
    {
        public string ResponseStringContent { get; }

        public HttpStatusCode StatusCode { get; }

        protected HttpFragileOperation(HttpStatusCode statusCode, string responseStringContent, Status status, IEnumerable<string> errorMessages = null) : base(status, errorMessages)
        {
            ResponseStringContent = responseStringContent;
            StatusCode = statusCode;
        }

        protected HttpFragileOperation(HttpStatusCode statusCode, string responseStringContent, Status status, string errorMessage) : base(status, errorMessage)
        {
            ResponseStringContent = responseStringContent;
            StatusCode = statusCode;
        }

        public static HttpFragileOperation CreateSuccessfulResult(HttpStatusCode statusCode, string responseStringContent)
        {
            return new HttpFragileOperation(statusCode, responseStringContent, Status.Success);
        }

        public static HttpFragileOperation CreateFailedResult(HttpStatusCode statusCode, string responseStringContent, IEnumerable<string> errorMessages)
        {
            return new HttpFragileOperation(statusCode, responseStringContent, Status.Failed, errorMessages);
        }

        public static HttpFragileOperation CreateFailedResult(HttpStatusCode statusCode, string responseStringContent, string errorMessage)
        {
            return new HttpFragileOperation(statusCode, responseStringContent, Status.Failed, errorMessage);
        }

        public static HttpFragileOperation CreateErrorResult(HttpStatusCode statusCode, string responseStringContent, IEnumerable<string> errorMessages)
        {
            return new HttpFragileOperation(statusCode, responseStringContent, Status.Error, errorMessages);
        }

        public static HttpFragileOperation CreateErrorResult(HttpStatusCode statusCode, string responseStringContent, string errorMessage)
        {
            return new HttpFragileOperation(statusCode, responseStringContent, Status.Error, errorMessage);
        }

        public HttpFragileOperationResult<T> ToHttpFragileOperationResult<T>(string errorMessage)
        {
            return ToHttpFragileOperationResult<T>(new[] { errorMessage });
        }

        public HttpFragileOperationResult<T> ToHttpFragileOperationResult<T>(IEnumerable<string> errorMessages)
        {
            switch (Status)
            {
                case Status.Error:
                    return HttpFragileOperationResult<T>.CreateErrorResult(StatusCode, ResponseStringContent, errorMessages.Concat(ErrorMessages));
                case Status.Failed:
                    return HttpFragileOperationResult<T>.CreateFailedResult(StatusCode, ResponseStringContent, errorMessages.Concat(ErrorMessages));
                case Status.Success:
                    throw new ArgumentOutOfRangeException();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
