=begin
#Manticore Search Client

#Please note that this client is experimental. For full documentation of the API methods consult https://manual.manticoresearch.com/. 

The version of the OpenAPI document: 1.0.0
Contact: info@manticoresearch.com
Generated by: https://openapi-generator.tech
OpenAPI Generator version: 5.0.0-SNAPSHOT

=end

require 'cgi'

module OpenapiClient
  class UtilsApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Perform SQL requests
    # Run a query in SQL format. Expects is a query parameters string that can be in two modes: * Select only query as `query=SELECT * FROM myindex`. The query string MUST be URL encoded * any type of query in format `mode=raw&query=SHOW TABLES`. The string must be as is (no URL encoding) and `mode` must be first. The response object depends on the query executed. In select mode the response has same format as `/search` operation. 
    # @param body [String] Expects is a query parameters string that can be in two modes:    * Select only query as &#x60;query&#x3D;SELECT * FROM myindex&#x60;. The query string MUST be URL encoded    * any type of query in format &#x60;mode&#x3D;raw&amp;query&#x3D;SHOW TABLES&#x60;. The string must be as is (no URL encoding) and &#x60;mode&#x60; must be first. 
    # @param [Hash] opts the optional parameters
    # @return [Hash<String, Object>]
    def sql(body, opts = {})
      data, _status_code, _headers = sql_with_http_info(body, opts)
      data
    end

    # Perform SQL requests
    # Run a query in SQL format. Expects is a query parameters string that can be in two modes: * Select only query as &#x60;query&#x3D;SELECT * FROM myindex&#x60;. The query string MUST be URL encoded * any type of query in format &#x60;mode&#x3D;raw&amp;query&#x3D;SHOW TABLES&#x60;. The string must be as is (no URL encoding) and &#x60;mode&#x60; must be first. The response object depends on the query executed. In select mode the response has same format as &#x60;/search&#x60; operation. 
    # @param body [String] Expects is a query parameters string that can be in two modes:    * Select only query as &#x60;query&#x3D;SELECT * FROM myindex&#x60;. The query string MUST be URL encoded    * any type of query in format &#x60;mode&#x3D;raw&amp;query&#x3D;SHOW TABLES&#x60;. The string must be as is (no URL encoding) and &#x60;mode&#x60; must be first. 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Hash<String, Object>, Integer, Hash)>] Hash<String, Object> data, response status code and response headers
    def sql_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UtilsApi.sql ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling UtilsApi.sql"
      end
      # resource path
      local_var_path = '/sql'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['text/plain'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(body) 

      # return_type
      return_type = opts[:return_type] || 'Hash<String, Object>' 

      # auth_names
      auth_names = opts[:auth_names] || []

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:POST, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UtilsApi#sql\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
