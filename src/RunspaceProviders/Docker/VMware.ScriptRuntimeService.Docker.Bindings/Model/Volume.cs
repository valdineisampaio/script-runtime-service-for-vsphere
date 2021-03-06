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
    /// Volume
    /// </summary>
#pragma warning disable CS0472
    [DataContract]
    public partial class Volume :  IEquatable<Volume>, IValidatableObject
    {
        /// <summary>
        /// The level at which the volume exists. Either &#x60;global&#x60; for cluster-wide, or &#x60;local&#x60; for machine level.
        /// </summary>
        /// <value>The level at which the volume exists. Either &#x60;global&#x60; for cluster-wide, or &#x60;local&#x60; for machine level.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            
            /// <summary>
            /// Enum Local for value: local
            /// </summary>
            [EnumMember(Value = "local")]
            Local = 1,
            
            /// <summary>
            /// Enum Global for value: global
            /// </summary>
            [EnumMember(Value = "global")]
            Global = 2
        }

        /// <summary>
        /// The level at which the volume exists. Either &#x60;global&#x60; for cluster-wide, or &#x60;local&#x60; for machine level.
        /// </summary>
        /// <value>The level at which the volume exists. Either &#x60;global&#x60; for cluster-wide, or &#x60;local&#x60; for machine level.</value>
        [DataMember(Name="Scope", EmitDefaultValue=false)]
        public ScopeEnum Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Volume" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Volume() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Volume" /> class.
        /// </summary>
        /// <param name="name">Name of the volume. (required).</param>
        /// <param name="driver">Name of the volume driver used by the volume. (required).</param>
        /// <param name="mountpoint">Mount path of the volume on the host. (required).</param>
        /// <param name="createdAt">Date/Time the volume was created..</param>
        /// <param name="status">Low-level details about the volume, provided by the volume driver. Details are returned as a map with key/value pairs: &#x60;{\&quot;key\&quot;:\&quot;value\&quot;,\&quot;key2\&quot;:\&quot;value2\&quot;}&#x60;.  The &#x60;Status&#x60; field is optional, and is omitted if the volume driver does not support this feature. .</param>
        /// <param name="labels">User-defined key/value metadata. (required).</param>
        /// <param name="scope">The level at which the volume exists. Either &#x60;global&#x60; for cluster-wide, or &#x60;local&#x60; for machine level. (required) (default to ScopeEnum.Local).</param>
        /// <param name="options">The driver specific options used when creating the volume. (required).</param>
        /// <param name="usageData">usageData.</param>
        public Volume(string name = default(string), string driver = default(string), string mountpoint = default(string), string createdAt = default(string), Dictionary<string, Object> status = default(Dictionary<string, Object>), Dictionary<string, string> labels = default(Dictionary<string, string>), ScopeEnum scope = ScopeEnum.Local, Dictionary<string, string> options = default(Dictionary<string, string>), VolumeUsageData usageData = default(VolumeUsageData))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Volume and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "driver" is required (not null)
            if (driver == null)
            {
                throw new InvalidDataException("driver is a required property for Volume and cannot be null");
            }
            else
            {
                this.Driver = driver;
            }
            // to ensure "mountpoint" is required (not null)
            if (mountpoint == null)
            {
                throw new InvalidDataException("mountpoint is a required property for Volume and cannot be null");
            }
            else
            {
                this.Mountpoint = mountpoint;
            }
            // to ensure "labels" is required (not null)
            if (labels == null)
            {
                throw new InvalidDataException("labels is a required property for Volume and cannot be null");
            }
            else
            {
                this.Labels = labels;
            }
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new InvalidDataException("scope is a required property for Volume and cannot be null");
            }
            else
            {
                this.Scope = scope;
            }
            // to ensure "options" is required (not null)
            if (options == null)
            {
                throw new InvalidDataException("options is a required property for Volume and cannot be null");
            }
            else
            {
                this.Options = options;
            }
            this.CreatedAt = createdAt;
            this.Status = status;
            this.UsageData = usageData;
        }
        
        /// <summary>
        /// Name of the volume.
        /// </summary>
        /// <value>Name of the volume.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Name of the volume driver used by the volume.
        /// </summary>
        /// <value>Name of the volume driver used by the volume.</value>
        [DataMember(Name="Driver", EmitDefaultValue=false)]
        public string Driver { get; set; }

        /// <summary>
        /// Mount path of the volume on the host.
        /// </summary>
        /// <value>Mount path of the volume on the host.</value>
        [DataMember(Name="Mountpoint", EmitDefaultValue=false)]
        public string Mountpoint { get; set; }

        /// <summary>
        /// Date/Time the volume was created.
        /// </summary>
        /// <value>Date/Time the volume was created.</value>
        [DataMember(Name="CreatedAt", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Low-level details about the volume, provided by the volume driver. Details are returned as a map with key/value pairs: &#x60;{\&quot;key\&quot;:\&quot;value\&quot;,\&quot;key2\&quot;:\&quot;value2\&quot;}&#x60;.  The &#x60;Status&#x60; field is optional, and is omitted if the volume driver does not support this feature. 
        /// </summary>
        /// <value>Low-level details about the volume, provided by the volume driver. Details are returned as a map with key/value pairs: &#x60;{\&quot;key\&quot;:\&quot;value\&quot;,\&quot;key2\&quot;:\&quot;value2\&quot;}&#x60;.  The &#x60;Status&#x60; field is optional, and is omitted if the volume driver does not support this feature. </value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public Dictionary<string, Object> Status { get; set; }

        /// <summary>
        /// User-defined key/value metadata.
        /// </summary>
        /// <value>User-defined key/value metadata.</value>
        [DataMember(Name="Labels", EmitDefaultValue=false)]
        public Dictionary<string, string> Labels { get; set; }


        /// <summary>
        /// The driver specific options used when creating the volume.
        /// </summary>
        /// <value>The driver specific options used when creating the volume.</value>
        [DataMember(Name="Options", EmitDefaultValue=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// Gets or Sets UsageData
        /// </summary>
        [DataMember(Name="UsageData", EmitDefaultValue=false)]
        public VolumeUsageData UsageData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Volume {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
            sb.Append("  Mountpoint: ").Append(Mountpoint).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  UsageData: ").Append(UsageData).Append("\n");
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
            return this.Equals(input as Volume);
        }

        /// <summary>
        /// Returns true if Volume instances are equal
        /// </summary>
        /// <param name="input">Instance of Volume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Volume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Driver == input.Driver ||
                    (this.Driver != null &&
                    this.Driver.Equals(input.Driver))
                ) && 
                (
                    this.Mountpoint == input.Mountpoint ||
                    (this.Mountpoint != null &&
                    this.Mountpoint.Equals(input.Mountpoint))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    this.Status.SequenceEqual(input.Status)
                ) && 
                (
                    this.Labels == input.Labels ||
                    this.Labels != null &&
                    this.Labels.SequenceEqual(input.Labels)
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.UsageData == input.UsageData ||
                    (this.UsageData != null &&
                    this.UsageData.Equals(input.UsageData))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Driver != null)
                    hashCode = hashCode * 59 + this.Driver.GetHashCode();
                if (this.Mountpoint != null)
                    hashCode = hashCode * 59 + this.Mountpoint.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Labels != null)
                    hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.UsageData != null)
                    hashCode = hashCode * 59 + this.UsageData.GetHashCode();
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
