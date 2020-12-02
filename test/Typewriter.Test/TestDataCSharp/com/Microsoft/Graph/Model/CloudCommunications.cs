// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Cloud Communications.
    /// </summary>
    
    public partial class CloudCommunications : Entity
    {
    
		///<summary>
		/// The CloudCommunications constructor
		///</summary>
        public CloudCommunications()
        {
            this.ODataType = "microsoft.graph.cloudCommunications";
        }
	
        /// <summary>
        /// Gets or sets calls.
        /// </summary>
        [JsonPropertyName("calls")]
        public ICloudCommunicationsCallsCollectionPage Calls { get; set; }
    
        /// <summary>
        /// Gets or sets call records.
        /// </summary>
        [JsonPropertyName("callRecords")]
        public ICloudCommunicationsCallRecordsCollectionPage CallRecords { get; set; }
    
    }
}

