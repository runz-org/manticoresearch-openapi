/**
 * Manticore Search API
 * This is the API for Manticore Search HTTP protocol 
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: adrian.nuta@manticoresearch.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

import ApiClient from '../ApiClient';

/**
 * The UpdateDocumentRequest model module.
 * @module model/UpdateDocumentRequest
 * @version 1.0.0
 */
class UpdateDocumentRequest {
    /**
     * Constructs a new <code>UpdateDocumentRequest</code>.
     * Payload for update document
     * @alias module:model/UpdateDocumentRequest
     * @param index {String} 
     * @param doc {Object} 
     */
    constructor(index, doc) { 
        
        UpdateDocumentRequest.initialize(this, index, doc);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj, index, doc) { 
        obj['index'] = index;
        obj['doc'] = doc;
    }

    /**
     * Constructs a <code>UpdateDocumentRequest</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/UpdateDocumentRequest} obj Optional instance to populate.
     * @return {module:model/UpdateDocumentRequest} The populated <code>UpdateDocumentRequest</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new UpdateDocumentRequest();

            if (data.hasOwnProperty('index')) {
                obj['index'] = ApiClient.convertToType(data['index'], 'String');
            }
            if (data.hasOwnProperty('doc')) {
                obj['doc'] = ApiClient.convertToType(data['doc'], Object);
            }
            if (data.hasOwnProperty('id')) {
                obj['id'] = ApiClient.convertToType(data['id'], 'Number');
            }
            if (data.hasOwnProperty('query')) {
                obj['query'] = ApiClient.convertToType(data['query'], Object);
            }
        }
        return obj;
    }


}

/**
 * @member {String} index
 */
UpdateDocumentRequest.prototype['index'] = undefined;

/**
 * @member {Object} doc
 */
UpdateDocumentRequest.prototype['doc'] = undefined;

/**
 * @member {Number} id
 */
UpdateDocumentRequest.prototype['id'] = undefined;

/**
 * @member {Object} query
 */
UpdateDocumentRequest.prototype['query'] = undefined;






export default UpdateDocumentRequest;

