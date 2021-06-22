using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Helpers.HttpClientHelper
{

    
        public interface IHttpClientHelper<T, E>
        {
            Task<T> GetSingleItemRequest(string apiUrl, string accessToken = default(string));
            Task<T[]> GetMultipleItemsRequest(string apiUrl, string accessToken = default(string));
            Task<T> PostRequest(string apiUrl, E postObject, string mediaType,string accessToken = default(string));
            Task PutRequest(string apiUrl, E putObject, string accessToken = default(string));
            Task DeleteRequest(string apiUrl, string accessToken = default(string));
        }
    
}
