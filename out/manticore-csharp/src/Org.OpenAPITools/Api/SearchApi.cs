/* 
 * Manticore Search API
 *
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: adrian.nuta@manticoresearch.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Perform reverse search on a percolate index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percolateRequest"></param>
        /// <returns>SearchResponse</returns>
        SearchResponse Percolate (PercolateRequest percolateRequest);

        /// <summary>
        /// Perform reverse search on a percolate index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percolateRequest"></param>
        /// <returns>ApiResponse of SearchResponse</returns>
        ApiResponse<SearchResponse> PercolateWithHttpInfo (PercolateRequest percolateRequest);
        /// <summary>
        /// Performs a search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>SearchResponse</returns>
        SearchResponse Search (SearchRequest searchRequest);

        /// <summary>
        /// Performs a search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>ApiResponse of SearchResponse</returns>
        ApiResponse<SearchResponse> SearchWithHttpInfo (SearchRequest searchRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Perform reverse search on a percolate index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percolateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of SearchResponse</returns>
        System.Threading.Tasks.Task<SearchResponse> PercolateAsync (PercolateRequest percolateRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Perform reverse search on a percolate index
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percolateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (SearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SearchResponse>> PercolateAsyncWithHttpInfo (PercolateRequest percolateRequest, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Performs a search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of SearchResponse</returns>
        System.Threading.Tasks.Task<SearchResponse> SearchAsync (SearchRequest searchRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Performs a search
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (SearchResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SearchResponse>> SearchAsyncWithHttpInfo (SearchRequest searchRequest, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SearchApi : ISearchApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
        {
            this.Configuration = new Org.OpenAPITools.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// </summary>
        /// <returns></returns>
        public SearchApi()
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.Default;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchApi(Org.OpenAPITools.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Org.OpenAPITools.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Perform reverse search on a percolate index 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percolateRequest"></param>
        /// <returns>SearchResponse</returns>
        public SearchResponse Percolate (PercolateRequest percolateRequest)
        {
             ApiResponse<SearchResponse> localVarResponse = PercolateWithHttpInfo(percolateRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Perform reverse search on a percolate index 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percolateRequest"></param>
        /// <returns>ApiResponse of SearchResponse</returns>
        public ApiResponse<SearchResponse> PercolateWithHttpInfo (PercolateRequest percolateRequest)
        {
            // verify the required parameter 'percolateRequest' is set
            if (percolateRequest == null)
                throw new ApiException(400, "Missing required parameter 'percolateRequest' when calling SearchApi->Percolate");

            var localVarPath = "/json/pq/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (percolateRequest != null && percolateRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(percolateRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = percolateRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Percolate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResponse)));
        }

        /// <summary>
        /// Perform reverse search on a percolate index 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percolateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of SearchResponse</returns>
        public async System.Threading.Tasks.Task<SearchResponse> PercolateAsync (PercolateRequest percolateRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<SearchResponse> localVarResponse = await PercolateAsyncWithHttpInfo(percolateRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Perform reverse search on a percolate index 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="percolateRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (SearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchResponse>> PercolateAsyncWithHttpInfo (PercolateRequest percolateRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'percolateRequest' is set
            if (percolateRequest == null)
                throw new ApiException(400, "Missing required parameter 'percolateRequest' when calling SearchApi->Percolate");

            var localVarPath = "/json/pq/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (percolateRequest != null && percolateRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(percolateRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = percolateRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Percolate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResponse)));
        }

        /// <summary>
        /// Performs a search 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>SearchResponse</returns>
        public SearchResponse Search (SearchRequest searchRequest)
        {
             ApiResponse<SearchResponse> localVarResponse = SearchWithHttpInfo(searchRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performs a search 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <returns>ApiResponse of SearchResponse</returns>
        public ApiResponse<SearchResponse> SearchWithHttpInfo (SearchRequest searchRequest)
        {
            // verify the required parameter 'searchRequest' is set
            if (searchRequest == null)
                throw new ApiException(400, "Missing required parameter 'searchRequest' when calling SearchApi->Search");

            var localVarPath = "/json/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchRequest != null && searchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(searchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResponse)));
        }

        /// <summary>
        /// Performs a search 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of SearchResponse</returns>
        public async System.Threading.Tasks.Task<SearchResponse> SearchAsync (SearchRequest searchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<SearchResponse> localVarResponse = await SearchAsyncWithHttpInfo(searchRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performs a search 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (SearchResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SearchResponse>> SearchAsyncWithHttpInfo (SearchRequest searchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'searchRequest' is set
            if (searchRequest == null)
                throw new ApiException(400, "Missing required parameter 'searchRequest' when calling SearchApi->Search");

            var localVarPath = "/json/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchRequest != null && searchRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(searchRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = searchRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SearchResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (SearchResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResponse)));
        }

    }
}
