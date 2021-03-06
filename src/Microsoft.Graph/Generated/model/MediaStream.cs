// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type MediaStream.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MediaStream
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaStream"/> class.
        /// </summary>
        public MediaStream()
        {
            this.ODataType = "microsoft.graph.mediaStream";
        }

        /// <summary>
        /// Gets or sets direction.
        /// The direction. The possible values are inactive, sendOnly, receiveOnly, sendReceive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "direction", Required = Newtonsoft.Json.Required.Default)]
        public MediaDirection? Direction { get; set; }
    
        /// <summary>
        /// Gets or sets label.
        /// The media stream label.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "label", Required = Newtonsoft.Json.Required.Default)]
        public string Label { get; set; }
    
        /// <summary>
        /// Gets or sets mediaType.
        /// The media type. The possible value are unknown, audio, video, videoBasedScreenSharing, data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaType", Required = Newtonsoft.Json.Required.Default)]
        public Modality? MediaType { get; set; }
    
        /// <summary>
        /// Gets or sets serverMuted.
        /// If the media is muted by the server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "serverMuted", Required = Newtonsoft.Json.Required.Default)]
        public bool? ServerMuted { get; set; }
    
        /// <summary>
        /// Gets or sets sourceId.
        /// The source ID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceId", Required = Newtonsoft.Json.Required.Default)]
        public string SourceId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
