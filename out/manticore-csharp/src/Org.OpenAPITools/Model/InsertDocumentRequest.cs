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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Object with document data. 
    /// </summary>
    [DataContract]
    public partial class InsertDocumentRequest :  IEquatable<InsertDocumentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDocumentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InsertDocumentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InsertDocumentRequest" /> class.
        /// </summary>
        /// <param name="index">Name of the index (required).</param>
        /// <param name="id">Document ID. .</param>
        /// <param name="doc">Object with document data  (required).</param>
        public InsertDocumentRequest(string index = default(string), long id = default(long), Object doc = default(Object))
        {
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new InvalidDataException("index is a required property for InsertDocumentRequest and cannot be null");
            }
            else
            {
                this.Index = index;
            }
            
            // to ensure "doc" is required (not null)
            if (doc == null)
            {
                throw new InvalidDataException("doc is a required property for InsertDocumentRequest and cannot be null");
            }
            else
            {
                this.Doc = doc;
            }
            
            this.Id = id;
        }
        
        /// <summary>
        /// Name of the index
        /// </summary>
        /// <value>Name of the index</value>
        [DataMember(Name="index", EmitDefaultValue=true)]
        public string Index { get; set; }

        /// <summary>
        /// Document ID. 
        /// </summary>
        /// <value>Document ID. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Object with document data 
        /// </summary>
        /// <value>Object with document data </value>
        [DataMember(Name="doc", EmitDefaultValue=true)]
        public Object Doc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InsertDocumentRequest {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Doc: ").Append(Doc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InsertDocumentRequest);
        }

        /// <summary>
        /// Returns true if InsertDocumentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InsertDocumentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InsertDocumentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Doc == input.Doc ||
                    (this.Doc != null &&
                    this.Doc.Equals(input.Doc))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Doc != null)
                    hashCode = hashCode * 59 + this.Doc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

            
            // Id (long) minimum
            if(this.Id < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
