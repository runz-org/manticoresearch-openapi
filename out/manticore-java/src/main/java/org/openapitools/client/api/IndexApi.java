/*
 * Manticore Search API
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: adrian.nuta@manticoresearch.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.api;

import org.openapitools.client.ApiCallback;
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.ApiResponse;
import org.openapitools.client.Configuration;
import org.openapitools.client.Pair;
import org.openapitools.client.ProgressRequestBody;
import org.openapitools.client.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import org.openapitools.client.model.DeleteDocumentRequest;
import org.openapitools.client.model.ErrorResponse;
import org.openapitools.client.model.InsertDocumentRequest;
import org.openapitools.client.model.SuccessResponse;
import org.openapitools.client.model.UpdateDocumentRequest;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class IndexApi {
    private ApiClient localVarApiClient;

    public IndexApi() {
        this(Configuration.getDefaultApiClient());
    }

    public IndexApi(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return localVarApiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    /**
     * Build call for bulk
     * @param body  (required)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Bulk index operations Documentation</a>
     */
    public okhttp3.Call bulkCall(Object body, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = body;

        // create path and map variables
        String localVarPath = "/json/bulk";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            "application/x-ndjson"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] {  };
        return localVarApiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call bulkValidateBeforeCall(Object body, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling bulk(Async)");
        }
        

        okhttp3.Call localVarCall = bulkCall(body, _callback);
        return localVarCall;

    }

    /**
     * Bulk index operations
     * 
     * @param body  (required)
     * @return SuccessResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Bulk index operations Documentation</a>
     */
    public SuccessResponse bulk(Object body) throws ApiException {
        ApiResponse<SuccessResponse> localVarResp = bulkWithHttpInfo(body);
        return localVarResp.getData();
    }

    /**
     * Bulk index operations
     * 
     * @param body  (required)
     * @return ApiResponse&lt;SuccessResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Bulk index operations Documentation</a>
     */
    public ApiResponse<SuccessResponse> bulkWithHttpInfo(Object body) throws ApiException {
        okhttp3.Call localVarCall = bulkValidateBeforeCall(body, null);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    /**
     * Bulk index operations (asynchronously)
     * 
     * @param body  (required)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Bulk index operations Documentation</a>
     */
    public okhttp3.Call bulkAsync(Object body, final ApiCallback<SuccessResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = bulkValidateBeforeCall(body, _callback);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }
    /**
     * Build call for delete
     * @param deleteDocumentRequest  (required)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Delete a document in an index Documentation</a>
     */
    public okhttp3.Call deleteCall(DeleteDocumentRequest deleteDocumentRequest, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = deleteDocumentRequest;

        // create path and map variables
        String localVarPath = "/json/delete";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] {  };
        return localVarApiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call deleteValidateBeforeCall(DeleteDocumentRequest deleteDocumentRequest, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'deleteDocumentRequest' is set
        if (deleteDocumentRequest == null) {
            throw new ApiException("Missing the required parameter 'deleteDocumentRequest' when calling delete(Async)");
        }
        

        okhttp3.Call localVarCall = deleteCall(deleteDocumentRequest, _callback);
        return localVarCall;

    }

    /**
     * Delete a document in an index
     * 
     * @param deleteDocumentRequest  (required)
     * @return SuccessResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Delete a document in an index Documentation</a>
     */
    public SuccessResponse delete(DeleteDocumentRequest deleteDocumentRequest) throws ApiException {
        ApiResponse<SuccessResponse> localVarResp = deleteWithHttpInfo(deleteDocumentRequest);
        return localVarResp.getData();
    }

    /**
     * Delete a document in an index
     * 
     * @param deleteDocumentRequest  (required)
     * @return ApiResponse&lt;SuccessResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Delete a document in an index Documentation</a>
     */
    public ApiResponse<SuccessResponse> deleteWithHttpInfo(DeleteDocumentRequest deleteDocumentRequest) throws ApiException {
        okhttp3.Call localVarCall = deleteValidateBeforeCall(deleteDocumentRequest, null);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    /**
     * Delete a document in an index (asynchronously)
     * 
     * @param deleteDocumentRequest  (required)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Delete a document in an index Documentation</a>
     */
    public okhttp3.Call deleteAsync(DeleteDocumentRequest deleteDocumentRequest, final ApiCallback<SuccessResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = deleteValidateBeforeCall(deleteDocumentRequest, _callback);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }
    /**
     * Build call for insert
     * @param insertDocumentRequest  (required)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_insert.html">Create a new document in an index Documentation</a>
     */
    public okhttp3.Call insertCall(InsertDocumentRequest insertDocumentRequest, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = insertDocumentRequest;

        // create path and map variables
        String localVarPath = "/json/insert";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] {  };
        return localVarApiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call insertValidateBeforeCall(InsertDocumentRequest insertDocumentRequest, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'insertDocumentRequest' is set
        if (insertDocumentRequest == null) {
            throw new ApiException("Missing the required parameter 'insertDocumentRequest' when calling insert(Async)");
        }
        

        okhttp3.Call localVarCall = insertCall(insertDocumentRequest, _callback);
        return localVarCall;

    }

    /**
     * Create a new document in an index
     * 
     * @param insertDocumentRequest  (required)
     * @return SuccessResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_insert.html">Create a new document in an index Documentation</a>
     */
    public SuccessResponse insert(InsertDocumentRequest insertDocumentRequest) throws ApiException {
        ApiResponse<SuccessResponse> localVarResp = insertWithHttpInfo(insertDocumentRequest);
        return localVarResp.getData();
    }

    /**
     * Create a new document in an index
     * 
     * @param insertDocumentRequest  (required)
     * @return ApiResponse&lt;SuccessResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_insert.html">Create a new document in an index Documentation</a>
     */
    public ApiResponse<SuccessResponse> insertWithHttpInfo(InsertDocumentRequest insertDocumentRequest) throws ApiException {
        okhttp3.Call localVarCall = insertValidateBeforeCall(insertDocumentRequest, null);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    /**
     * Create a new document in an index (asynchronously)
     * 
     * @param insertDocumentRequest  (required)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_insert.html">Create a new document in an index Documentation</a>
     */
    public okhttp3.Call insertAsync(InsertDocumentRequest insertDocumentRequest, final ApiCallback<SuccessResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = insertValidateBeforeCall(insertDocumentRequest, _callback);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }
    /**
     * Build call for replace
     * @param insertDocumentRequest  (required)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_insert.html">Replace new document in an index Documentation</a>
     */
    public okhttp3.Call replaceCall(InsertDocumentRequest insertDocumentRequest, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = insertDocumentRequest;

        // create path and map variables
        String localVarPath = "/json/replace";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] {  };
        return localVarApiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call replaceValidateBeforeCall(InsertDocumentRequest insertDocumentRequest, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'insertDocumentRequest' is set
        if (insertDocumentRequest == null) {
            throw new ApiException("Missing the required parameter 'insertDocumentRequest' when calling replace(Async)");
        }
        

        okhttp3.Call localVarCall = replaceCall(insertDocumentRequest, _callback);
        return localVarCall;

    }

    /**
     * Replace new document in an index
     * 
     * @param insertDocumentRequest  (required)
     * @return SuccessResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_insert.html">Replace new document in an index Documentation</a>
     */
    public SuccessResponse replace(InsertDocumentRequest insertDocumentRequest) throws ApiException {
        ApiResponse<SuccessResponse> localVarResp = replaceWithHttpInfo(insertDocumentRequest);
        return localVarResp.getData();
    }

    /**
     * Replace new document in an index
     * 
     * @param insertDocumentRequest  (required)
     * @return ApiResponse&lt;SuccessResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_insert.html">Replace new document in an index Documentation</a>
     */
    public ApiResponse<SuccessResponse> replaceWithHttpInfo(InsertDocumentRequest insertDocumentRequest) throws ApiException {
        okhttp3.Call localVarCall = replaceValidateBeforeCall(insertDocumentRequest, null);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    /**
     * Replace new document in an index (asynchronously)
     * 
     * @param insertDocumentRequest  (required)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> OK </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_insert.html">Replace new document in an index Documentation</a>
     */
    public okhttp3.Call replaceAsync(InsertDocumentRequest insertDocumentRequest, final ApiCallback<SuccessResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = replaceValidateBeforeCall(insertDocumentRequest, _callback);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }
    /**
     * Build call for update
     * @param updateDocumentRequest  (required)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Update a document in an index Documentation</a>
     */
    public okhttp3.Call updateCall(UpdateDocumentRequest updateDocumentRequest, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = updateDocumentRequest;

        // create path and map variables
        String localVarPath = "/json/update";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] {  };
        return localVarApiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call updateValidateBeforeCall(UpdateDocumentRequest updateDocumentRequest, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'updateDocumentRequest' is set
        if (updateDocumentRequest == null) {
            throw new ApiException("Missing the required parameter 'updateDocumentRequest' when calling update(Async)");
        }
        

        okhttp3.Call localVarCall = updateCall(updateDocumentRequest, _callback);
        return localVarCall;

    }

    /**
     * Update a document in an index
     * 
     * @param updateDocumentRequest  (required)
     * @return SuccessResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Update a document in an index Documentation</a>
     */
    public SuccessResponse update(UpdateDocumentRequest updateDocumentRequest) throws ApiException {
        ApiResponse<SuccessResponse> localVarResp = updateWithHttpInfo(updateDocumentRequest);
        return localVarResp.getData();
    }

    /**
     * Update a document in an index
     * 
     * @param updateDocumentRequest  (required)
     * @return ApiResponse&lt;SuccessResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Update a document in an index Documentation</a>
     */
    public ApiResponse<SuccessResponse> updateWithHttpInfo(UpdateDocumentRequest updateDocumentRequest) throws ApiException {
        okhttp3.Call localVarCall = updateValidateBeforeCall(updateDocumentRequest, null);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        return localVarApiClient.execute(localVarCall, localVarReturnType);
    }

    /**
     * Update a document in an index (asynchronously)
     * 
     * @param updateDocumentRequest  (required)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td> item updated </td><td>  -  </td></tr>
        <tr><td> 0 </td><td> error </td><td>  -  </td></tr>
     </table>
     * 
     * @see <a href="https://docs.manticoresearch.com/latest/html/http_reference/json_update.html">Update a document in an index Documentation</a>
     */
    public okhttp3.Call updateAsync(UpdateDocumentRequest updateDocumentRequest, final ApiCallback<SuccessResponse> _callback) throws ApiException {

        okhttp3.Call localVarCall = updateValidateBeforeCall(updateDocumentRequest, _callback);
        Type localVarReturnType = new TypeToken<SuccessResponse>(){}.getType();
        localVarApiClient.executeAsync(localVarCall, localVarReturnType, _callback);
        return localVarCall;
    }
}
