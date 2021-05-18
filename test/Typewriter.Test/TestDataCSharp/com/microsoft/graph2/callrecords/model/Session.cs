// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph2.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Session.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<Session>))]
    public partial class Session : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The Session constructor
		///</summary>
        public Session()
        {
            this.ODataType = "microsoft.graph2.callRecords.session";
        }
	
        /// <summary>
        /// Gets or sets modalities.
        /// </summary>
        [JsonPropertyName("modalities")]
        public IEnumerable<Modality> Modalities { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets end date time.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets caller.
        /// </summary>
        [JsonPropertyName("caller")]
        public Endpoint Caller { get; set; }
    
        /// <summary>
        /// Gets or sets callee.
        /// </summary>
        [JsonPropertyName("callee")]
        public Endpoint Callee { get; set; }
    
        /// <summary>
        /// Gets or sets failure info.
        /// </summary>
        [JsonPropertyName("failureInfo")]
        public FailureInfo FailureInfo { get; set; }
    
        /// <summary>
        /// Gets or sets segments.
        /// </summary>
        [JsonPropertyName("segments")]
        public ISessionSegmentsCollectionPage Segments { get; set; }

        /// <summary>
        /// Gets or sets segmentsNextLink.
        /// </summary>
        [JsonPropertyName("segments@odata.nextLink")]
        public string SegmentsNextLink { get; set; }
    
    }
}

