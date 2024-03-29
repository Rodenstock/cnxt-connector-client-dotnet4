/*
 * CNXT-API
 *
 * The CNXT-API is developed by Rodenstock GmbH to integrate data from measurement devices such as DNEye<sup>®</sup> Scanner, Rodenstock Fundus Scanner, and ImpressionIST<sup>®</sup> into 3rd party applications as well as into several applications of Rodenstock such as WinFit, Rodenstock Consulting etc. If you have any feedback then please feel free to contact us via email. Copyright © Rodenstock GmbH 2022
 *
 * The version of the OpenAPI document: 1.5.0
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
    /// Represents a session
    /// </summary>
    [DataContract]
    public partial class SessionInput :  IEquatable<SessionInput>, IValidatableObject
    {
        /// <summary>
        /// State of the session. (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED)
        /// </summary>
        /// <value>State of the session. (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum CLOSED for value: CLOSED
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED = 1,

            /// <summary>
            /// Enum OPEN for value: OPEN
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN = 2,

            /// <summary>
            /// Enum ORDERED for value: ORDERED
            /// </summary>
            [EnumMember(Value = "ORDERED")]
            ORDERED = 3,

            /// <summary>
            /// Enum EXPORTED for value: EXPORTED
            /// </summary>
            [EnumMember(Value = "EXPORTED")]
            EXPORTED = 4,

            /// <summary>
            /// Enum SAVED for value: SAVED
            /// </summary>
            [EnumMember(Value = "SAVED")]
            SAVED = 5

        }

        /// <summary>
        /// State of the session. (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED)
        /// </summary>
        /// <value>State of the session. (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED)</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInput" /> class.
        /// </summary>
        /// <param name="externalId">External ID of the session which is assigned to the session in a 3rd party application.</param>
        /// <param name="name">Name of the session.</param>
        /// <param name="notes">Notes of the session.</param>
        /// <param name="state">State of the session. (Supported values: OPEN, CLOSED, ORDERED, EXPORTED, SAVED).</param>
        /// <param name="patientId">Patient ID associated with the session.</param>
        /// <param name="b2bOptic">b2bOptic.</param>
        public SessionInput(string externalId = default(string), string name = default(string), string notes = default(string), StateEnum? state = default(StateEnum?), string patientId = default(string), B2BOptic b2bOptic = default(B2BOptic))
        {
            this.ExternalId = externalId;
            this.Name = name;
            this.Notes = notes;
            this.State = state;
            this.PatientId = patientId;
            this.B2bOptic = b2bOptic;
        }

        /// <summary>
        /// External ID of the session which is assigned to the session in a 3rd party application
        /// </summary>
        /// <value>External ID of the session which is assigned to the session in a 3rd party application</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Name of the session
        /// </summary>
        /// <value>Name of the session</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Notes of the session
        /// </summary>
        /// <value>Notes of the session</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }


        /// <summary>
        /// Patient ID associated with the session
        /// </summary>
        /// <value>Patient ID associated with the session</value>
        [DataMember(Name="patientId", EmitDefaultValue=false)]
        public string PatientId { get; set; }

        /// <summary>
        /// Gets or Sets B2bOptic
        /// </summary>
        [DataMember(Name="b2bOptic", EmitDefaultValue=false)]
        public B2BOptic B2bOptic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionInput {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PatientId: ").Append(PatientId).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionInput);
        }

        /// <summary>
        /// Returns true if SessionInput instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PatientId == input.PatientId ||
                    (this.PatientId != null &&
                    this.PatientId.Equals(input.PatientId))
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PatientId != null)
                    hashCode = hashCode * 59 + this.PatientId.GetHashCode();
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
