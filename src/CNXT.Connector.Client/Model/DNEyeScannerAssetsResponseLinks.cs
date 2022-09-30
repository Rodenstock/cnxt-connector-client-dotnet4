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
    /// DNEyeScannerAssetsResponseLinks
    /// </summary>
    [DataContract]
    public partial class DNEyeScannerAssetsResponseLinks :  IEquatable<DNEyeScannerAssetsResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DNEyeScannerAssetsResponseLinks" /> class.
        /// </summary>
        /// <param name="farMesopicImageRight">farMesopicImageRight.</param>
        /// <param name="farMesopicImageLeft">farMesopicImageLeft.</param>
        /// <param name="farPhotopicImageRight">farPhotopicImageRight.</param>
        /// <param name="farPhotopicImageLeft">farPhotopicImageLeft.</param>
        /// <param name="corneaImageRight">corneaImageRight.</param>
        /// <param name="corneaImageLeft">corneaImageLeft.</param>
        public DNEyeScannerAssetsResponseLinks(DNEyeScannerAssetsResponseLinksFarMesopicImageRight farMesopicImageRight = default(DNEyeScannerAssetsResponseLinksFarMesopicImageRight), DNEyeScannerAssetsResponseLinksFarMesopicImageRight farMesopicImageLeft = default(DNEyeScannerAssetsResponseLinksFarMesopicImageRight), DNEyeScannerAssetsResponseLinksFarMesopicImageRight farPhotopicImageRight = default(DNEyeScannerAssetsResponseLinksFarMesopicImageRight), DNEyeScannerAssetsResponseLinksFarMesopicImageRight farPhotopicImageLeft = default(DNEyeScannerAssetsResponseLinksFarMesopicImageRight), DNEyeScannerAssetsResponseLinksFarMesopicImageRight corneaImageRight = default(DNEyeScannerAssetsResponseLinksFarMesopicImageRight), DNEyeScannerAssetsResponseLinksFarMesopicImageRight corneaImageLeft = default(DNEyeScannerAssetsResponseLinksFarMesopicImageRight))
        {
            this.FarMesopicImageRight = farMesopicImageRight;
            this.FarMesopicImageLeft = farMesopicImageLeft;
            this.FarPhotopicImageRight = farPhotopicImageRight;
            this.FarPhotopicImageLeft = farPhotopicImageLeft;
            this.CorneaImageRight = corneaImageRight;
            this.CorneaImageLeft = corneaImageLeft;
        }

        /// <summary>
        /// Gets or Sets FarMesopicImageRight
        /// </summary>
        [DataMember(Name="farMesopicImageRight", EmitDefaultValue=false)]
        public DNEyeScannerAssetsResponseLinksFarMesopicImageRight FarMesopicImageRight { get; set; }

        /// <summary>
        /// Gets or Sets FarMesopicImageLeft
        /// </summary>
        [DataMember(Name="farMesopicImageLeft", EmitDefaultValue=false)]
        public DNEyeScannerAssetsResponseLinksFarMesopicImageRight FarMesopicImageLeft { get; set; }

        /// <summary>
        /// Gets or Sets FarPhotopicImageRight
        /// </summary>
        [DataMember(Name="farPhotopicImageRight", EmitDefaultValue=false)]
        public DNEyeScannerAssetsResponseLinksFarMesopicImageRight FarPhotopicImageRight { get; set; }

        /// <summary>
        /// Gets or Sets FarPhotopicImageLeft
        /// </summary>
        [DataMember(Name="farPhotopicImageLeft", EmitDefaultValue=false)]
        public DNEyeScannerAssetsResponseLinksFarMesopicImageRight FarPhotopicImageLeft { get; set; }

        /// <summary>
        /// Gets or Sets CorneaImageRight
        /// </summary>
        [DataMember(Name="corneaImageRight", EmitDefaultValue=false)]
        public DNEyeScannerAssetsResponseLinksFarMesopicImageRight CorneaImageRight { get; set; }

        /// <summary>
        /// Gets or Sets CorneaImageLeft
        /// </summary>
        [DataMember(Name="corneaImageLeft", EmitDefaultValue=false)]
        public DNEyeScannerAssetsResponseLinksFarMesopicImageRight CorneaImageLeft { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DNEyeScannerAssetsResponseLinks {\n");
            sb.Append("  FarMesopicImageRight: ").Append(FarMesopicImageRight).Append("\n");
            sb.Append("  FarMesopicImageLeft: ").Append(FarMesopicImageLeft).Append("\n");
            sb.Append("  FarPhotopicImageRight: ").Append(FarPhotopicImageRight).Append("\n");
            sb.Append("  FarPhotopicImageLeft: ").Append(FarPhotopicImageLeft).Append("\n");
            sb.Append("  CorneaImageRight: ").Append(CorneaImageRight).Append("\n");
            sb.Append("  CorneaImageLeft: ").Append(CorneaImageLeft).Append("\n");
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
            return this.Equals(input as DNEyeScannerAssetsResponseLinks);
        }

        /// <summary>
        /// Returns true if DNEyeScannerAssetsResponseLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of DNEyeScannerAssetsResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DNEyeScannerAssetsResponseLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FarMesopicImageRight == input.FarMesopicImageRight ||
                    (this.FarMesopicImageRight != null &&
                    this.FarMesopicImageRight.Equals(input.FarMesopicImageRight))
                ) && 
                (
                    this.FarMesopicImageLeft == input.FarMesopicImageLeft ||
                    (this.FarMesopicImageLeft != null &&
                    this.FarMesopicImageLeft.Equals(input.FarMesopicImageLeft))
                ) && 
                (
                    this.FarPhotopicImageRight == input.FarPhotopicImageRight ||
                    (this.FarPhotopicImageRight != null &&
                    this.FarPhotopicImageRight.Equals(input.FarPhotopicImageRight))
                ) && 
                (
                    this.FarPhotopicImageLeft == input.FarPhotopicImageLeft ||
                    (this.FarPhotopicImageLeft != null &&
                    this.FarPhotopicImageLeft.Equals(input.FarPhotopicImageLeft))
                ) && 
                (
                    this.CorneaImageRight == input.CorneaImageRight ||
                    (this.CorneaImageRight != null &&
                    this.CorneaImageRight.Equals(input.CorneaImageRight))
                ) && 
                (
                    this.CorneaImageLeft == input.CorneaImageLeft ||
                    (this.CorneaImageLeft != null &&
                    this.CorneaImageLeft.Equals(input.CorneaImageLeft))
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
                if (this.FarMesopicImageRight != null)
                    hashCode = hashCode * 59 + this.FarMesopicImageRight.GetHashCode();
                if (this.FarMesopicImageLeft != null)
                    hashCode = hashCode * 59 + this.FarMesopicImageLeft.GetHashCode();
                if (this.FarPhotopicImageRight != null)
                    hashCode = hashCode * 59 + this.FarPhotopicImageRight.GetHashCode();
                if (this.FarPhotopicImageLeft != null)
                    hashCode = hashCode * 59 + this.FarPhotopicImageLeft.GetHashCode();
                if (this.CorneaImageRight != null)
                    hashCode = hashCode * 59 + this.CorneaImageRight.GetHashCode();
                if (this.CorneaImageLeft != null)
                    hashCode = hashCode * 59 + this.CorneaImageLeft.GetHashCode();
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