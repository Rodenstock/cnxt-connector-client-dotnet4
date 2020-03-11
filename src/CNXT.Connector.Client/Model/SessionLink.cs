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
    /// Represents session related pagination links
    /// </summary>
    [DataContract]
    public partial class SessionLink :  IEquatable<SessionLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLink" /> class.
        /// </summary>
        /// <param name="self">self (required).</param>
        /// <param name="session">session.</param>
        /// <param name="patient">patient.</param>
        /// <param name="b2bOptic">b2bOptic.</param>
        public SessionLink(PatientLinkSelf self = default(PatientLinkSelf), SessionLinkSession session = default(SessionLinkSession), SessionLinkPatient patient = default(SessionLinkPatient), SessionLinkB2bOptic b2bOptic = default(SessionLinkB2bOptic))
        {
            // to ensure "self" is required (not null)
            if (self == null)
            {
                throw new InvalidDataException("self is a required property for SessionLink and cannot be null");
            }
            else
            {
                this.Self = self;
            }
            
            this.Session = session;
            this.Patient = patient;
            this.B2bOptic = b2bOptic;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public PatientLinkSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name="session", EmitDefaultValue=false)]
        public SessionLinkSession Session { get; set; }

        /// <summary>
        /// Gets or Sets Patient
        /// </summary>
        [DataMember(Name="patient", EmitDefaultValue=false)]
        public SessionLinkPatient Patient { get; set; }

        /// <summary>
        /// Gets or Sets B2bOptic
        /// </summary>
        [DataMember(Name="b2bOptic", EmitDefaultValue=false)]
        public SessionLinkB2bOptic B2bOptic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionLink {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  Patient: ").Append(Patient).Append("\n");
            sb.Append("  B2bOptic: ").Append(B2bOptic).Append("\n");
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
            return this.Equals(input as SessionLink);
        }

        /// <summary>
        /// Returns true if SessionLink instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionLink input)
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
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
                ) && 
                (
                    this.Patient == input.Patient ||
                    (this.Patient != null &&
                    this.Patient.Equals(input.Patient))
                ) && 
                (
                    this.B2bOptic == input.B2bOptic ||
                    (this.B2bOptic != null &&
                    this.B2bOptic.Equals(input.B2bOptic))
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
                if (this.Session != null)
                    hashCode = hashCode * 59 + this.Session.GetHashCode();
                if (this.Patient != null)
                    hashCode = hashCode * 59 + this.Patient.GetHashCode();
                if (this.B2bOptic != null)
                    hashCode = hashCode * 59 + this.B2bOptic.GetHashCode();
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
