﻿/* 
 * Runspace API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace VMware.ScriptRuntimeService.RunspaceClient.Bindings.Model {
   /// <summary>
   /// ErrorResponse
   /// </summary>
   [DataContract]
   public partial class ErrorResponse : IEquatable<ErrorResponse>, IValidatableObject {
      /// <summary>
      /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
      /// </summary>
      /// <param name="code">code.</param>
      /// <param name="errorMessage">errorMessage.</param>
      /// <param name="details">details.</param>
      public ErrorResponse(int? code = default(int?), string errorMessage = default(string), string details = default(string)) {
         this.Code = code;
         this.ErrorMessage = errorMessage;
         this.Details = details;
      }

      /// <summary>
      /// Gets or Sets Code
      /// </summary>
      [DataMember(Name = "code", EmitDefaultValue = false)]
      public int? Code { get; set; }

      /// <summary>
      /// Gets or Sets ErrorMessage
      /// </summary>
      [DataMember(Name = "error_message", EmitDefaultValue = false)]
      public string ErrorMessage { get; set; }

      /// <summary>
      /// Gets or Sets Details
      /// </summary>
      [DataMember(Name = "details", EmitDefaultValue = false)]
      public string Details { get; set; }

      /// <summary>
      /// Returns the string presentation of the object
      /// </summary>
      /// <returns>String presentation of the object</returns>
      public override string ToString() {
         var sb = new StringBuilder();
         sb.Append("class ErrorResponse {\n");
         sb.Append("  Code: ").Append(Code).Append("\n");
         sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
         sb.Append("  Details: ").Append(Details).Append("\n");
         sb.Append("}\n");
         return sb.ToString();
      }

      /// <summary>
      /// Returns the JSON string presentation of the object
      /// </summary>
      /// <returns>JSON string presentation of the object</returns>
      public virtual string ToJson() {
         return JsonConvert.SerializeObject(this, Formatting.Indented);
      }

      /// <summary>
      /// Returns true if objects are equal
      /// </summary>
      /// <param name="input">Object to be compared</param>
      /// <returns>Boolean</returns>
      public override bool Equals(object input) {
         return this.Equals(input as ErrorResponse);
      }

      /// <summary>
      /// Returns true if ErrorResponse instances are equal
      /// </summary>
      /// <param name="input">Instance of ErrorResponse to be compared</param>
      /// <returns>Boolean</returns>
      public bool Equals(ErrorResponse input) {
         if (input == null)
            return false;

         return
             (
                 this.Code == input.Code ||
                 (this.Code != null &&
                 this.Code.Equals(input.Code))
             ) &&
             (
                 this.ErrorMessage == input.ErrorMessage ||
                 (this.ErrorMessage != null &&
                 this.ErrorMessage.Equals(input.ErrorMessage))
             ) &&
             (
                 this.Details == input.Details ||
                 (this.Details != null &&
                 this.Details.Equals(input.Details))
             );
      }

      /// <summary>
      /// Gets the hash code
      /// </summary>
      /// <returns>Hash code</returns>
      public override int GetHashCode() {
         unchecked // Overflow is fine, just wrap
         {
            int hashCode = 41;
            if (this.Code != null)
               hashCode = hashCode * 59 + this.Code.GetHashCode();
            if (this.ErrorMessage != null)
               hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
            if (this.Details != null)
               hashCode = hashCode * 59 + this.Details.GetHashCode();
            return hashCode;
         }
      }

      /// <summary>
      /// To validate all properties of the instance
      /// </summary>
      /// <param name="validationContext">Validation context</param>
      /// <returns>Validation Result</returns>
      IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext) {
         yield break;
      }
   }
}