/*
 * Docker Engine API
 *
 * The Engine API is an HTTP API served by Docker Engine. It is the API the Docker client uses to communicate with the Engine, so everything the Docker client can do can be done with the API.  Most of the client's commands map directly to API endpoints (e.g. `docker ps` is `GET /containers/json`). The notable exception is running containers, which consists of several API calls.  # Errors  The API uses standard HTTP status codes to indicate the success or failure of the API call. The body of the response will be JSON in the following format:  ``` {   \"message\": \"page not found\" } ```  # Versioning  The API is usually changed in each release, so API calls are versioned to ensure that clients don't break. To lock to a specific version of the API, you prefix the URL with its version, for example, call `/v1.30/info` to use the v1.30 version of the `/info` endpoint. If the API version specified in the URL is not supported by the daemon, a HTTP `400 Bad Request` error message is returned.  If you omit the version-prefix, the current version of the API (v1.39) is used. For example, calling `/info` is the same as calling `/v1.39/info`. Using the API without a version-prefix is deprecated and will be removed in a future release.  Engine releases in the near future should support this version of the API, so your client will continue to work even if it is talking to a newer Engine.  The API uses an open schema model, which means server may add extra properties to responses. Likewise, the server will ignore any extra query parameters and request body properties. When you write clients, you need to ignore additional properties in responses to ensure they do not break when talking to newer daemons.   # Authentication  Authentication for registries is handled client side. The client has to send authentication details to various endpoints that need to communicate with registries, such as `POST /images/(name)/push`. These are sent as `X-Registry-Auth` header as a Base64 encoded (JSON) string with the following structure:  ``` {   \"username\": \"string\",   \"password\": \"string\",   \"email\": \"string\",   \"serveraddress\": \"string\" } ```  The `serveraddress` is a domain/IP without a protocol. Throughout this structure, double quotes are required.  If you have already got an identity token from the [`/auth` endpoint](#operation/SystemAuth), you can just pass this instead of credentials:  ``` {   \"identitytoken\": \"9cbaf023786cd7...\" } ```
 *
 * OpenAPI spec version: 1.39
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
using SwaggerDateConverter = VMware.ScriptRuntimeService.Docker.Bindings.Client.SwaggerDateConverter;

namespace VMware.ScriptRuntimeService.Docker.Bindings.Model
{
    /// <summary>
    /// An open port on a container
    /// </summary>
#pragma warning disable CS0472
    [DataContract]
    public partial class Port :  IEquatable<Port>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {

            /// <summary>
            /// Enum Tcp for value: tcp
            /// </summary>
            [EnumMember(Value = "tcp")]
            Tcp = 1,

            /// <summary>
            /// Enum Udp for value: udp
            /// </summary>
            [EnumMember(Value = "udp")]
            Udp = 2,

            /// <summary>
            /// Enum Sctp for value: sctp
            /// </summary>
            [EnumMember(Value = "sctp")]
            Sctp = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Port" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Port() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Port" /> class.
        /// </summary>
        /// <param name="iP">Host IP address that the container&#39;s port is mapped to.</param>
        /// <param name="privatePort">Port on the container (required).</param>
        /// <param name="publicPort">Port exposed on the host.</param>
        /// <param name="type">type (required).</param>
        public Port(string iP = default(string), int? privatePort = default(int?), int? publicPort = default(int?), TypeEnum type = default(TypeEnum))
        {
            // to ensure "privatePort" is required (not null)
            if (privatePort == null)
            {
                throw new InvalidDataException("privatePort is a required property for Port and cannot be null");
            }
            else
            {
                this.PrivatePort = privatePort;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Port and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.IP = iP;
            this.PublicPort = publicPort;
        }

        /// <summary>
        /// Host IP address that the container&#39;s port is mapped to
        /// </summary>
        /// <value>Host IP address that the container&#39;s port is mapped to</value>
        [DataMember(Name="IP", EmitDefaultValue=false)]
        public string IP { get; set; }

        /// <summary>
        /// Port on the container
        /// </summary>
        /// <value>Port on the container</value>
        [DataMember(Name="PrivatePort", EmitDefaultValue=false)]
        public int? PrivatePort { get; set; }

        /// <summary>
        /// Port exposed on the host
        /// </summary>
        /// <value>Port exposed on the host</value>
        [DataMember(Name="PublicPort", EmitDefaultValue=false)]
        public int? PublicPort { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Port {\n");
            sb.Append("  IP: ").Append(IP).Append("\n");
            sb.Append("  PrivatePort: ").Append(PrivatePort).Append("\n");
            sb.Append("  PublicPort: ").Append(PublicPort).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Port);
        }

        /// <summary>
        /// Returns true if Port instances are equal
        /// </summary>
        /// <param name="input">Instance of Port to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Port input)
        {
            if (input == null)
                return false;

            return
                (
                    this.IP == input.IP ||
                    (this.IP != null &&
                    this.IP.Equals(input.IP))
                ) &&
                (
                    this.PrivatePort == input.PrivatePort ||
                    (this.PrivatePort != null &&
                    this.PrivatePort.Equals(input.PrivatePort))
                ) &&
                (
                    this.PublicPort == input.PublicPort ||
                    (this.PublicPort != null &&
                    this.PublicPort.Equals(input.PublicPort))
                ) &&
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.IP != null)
                    hashCode = hashCode * 59 + this.IP.GetHashCode();
                if (this.PrivatePort != null)
                    hashCode = hashCode * 59 + this.PrivatePort.GetHashCode();
                if (this.PublicPort != null)
                    hashCode = hashCode * 59 + this.PublicPort.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
#pragma warning restore CS0472
}
