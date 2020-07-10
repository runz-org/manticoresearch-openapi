/*
 * Manticore Search API
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@manticoresearch.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.api;

import org.openapitools.client.ApiException;
import org.openapitools.client.model.BulkResponse;
import org.openapitools.client.model.DeleteDocumentRequest;
import org.openapitools.client.model.DeleteResponse;
import org.openapitools.client.model.ErrorResponse;
import org.openapitools.client.model.InsertDocumentRequest;
import org.openapitools.client.model.SuccessResponse;
import org.openapitools.client.model.UpdateDocumentRequest;
import org.openapitools.client.model.UpdateResponse;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for IndexApi
 */
@Ignore
public class IndexApiTest {

    private final IndexApi api = new IndexApi();

    
    /**
     * Bulk index operations
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void bulkTest() throws ApiException {
        String body = null;
        BulkResponse response = api.bulk(body);

        // TODO: test validations
    }
    
    /**
     * Delete a document in an index
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void deleteTest() throws ApiException {
        DeleteDocumentRequest deleteDocumentRequest = null;
        DeleteResponse response = api.delete(deleteDocumentRequest);

        // TODO: test validations
    }
    
    /**
     * Create a new document in an index
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void insertTest() throws ApiException {
        InsertDocumentRequest insertDocumentRequest = null;
        SuccessResponse response = api.insert(insertDocumentRequest);

        // TODO: test validations
    }
    
    /**
     * Replace new document in an index
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void replaceTest() throws ApiException {
        InsertDocumentRequest insertDocumentRequest = null;
        SuccessResponse response = api.replace(insertDocumentRequest);

        // TODO: test validations
    }
    
    /**
     * Update a document in an index
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void updateTest() throws ApiException {
        UpdateDocumentRequest updateDocumentRequest = null;
        UpdateResponse response = api.update(updateDocumentRequest);

        // TODO: test validations
    }
    
}
