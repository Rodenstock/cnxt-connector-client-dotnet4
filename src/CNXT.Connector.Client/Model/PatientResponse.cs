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
    /// Represents a patient response
    /// </summary>
    [DataContract]
    public partial class PatientResponse :  IEquatable<PatientResponse>, IValidatableObject
    {
        /// <summary>
        /// Gender of the patient (Supported values: Female, Male, Other, Unknown)
        /// </summary>
        /// <value>Gender of the patient (Supported values: Female, Male, Other, Unknown)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            /// <summary>
            /// Enum Female for value: Female
            /// </summary>
            [EnumMember(Value = "Female")]
            Female = 1,

            /// <summary>
            /// Enum Male for value: Male
            /// </summary>
            [EnumMember(Value = "Male")]
            Male = 2,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 3,

            /// <summary>
            /// Enum Unknown for value: Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown = 4

        }

        /// <summary>
        /// Gender of the patient (Supported values: Female, Male, Other, Unknown)
        /// </summary>
        /// <value>Gender of the patient (Supported values: Female, Male, Other, Unknown)</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public GenderEnum? Gender { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PatientResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientResponse" /> class.
        /// </summary>
        /// <param name="id">ID of the patient.</param>
        /// <param name="externalId">External ID of the session which is assigned to the session in a 3rd party application.</param>
        /// <param name="title">Title of the patient.</param>
        /// <param name="firstName">First name of the patient (required).</param>
        /// <param name="lastName">Last name of the patient (required).</param>
        /// <param name="gender">Gender of the patient (Supported values: Female, Male, Other, Unknown).</param>
        /// <param name="dateOfBirth">Date of birth of the patient (required).</param>
        /// <param name="contact">contact.</param>
        /// <param name="latestSessionId">The id of the latest session.</param>
        /// <param name="latestSessionUpdate">Date of the latest session update.</param>
        /// <param name="sessions">Assigned sessions of the patient.</param>
        /// <param name="createdAt">Date of creation of the patient.</param>
        /// <param name="updatedAt">Date of modification of the patient.</param>
        /// <param name="links">links.</param>
        public PatientResponse(string id = default(string), string externalId = default(string), string title = default(string), string firstName = default(string), string lastName = default(string), GenderEnum? gender = default(GenderEnum?), DateTime? dateOfBirth = default(DateTime?), Contact contact = default(Contact), string latestSessionId = default(string), DateTime? latestSessionUpdate = default(DateTime?), List<Session> sessions = default(List<Session>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), PatientLink links = default(PatientLink))
        {
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new InvalidDataException("firstName is a required property for PatientResponse and cannot be null");
            }
            else
            {
                this.FirstName = firstName;
            }

            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new InvalidDataException("lastName is a required property for PatientResponse and cannot be null");
            }
            else
            {
                this.LastName = lastName;
            }

            // to ensure "dateOfBirth" is required (not null)
            if (dateOfBirth == null)
            {
                throw new InvalidDataException("dateOfBirth is a required property for PatientResponse and cannot be null");
            }
            else
            {
                this.DateOfBirth = dateOfBirth;
            }

            this.DateOfBirth = dateOfBirth;
            this.LatestSessionUpdate = latestSessionUpdate;
            this.Id = id;
            this.ExternalId = externalId;
            this.Title = title;
            this.Gender = gender;
            this.Contact = contact;
            this.LatestSessionId = latestSessionId;
            this.LatestSessionUpdate = latestSessionUpdate;
            this.Sessions = sessions;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Links = links;
        }

        /// <summary>
        /// ID of the patient
        /// </summary>
        /// <value>ID of the patient</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// External ID of the patient which is assigned to the patient in a 3rd party application
        /// </summary>
        /// <value>External ID of the patient which is assigned to the patient in a 3rd party application</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Title of the patient
        /// </summary>
        /// <value>Title of the patient</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// First name of the patient
        /// </summary>
        /// <value>First name of the patient</value>
        [DataMember(Name="firstName", EmitDefaultValue=true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the patient
        /// </summary>
        /// <value>Last name of the patient</value>
        [DataMember(Name="lastName", EmitDefaultValue=true)]
        public string LastName { get; set; }


        /// <summary>
        /// Date of birth of the patient
        /// </summary>
        /// <value>Date of birth of the patient</value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// The id of the latest session
        /// </summary>
        /// <value>The id of the latest session</value>
        [DataMember(Name="latestSessionId", EmitDefaultValue=false)]
        public string LatestSessionId { get; set; }

        /// <summary>
        /// Date of the latest session update
        /// </summary>
        /// <value>Date of the latest session update</value>
        [DataMember(Name="latestSessionUpdate", EmitDefaultValue=true)]
        public DateTime? LatestSessionUpdate { get; set; }

        /// <summary>
        /// Assigned sessions of the patient
        /// </summary>
        /// <value>Assigned sessions of the patient</value>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<Session> Sessions { get; set; }

        /// <summary>
        /// Date of creation of the patient
        /// </summary>
        /// <value>Date of creation of the patient</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Date of modification of the patient
        /// </summary>
        /// <value>Date of modification of the patient</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PatientLink Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  LatestSessionId: ").Append(LatestSessionId).Append("\n");
            sb.Append("  LatestSessionUpdate: ").Append(LatestSessionUpdate).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as PatientResponse);
        }

        /// <summary>
        /// Returns true if PatientResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.LatestSessionId == input.LatestSessionId ||
                    (this.LatestSessionId != null &&
                    this.LatestSessionId.Equals(input.LatestSessionId))
                ) && 
                (
                    this.LatestSessionUpdate == input.LatestSessionUpdate ||
                    (this.LatestSessionUpdate != null &&
                    this.LatestSessionUpdate.Equals(input.LatestSessionUpdate))
                ) && 
                (
                    this.Sessions == input.Sessions ||
                    this.Sessions != null &&
                    input.Sessions != null &&
                    this.Sessions.SequenceEqual(input.Sessions)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.LatestSessionId != null)
                    hashCode = hashCode * 59 + this.LatestSessionId.GetHashCode();
                if (this.LatestSessionUpdate != null)
                    hashCode = hashCode * 59 + this.LatestSessionUpdate.GetHashCode();
                if (this.Sessions != null)
                    hashCode = hashCode * 59 + this.Sessions.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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
