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
    /// Query FACET expression
    /// </summary>
    [DataContract(Name = "facet")]
    public partial class Facet : IEquatable<Facet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Facet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Facet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Facet" /> class.
        /// </summary>
        /// <param name="attr">The name of an attribute to facet (required).</param>
        /// <param name="alias">Facet alias.</param>
        /// <param name="limit">The number of facet values to return.</param>
        public Facet(string attr = default(string), string alias = default(string), int limit = default(int))
        {
            // to ensure "attr" is required (not null)
            if (attr == null)
            {
                throw new ArgumentNullException("attr is a required property for Facet and cannot be null");
            }
            this.Attr = attr;
            this.Alias = alias;
            this.Limit = limit;
        }

        /// <summary>
        /// The name of an attribute to facet
        /// </summary>
        /// <value>The name of an attribute to facet</value>
        [DataMember(Name = "attr", IsRequired = true, EmitDefaultValue = false)]
        public string Attr { get; set; }

        /// <summary>
        /// Facet alias
        /// </summary>
        /// <value>Facet alias</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// The number of facet values to return
        /// </summary>
        /// <value>The number of facet values to return</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Facet {\n");
            sb.Append("  Attr: ").Append(Attr).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return this.Equals(input as Facet);
        }

        /// <summary>
        /// Returns true if Facet instances are equal
        /// </summary>
        /// <param name="input">Instance of Facet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Facet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attr == input.Attr ||
                    (this.Attr != null &&
                    this.Attr.Equals(input.Attr))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
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
                if (this.Attr != null)
                {
                    hashCode = (hashCode * 59) + this.Attr.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Limit.GetHashCode();
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
