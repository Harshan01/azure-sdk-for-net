// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> Capabilities response for Microsoft.RecoveryServices. </summary>
    public partial class CapabilitiesResult : ResourceCapabilitiesBase
    {
        /// <summary> Initializes a new instance of CapabilitiesResult. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceCapabilitiesBaseType"/> is null. </exception>
        public CapabilitiesResult(string resourceCapabilitiesBaseType) : base(resourceCapabilitiesBaseType)
        {
            Argument.AssertNotNull(resourceCapabilitiesBaseType, nameof(resourceCapabilitiesBaseType));
        }

        /// <summary> Initializes a new instance of CapabilitiesResult. </summary>
        /// <param name="resourceCapabilitiesBaseType"> Describes the Resource type: Microsoft.RecoveryServices/Vaults. </param>
        /// <param name="properties"> Capabilities properties in response. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceCapabilitiesBaseType"/> is null. </exception>
        internal CapabilitiesResult(string resourceCapabilitiesBaseType, CapabilitiesResponseProperties properties) : base(resourceCapabilitiesBaseType)
        {
            Argument.AssertNotNull(resourceCapabilitiesBaseType, nameof(resourceCapabilitiesBaseType));

            Properties = properties;
        }

        /// <summary> Capabilities properties in response. </summary>
        internal CapabilitiesResponseProperties Properties { get; set; }
        /// <summary> Gets the capabilities response dns zones. </summary>
        public IList<DnsZoneResult> CapabilitiesResponseDnsZones
        {
            get
            {
                if (Properties is null)
                    Properties = new CapabilitiesResponseProperties();
                return Properties.DnsZones;
            }
        }
    }
}
