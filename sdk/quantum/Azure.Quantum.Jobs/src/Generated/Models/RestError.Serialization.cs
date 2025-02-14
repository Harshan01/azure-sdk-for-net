// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    internal partial class RestError
    {
        internal static RestError DeserializeRestError(JsonElement element)
        {
            Optional<ErrorData> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ErrorData.DeserializeErrorData(property.Value);
                    continue;
                }
            }
            return new RestError(error.Value);
        }
    }
}
