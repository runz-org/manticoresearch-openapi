/*
 * Manticore Search Client
 *
 * Сlient for Manticore Search. 
 *
 * The version of the OpenAPI document: 3.3.0
 * Contact: info@manticoresearch.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ManticoreSearch.Client.FileParameter;
using OpenAPIDateConverter = ManticoreSearch.Client.OpenAPIDateConverter;

namespace ManticoreSearch.Model
{
    /// <summary>
    /// Query match expression with logical operator
    /// </summary>
    [DataContract(Name = "matchOp")]
    public partial class MatchOp : IEquatable<MatchOp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchOp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MatchOp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchOp" /> class.
        /// </summary>
        /// <param name="queryInfo">queryInfo (required).</param>
        public MatchOp(Object queryInfo = default(Object))
        {
            // to ensure "queryInfo" is required (not null)
            if (queryInfo == null)
            {
                throw new ArgumentNullException("queryInfo is a required property for MatchOp and cannot be null");
            }
            this.QueryInfo = queryInfo;
        }

        /// <summary>
        /// Gets or Sets QueryInfo
        /// </summary>
        [DataMember(Name = "query_info", IsRequired = true, EmitDefaultValue = false)]
        public Object QueryInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchOp {\n");
            sb.Append("  QueryInfo: ").Append(QueryInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MatchOp);
        }

        /// <summary>
        /// Returns true if MatchOp instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchOp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchOp input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QueryInfo == input.QueryInfo ||
                    (this.QueryInfo != null &&
                    this.QueryInfo.Equals(input.QueryInfo))
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
                if (this.QueryInfo != null)
                {
                    hashCode = (hashCode * 59) + this.QueryInfo.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
