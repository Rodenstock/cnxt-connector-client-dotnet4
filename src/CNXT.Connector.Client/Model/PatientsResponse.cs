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
    /// Represents a patients response
    /// </summary>
    [DataContract]
    public partial class PatientsResponse :  IEquatable<PatientsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientsResponse" /> class.
        /// </summary>
        /// <param name="patients">patients.</param>
        /// <param name="links">links.</param>
        /// <param name="pageInfo">pageInfo.</param>
        public PatientsResponse(List<PatientResponse> patients = default(List<PatientResponse>), PaginationLink links = default(PaginationLink), PageInfo pageInfo = default(PageInfo))
        {
            this.Patients = patients;
            this.Links = links;
            this.PageInfo = pageInfo;
        }

        /// <summary>
        /// Gets or Sets Patients
        /// </summary>
        [DataMember(Name="patients", EmitDefaultValue=false)]
        public List<PatientResponse> Patients { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public PaginationLink Links { get; set; }

        /// <summary>
        /// Gets or Sets PageInfo
        /// </summary>
        [DataMember(Name="pageInfo", EmitDefaultValue=false)]
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PatientsResponse {\n");
            sb.Append("  Patients: ").Append(Patients).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  PageInfo: ").Append(PageInfo).Append("\n");
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
            return this.Equals(input as PatientsResponse);
        }

        /// <summary>
        /// Returns true if PatientsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PatientsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatientsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Patients == input.Patients ||
                    this.Patients != null &&
                    input.Patients != null &&
                    this.Patients.SequenceEqual(input.Patients)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.Patients != null)
                    hashCode = hashCode * 59 + this.Patients.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
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
