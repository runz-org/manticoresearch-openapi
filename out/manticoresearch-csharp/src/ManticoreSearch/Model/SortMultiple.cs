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
    /// Query sort expression for multiple attributes
    /// </summary>
    [DataContract(Name = "sortMultiple")]
    public partial class SortMultiple : IEquatable<SortMultiple>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortMultiple" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SortMultiple() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SortMultiple" /> class.
        /// </summary>
        /// <param name="attrs">attrs (required).</param>
        /// <param name="replace">replace (required).</param>
        public SortMultiple(Dictionary<string, Object> attrs = default(Dictionary<string, Object>), bool replace = default(bool))
        {
            // to ensure "attrs" is required (not null)
            if (attrs == null)
            {
                throw new ArgumentNullException("attrs is a required property for SortMultiple and cannot be null");
            }
            this.Attrs = attrs;
            this.Replace = replace;
        }

        /// <summary>
        /// Gets or Sets Attrs
        /// </summary>
        [DataMember(Name = "attrs", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, Object> Attrs { get; set; }

        /// <summary>
        /// Gets or Sets Replace
        /// </summary>
        [DataMember(Name = "replace", IsRequired = true, EmitDefaultValue = true)]
        public bool Replace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SortMultiple {\n");
            sb.Append("  Attrs: ").Append(Attrs).Append("\n");
            sb.Append("  Replace: ").Append(Replace).Append("\n");
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
            return this.Equals(input as SortMultiple);
        }

        /// <summary>
        /// Returns true if SortMultiple instances are equal
        /// </summary>
        /// <param name="input">Instance of SortMultiple to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortMultiple input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attrs == input.Attrs ||
                    this.Attrs != null &&
                    input.Attrs != null &&
                    this.Attrs.SequenceEqual(input.Attrs)
                ) && 
                (
                    this.Replace == input.Replace ||
                    this.Replace.Equals(input.Replace)
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
                if (this.Attrs != null)
                {
                    hashCode = (hashCode * 59) + this.Attrs.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Replace.GetHashCode();
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
