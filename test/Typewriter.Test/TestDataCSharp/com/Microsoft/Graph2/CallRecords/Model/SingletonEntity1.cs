// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph2.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Singleton Entity1.
    /// </summary>
    
    public partial class SingletonEntity1 : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The SingletonEntity1 constructor
		///</summary>
        public SingletonEntity1()
        {
            this.ODataType = "microsoft.graph2.callRecords.singletonEntity1";
        }
	
        /// <summary>
        /// Gets or sets test single nav.
        /// </summary>
        [JsonPropertyName("testSingleNav")]
        public Microsoft.Graph.TestType TestSingleNav { get; set; }
    
    }
}

