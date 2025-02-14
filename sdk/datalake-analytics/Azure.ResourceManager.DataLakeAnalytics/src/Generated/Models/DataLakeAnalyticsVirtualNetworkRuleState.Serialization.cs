// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    internal static partial class DataLakeAnalyticsVirtualNetworkRuleStateExtensions
    {
        public static string ToSerialString(this DataLakeAnalyticsVirtualNetworkRuleState value) => value switch
        {
            DataLakeAnalyticsVirtualNetworkRuleState.Active => "Active",
            DataLakeAnalyticsVirtualNetworkRuleState.NetworkSourceDeleted => "NetworkSourceDeleted",
            DataLakeAnalyticsVirtualNetworkRuleState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeAnalyticsVirtualNetworkRuleState value.")
        };

        public static DataLakeAnalyticsVirtualNetworkRuleState ToDataLakeAnalyticsVirtualNetworkRuleState(this string value)
        {
            if (string.Equals(value, "Active", StringComparison.InvariantCultureIgnoreCase)) return DataLakeAnalyticsVirtualNetworkRuleState.Active;
            if (string.Equals(value, "NetworkSourceDeleted", StringComparison.InvariantCultureIgnoreCase)) return DataLakeAnalyticsVirtualNetworkRuleState.NetworkSourceDeleted;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return DataLakeAnalyticsVirtualNetworkRuleState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeAnalyticsVirtualNetworkRuleState value.");
        }
    }
}
