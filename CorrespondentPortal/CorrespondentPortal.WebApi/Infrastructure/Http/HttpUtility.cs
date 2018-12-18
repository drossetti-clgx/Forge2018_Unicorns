using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CorrespondentPortal.WebApi.Infrastructure.Http
{
    public class HttpUtility : IHttpUtility
    {
        public async Task<HttpFragileOperationResult<T>> HttpPostJsonAsync<T>(string url, object requestObject, IEnumerable<KeyValuePair<string, string>> headers = null, JsonSerializerSettings serializerSettings = null)
        {
            var serializedObject = JsonConvert.SerializeObject(requestObject);
            HttpContent content = new StringContent(serializedObject, Encoding.UTF8, "application/json");

            return await HttpPostContentAsync<T>(url, content, headers).ConfigureAwait(false);
        }

        public async Task<HttpFragileOperation> HttpPostJsonAsync(string url, object requestObject, IEnumerable<KeyValuePair<string, string>> headers = null)
        {
            var serializedObject = JsonConvert.SerializeObject(requestObject);
            HttpContent content = new StringContent(serializedObject, Encoding.UTF8, "application/json");

            return await HttpPostContentAsync(url, content, headers).ConfigureAwait(false);
        }

        public async Task<HttpFragileOperation> HttpPostContentAsync(string url, HttpContent httpContent, IEnumerable<KeyValuePair<string, string>> headers = null)
        {
            async Task<HttpFragileOperation> Function(HttpClient client) => await ConvertHttpResponseMessageToHttpResult(await client.PostAsync(url, httpContent).ConfigureAwait(false));
            return await HttpClientExceptionHandlerAsync(Function, headers).ConfigureAwait(false);
        }

        public async Task<HttpFragileOperationResult<T>> HttpPostContentAsync<T>(string url, HttpContent httpContent, IEnumerable<KeyValuePair<string, string>> headers = null, JsonSerializerSettings serializerSettings = null)
        {
            async Task<HttpFragileOperationResult<T>> Function(HttpClient client) => await ConvertHttpResponseMessageToHttpDeserializedResult<T>(await client.PostAsync(url, httpContent).ConfigureAwait(false), serializerSettings);
            return await HttpClientExceptionHandler(Function, headers).ConfigureAwait(false);
        }

        public async Task<HttpFragileOperationResult<T>> HttpGetAsync<T>(string url, IEnumerable<KeyValuePair<string, string>> headers = null, JsonSerializerSettings serializerSettings = null)
        {
            async Task<HttpFragileOperationResult<T>> Function(HttpClient client) => await ConvertHttpResponseMessageToHttpDeserializedResult<T>(await client.GetAsync(url).ConfigureAwait(false), serializerSettings);
            return await HttpClientExceptionHandler(Function, headers).ConfigureAwait(false);
        }

        public async Task<HttpFragileOperation> HttpGetAsync(string url, IEnumerable<KeyValuePair<string, string>> headers = null)
        {
            async Task<HttpFragileOperation> Function(HttpClient client) => await ConvertHttpResponseMessageToHttpResult(await client.GetAsync(url).ConfigureAwait(false));
            return await HttpClientExceptionHandlerAsync(Function, headers).ConfigureAwait(false);
        }

        private static async Task<HttpFragileOperationResult<T>> HttpClientExceptionHandler<T>(Func<HttpClient, Task<HttpFragileOperationResult<T>>> function, IEnumerable<KeyValuePair<string, string>> headers = null)
        {
            using (var client = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                try
                {
                    return await function(client).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    return HttpFragileOperationResult<T>.CreateErrorResult(HttpStatusCode.InternalServerError, "", $"An exception occured while making the request. Exception: {e}");
                }
            }
        }

        private static async Task<HttpFragileOperation> HttpClientExceptionHandlerAsync(Func<HttpClient, Task<HttpFragileOperation>> function, IEnumerable<KeyValuePair<string, string>> headers = null)
        {
            using (var client = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                try
                {
                    return await function(client).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    return HttpFragileOperation.CreateErrorResult(HttpStatusCode.InternalServerError, "", $"An exception occured while making the request. Exception: {e}");
                }
            }
        }

        private static async Task<HttpFragileOperation> ConvertHttpResponseMessageToHttpResult(HttpResponseMessage httpResponseMessage)
        {
            var stringResult = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var statusCode = httpResponseMessage.StatusCode;
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return HttpFragileOperation.CreateSuccessfulResult(statusCode, stringResult);
            }

            if ((int)statusCode >= 500)
            {
                return HttpFragileOperation.CreateErrorResult(statusCode, stringResult, $"500+ error result. StatusCode: {statusCode}. Response: {stringResult}");
            }

            return HttpFragileOperation.CreateFailedResult(statusCode, stringResult, $"Non-500+ error result. StatusCode: {statusCode}. Response: {stringResult}");
        }

        private static async Task<HttpFragileOperationResult<T>> ConvertHttpResponseMessageToHttpDeserializedResult<T>(HttpResponseMessage httpResponseMessage, JsonSerializerSettings serializerSettings = null)
        {
            var stringResult = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            var statusCode = httpResponseMessage.StatusCode;

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                try
                {
                    var deserializedObject = serializerSettings == null ? JsonConvert.DeserializeObject<T>(stringResult) : JsonConvert.DeserializeObject<T>(stringResult, serializerSettings);
                    return HttpFragileOperationResult<T>.CreateSuccessfulResult(deserializedObject, statusCode, stringResult);
                }
                catch (JsonException e)
                {
                    //Log in infrastructure Logs
                    return HttpFragileOperationResult<T>.CreateErrorResult(statusCode, stringResult, $"Unable to deserialize 200 result. Type: {typeof(T)}. Result: {stringResult}. Exception {e}.");
                }
            }

            if ((int)statusCode >= 500)
            {
                return HttpFragileOperationResult<T>.CreateErrorResult(statusCode, stringResult, $"500+ error result. StatusCode: {statusCode}. Response: {stringResult}");
            }

            return HttpFragileOperationResult<T>.CreateFailedResult(statusCode, stringResult, $"Non-500+ error result. StatusCode: {statusCode}. Response: {stringResult}");
        }
    }
}
