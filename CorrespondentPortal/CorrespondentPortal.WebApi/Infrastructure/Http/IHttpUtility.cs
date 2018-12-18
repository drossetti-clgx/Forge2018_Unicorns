using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CorrespondentPortal.WebApi.Infrastructure.Http
{
    public interface IHttpUtility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="httpContent"></param>
        /// <param name="headers"></param>
        /// <param name="serializerSettings"></param>
        /// <returns></returns>
        Task<HttpFragileOperationResult<T>> HttpPostContentAsync<T>(string url, HttpContent httpContent, IEnumerable<KeyValuePair<string, string>> headers = null, JsonSerializerSettings serializerSettings = null);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="requestObject"></param>
        /// <param name="headers"></param>
        /// <param name="serializerSettings"></param>
        /// <returns></returns>
        Task<HttpFragileOperationResult<T>> HttpPostJsonAsync<T>(string url, object requestObject, IEnumerable<KeyValuePair<string, string>> headers = null, JsonSerializerSettings serializerSettings = null);

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="serializerSettings"></param>
        /// <returns></returns>
        Task<HttpFragileOperationResult<T>> HttpGetAsync<T>(string url, IEnumerable<KeyValuePair<string, string>> headers = null, JsonSerializerSettings serializerSettings = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        Task<HttpFragileOperation> HttpGetAsync(string url, IEnumerable<KeyValuePair<string, string>> headers = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="requestObject"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        Task<HttpFragileOperation> HttpPostJsonAsync(string url, object requestObject, IEnumerable<KeyValuePair<string, string>> headers = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="httpContent"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        Task<HttpFragileOperation> HttpPostContentAsync(string url, HttpContent httpContent, IEnumerable<KeyValuePair<string, string>> headers = null);
    }
}