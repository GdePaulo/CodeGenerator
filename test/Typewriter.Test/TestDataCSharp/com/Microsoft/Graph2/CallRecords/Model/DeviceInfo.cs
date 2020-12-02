// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph2.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DeviceInfo.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<DeviceInfo>))]
    public partial class DeviceInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceInfo"/> class.
        /// </summary>
        public DeviceInfo()
        {
            this.ODataType = "microsoft.graph2.callRecords.deviceInfo";
        }

        /// <summary>
        /// Gets or sets captureDeviceName.
        /// </summary>
        [JsonPropertyName("captureDeviceName")]
        public string CaptureDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets sentSignalLevel.
        /// </summary>
        [JsonPropertyName("sentSignalLevel")]
        public Int32? SentSignalLevel { get; set; }
    
        /// <summary>
        /// Gets or sets speakerGlitchRate.
        /// </summary>
        [JsonPropertyName("speakerGlitchRate")]
        public Single? SpeakerGlitchRate { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
