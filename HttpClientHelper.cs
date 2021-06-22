using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Common.Helpers.HttpClientHelper
{
    public class HttpClientHelper<T,E> : IHttpClientHelper<T, E>
    {
        private  HttpClient Client = new HttpClient();
        
        /// <summary>
        /// For getting a single item from a web api uaing GET
        /// </summary>
        /// <param name="apiUrl">Added to the base address to make the full url of the 
        ///     api get method, e.g. "products/1" to get a product with an id of 1</param>
        /// <param name="cancellationToken"></param>
        /// <returns>The item requested</returns>
        public async Task<T> GetSingleItemRequest(string apiUrl, string accessToken)
        {
            Client = new HttpClient();
            var result = default(T);
            if (!String.IsNullOrEmpty(accessToken))
                Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            var response = await Client.GetAsync(apiUrl).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                if(response.Content.Headers.ContentType.ToString().Contains("image"))
                {
                    result = (T)Convert.ChangeType(response.Content.ReadAsByteArrayAsync().Result, typeof(T)) ;
                }
                else
                { 
                await response.Content.ReadAsStringAsync().ContinueWith(x =>
                    {
                        if (typeof(T).Namespace != "System")
                        {
                            result = JsonConvert.DeserializeObject<T>(x?.Result);
                        }
                        else result = (T)Convert.ChangeType(x?.Result, typeof(T));
                    });
                }
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                response.Content?.Dispose();
                throw new HttpRequestException($"{response.StatusCode}:{content}");
            }
            return result;
        }

        /// <summary>
        /// For getting multiple (or all) items from a web api using GET
        /// </summary>
        /// <param name="apiUrl">Added to the base address to make the full url of the 
        ///     api get method, e.g. "products?page=1" to get page 1 of the products</param>
        /// <param name="cancellationToken"></param>
        /// <returns>The items requested</returns>
        public async Task<T[]> GetMultipleItemsRequest(string apiUrl, string accessToken)
        {
            Client = new HttpClient();
            T[] result = null;
            if (!String.IsNullOrEmpty(accessToken))
                Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer ", accessToken);
            var response = await Client.GetAsync(apiUrl).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                {
                    result = JsonConvert.DeserializeObject<T[]>(x.Result);
                });
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                response.Content?.Dispose();
                throw new HttpRequestException($"{response.StatusCode}:{content}");
            }
            return result;
        }

        /// <summary>
        /// For creating a new item over a web api using POST
        /// </summary>
        /// <param name="apiUrl">Added to the base address to make the full url of the 
        ///     api post method, e.g. "products" to add products</param>
        /// <param name="postObject">The object to be created</param>
        /// <param name="cancellationToken"></param>
        /// <returns>The item created</returns>
        /// 
        public async Task<T> PostRequest(string apiUrl, E postObject, string mediaType, string accessToken)
        {
            Client = new HttpClient();
            T result = default(T);
            FormUrlEncodedContent serialized = null;
            StringContent stringContent = new StringContent("");
           
            try {
              HttpResponseMessage httpResponseMessage = null;
                Client.BaseAddress = new Uri(apiUrl);
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Add("User-Agent", "e-Modal");
                if (!String.IsNullOrEmpty(accessToken))
                    Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer ", accessToken);
               
                if(mediaType.Equals(MediaTypeEnum.ApplicationWwwFormUrlEncoded.Code))
                {
                    Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeEnum.ApplicationWwwFormUrlEncoded.Code));
                    var dictionary = JObject.FromObject(postObject).ToObject<Dictionary<string, string>>();
                    serialized = new FormUrlEncodedContent(dictionary);
                    httpResponseMessage = await Client.PostAsync(apiUrl, serialized).ConfigureAwait(false);
                }
                else if(mediaType.Equals(MediaTypeEnum.ApplicationJson.Code))
                {

                    stringContent = new StringContent(JsonConvert.SerializeObject(postObject), Encoding.UTF8, MediaTypeEnum.ApplicationWwwFormUrlEncoded.Code);
                    httpResponseMessage = await Client.PostAsync(apiUrl, serialized).ConfigureAwait(false);

                }
                

            
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                await httpResponseMessage.Content.ReadAsStringAsync().ContinueWith((Task<string> x) =>
                {
                    result = JsonConvert.DeserializeObject<T>(x.Result);
                });
            }
            else
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                    httpResponseMessage.Content?.Dispose();
                throw new HttpRequestException($"{httpResponseMessage.StatusCode}:{content}");
            }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return result;
        }

        /// <summary>
        /// For updating an existing item over a web api using PUT
        /// </summary>
        /// <param name="apiUrl">Added to the base address to make the full url of the 
        ///     api put method, e.g. "products/3" to update product with id of 3</param>
        /// <param name="putObject">The object to be edited</param>
        /// <param name="cancellationToken"></param>
        public async Task PutRequest(string apiUrl, E putObject, string accessToken)
        {
            var serialized = new StringContent(JsonConvert.SerializeObject(putObject), Encoding.UTF8, "application/json");
            if (!String.IsNullOrEmpty(accessToken))
                Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer ", accessToken);
            var response = await Client.PutAsync(apiUrl, serialized).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                response.Content?.Dispose();
                throw new HttpRequestException($"{response.StatusCode}:{content}");
            }
        }

        /// <summary>
        /// For deleting an existing item over a web api using DELETE
        /// </summary>
        /// <param name="apiUrl">Added to the base address to make the full url of the 
        ///     api delete method, e.g. "products/3" to delete product with id of 3</param>
        /// <param name="cancellationToken"></param>
        public async Task DeleteRequest(string apiUrl, string accessToken)
        {
            if (!String.IsNullOrEmpty(accessToken))
                Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer ", accessToken);
            var response = await Client.DeleteAsync(apiUrl).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                response.Content?.Dispose();
                throw new HttpRequestException($"{response.StatusCode}:{content}");
            }
        }
    }
}
