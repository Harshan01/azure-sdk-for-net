// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsAvailableServiceTier
    {
        internal static OperationalInsightsAvailableServiceTier DeserializeOperationalInsightsAvailableServiceTier(JsonElement element)
        {
            Optional<OperationalInsightsSkuName> serviceTier = default;
            Optional<bool> enabled = default;
            Optional<long> minimumRetention = default;
            Optional<long> maximumRetention = default;
            Optional<long> defaultRetention = default;
            Optional<long> capacityReservationLevel = default;
            Optional<DateTimeOffset> lastSkuUpdate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceTier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    serviceTier = new OperationalInsightsSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minimumRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minimumRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maximumRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maximumRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultRetention"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultRetention = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("capacityReservationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capacityReservationLevel = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("lastSkuUpdate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastSkuUpdate = property.Value.GetDateTimeOffset();
                    continue;
                }
            }
            return new OperationalInsightsAvailableServiceTier(Optional.ToNullable(serviceTier), Optional.ToNullable(enabled), Optional.ToNullable(minimumRetention), Optional.ToNullable(maximumRetention), Optional.ToNullable(defaultRetention), Optional.ToNullable(capacityReservationLevel), Optional.ToNullable(lastSkuUpdate));
        }
    }
}
