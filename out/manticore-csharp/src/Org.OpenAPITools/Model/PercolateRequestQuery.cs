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
    /// PercolateRequestQuery
    /// </summary>
    [DataContract]
    public partial class PercolateRequestQuery :  IEquatable<PercolateRequestQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PercolateRequestQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PercolateRequestQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PercolateRequestQuery" /> class.
        /// </summary>
        /// <param name="percolate">percolate (required).</param>
        public PercolateRequestQuery(Object percolate = default(Object))
        {
            // to ensure "percolate" is required (not null)
            if (percolate == null)
            {
                throw new InvalidDataException("percolate is a required property for PercolateRequestQuery and cannot be null");
            }
            else
            {
                this.Percolate = percolate;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets Percolate
        /// </summary>
        [DataMember(Name="percolate", EmitDefaultValue=true)]
        public Object Percolate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PercolateRequestQuery {\n");
            sb.Append("  Percolate: ").Append(Percolate).Append("\n");
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
            return this.Equals(input as PercolateRequestQuery);
        }

        /// <summary>
        /// Returns true if PercolateRequestQuery instances are equal
        /// </summary>
        /// <param name="input">Instance of PercolateRequestQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PercolateRequestQuery input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Percolate == input.Percolate ||
                    (this.Percolate != null &&
                    this.Percolate.Equals(input.Percolate))
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
                if (this.Percolate != null)
                    hashCode = hashCode * 59 + this.Percolate.GetHashCode();
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
            yield break;
        }
    }

}
