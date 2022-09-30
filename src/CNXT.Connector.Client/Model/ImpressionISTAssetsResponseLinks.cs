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
    /// ImpressionISTAssetsResponseLinks
    /// </summary>
    [DataContract]
    public partial class ImpressionISTAssetsResponseLinks :  IEquatable<ImpressionISTAssetsResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImpressionISTAssetsResponseLinks" /> class.
        /// </summary>
        /// <param name="topImage">topImage.</param>
        /// <param name="bottomImage">bottomImage.</param>
        public ImpressionISTAssetsResponseLinks(DNEyeScannerAssetsResponseLinksFarMesopicImageRight topImage = default(DNEyeScannerAssetsResponseLinksFarMesopicImageRight), DNEyeScannerAssetsResponseLinksFarMesopicImageRight bottomImage = default(DNEyeScannerAssetsResponseLinksFarMesopicImageRight))
        {
            this.TopImage = topImage;
            this.BottomImage = bottomImage;
        }

        /// <summary>
        /// Gets or Sets TopImage
        /// </summary>
        [DataMember(Name="topImage", EmitDefaultValue=false)]
        public DNEyeScannerAssetsResponseLinksFarMesopicImageRight TopImage { get; set; }

        /// <summary>
        /// Gets or Sets BottomImage
        /// </summary>
        [DataMember(Name="bottomImage", EmitDefaultValue=false)]
        public DNEyeScannerAssetsResponseLinksFarMesopicImageRight BottomImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImpressionISTAssetsResponseLinks {\n");
            sb.Append("  TopImage: ").Append(TopImage).Append("\n");
            sb.Append("  BottomImage: ").Append(BottomImage).Append("\n");
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
            return this.Equals(input as ImpressionISTAssetsResponseLinks);
        }

        /// <summary>
        /// Returns true if ImpressionISTAssetsResponseLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of ImpressionISTAssetsResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImpressionISTAssetsResponseLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopImage == input.TopImage ||
                    (this.TopImage != null &&
                    this.TopImage.Equals(input.TopImage))
                ) && 
                (
                    this.BottomImage == input.BottomImage ||
                    (this.BottomImage != null &&
                    this.BottomImage.Equals(input.BottomImage))
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
                if (this.TopImage != null)
                    hashCode = hashCode * 59 + this.TopImage.GetHashCode();
                if (this.BottomImage != null)
                    hashCode = hashCode * 59 + this.BottomImage.GetHashCode();
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
