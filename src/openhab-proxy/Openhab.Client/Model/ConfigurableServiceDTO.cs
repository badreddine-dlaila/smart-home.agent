/* 
 * openHAB REST API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Openhab.Client.Model
{
    /// <summary>
    /// ConfigurableServiceDTO
    /// </summary>
    [DataContract]
    public partial class ConfigurableServiceDTO :  IEquatable<ConfigurableServiceDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurableServiceDTO" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="label">label.</param>
        /// <param name="category">category.</param>
        /// <param name="configDescriptionURI">configDescriptionURI.</param>
        /// <param name="multiple">multiple (default to false).</param>
        public ConfigurableServiceDTO(string id = default(string), string label = default(string), string category = default(string), string configDescriptionURI = default(string), bool? multiple = false)
        {
            Id = id;
            Label = label;
            Category = category;
            ConfigDescriptionURI = configDescriptionURI;
            // use default value if no "multiple" provided
            if (multiple == null)
            {
                Multiple = false;
            }
            else
            {
                Multiple = multiple;
            }
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets ConfigDescriptionURI
        /// </summary>
        [DataMember(Name="configDescriptionURI", EmitDefaultValue=false)]
        public string ConfigDescriptionURI { get; set; }

        /// <summary>
        /// Gets or Sets Multiple
        /// </summary>
        [DataMember(Name="multiple", EmitDefaultValue=false)]
        public bool? Multiple { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurableServiceDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ConfigDescriptionURI: ").Append(ConfigDescriptionURI).Append("\n");
            sb.Append("  Multiple: ").Append(Multiple).Append("\n");
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
            return Equals(input as ConfigurableServiceDTO);
        }

        /// <summary>
        /// Returns true if ConfigurableServiceDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigurableServiceDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurableServiceDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    Id == input.Id ||
                    (Id != null &&
                    Id.Equals(input.Id))
                ) && 
                (
                    Label == input.Label ||
                    (Label != null &&
                    Label.Equals(input.Label))
                ) && 
                (
                    Category == input.Category ||
                    (Category != null &&
                    Category.Equals(input.Category))
                ) && 
                (
                    ConfigDescriptionURI == input.ConfigDescriptionURI ||
                    (ConfigDescriptionURI != null &&
                    ConfigDescriptionURI.Equals(input.ConfigDescriptionURI))
                ) && 
                (
                    Multiple == input.Multiple ||
                    (Multiple != null &&
                    Multiple.Equals(input.Multiple))
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
                if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                if (ConfigDescriptionURI != null)
                    hashCode = hashCode * 59 + ConfigDescriptionURI.GetHashCode();
                if (Multiple != null)
                    hashCode = hashCode * 59 + Multiple.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
