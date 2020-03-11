/* 
 * CNXT-Connector
 *
 * The CNXT-Connector is developed by Rodenstock GmbH to integrate data from measurement devices such as DNEye<sup>®</sup> Scanner, Rodenstock Fundus Scanner, and ImpressionIST<sup>®</sup> into 3rd party applications as well as into several applications of Rodenstock such as WinFit, Rodenstock Consulting etc. If you have any feedback then please feel free to contact us via email. Copyright © Rodenstock GmbH 2020
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: cnxt@rodenstock.com
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
using OpenAPIDateConverter = CNXT.Connector.Client.Client.OpenAPIDateConverter;

namespace CNXT.Connector.Client.Model
{
    /// <summary>
    /// Represents patient related pagination links
    /// </summary>
    [DataContract]
    public partial class PatientLink :  IEquatable<PatientLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatientLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientLink" /> class.
        /// </summary>
        /// <param name="self">self (required).</param>
        /// <param name="patient">patient.</param>
        /// <param name="sessions">An array of URIs of the associated session resources.</param>
        public PatientLink(PatientLinkSelf self = default(PatientLinkSelf), PatientLinkPatient patient = default(PatientLinkPatient), List<Object> sessions = default(List<Object>))
        {
            // to ensure "self" is required (not null)
            if (self == null)
            {
                throw new InvalidDataException("self is a required property for PatientLink and cannot be null");
            }
            else
            {
                this.Self = self;
            }
            
            this.Patient = patient;
            this.Sessions = sessions;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public PatientLinkSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets Patient
        /// </summary>
        [DataMember(Name="patient", EmitDefaultValue=false)]
        public PatientLinkPatient Patient { get; set; }

        /// <summary>
        /// An array of URIs of the associated session resources
        /// </summary>
        /// <value>An array of URIs of the associated session resources</value>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<Object> Sessions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientLink {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Patient: ").Append(Patient).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
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
            return this.Equals(input as PatientLink);
        }

        /// <summary>
        /// Returns true if PatientLink instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.Patient == input.Patient ||
                    (this.Patient != null &&
                    this.Patient.Equals(input.Patient))
                ) && 
                (
                    this.Sessions == input.Sessions ||
                    this.Sessions != null &&
                    input.Sessions != null &&
                    this.Sessions.SequenceEqual(input.Sessions)
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
                if (this.Self != null)
                    hashCode = hashCode * 59 + this.Self.GetHashCode();
                if (this.Patient != null)
                    hashCode = hashCode * 59 + this.Patient.GetHashCode();
                if (this.Sessions != null)
                    hashCode = hashCode * 59 + this.Sessions.GetHashCode();
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
