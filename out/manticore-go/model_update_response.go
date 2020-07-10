/*
 * Manticore Search API
 *
 * This is the API for Manticore Search HTTP protocol 
 *
 * API version: 1.0.0
 * Contact: info@manticoresearch.com
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package openapi
// UpdateResponse Success response
type UpdateResponse struct {
	Index string `json:"_index,omitempty"`
	Updated int32 `json:"updated,omitempty"`
	Id int64 `json:"_id,omitempty"`
	Result string `json:"result,omitempty"`
}
