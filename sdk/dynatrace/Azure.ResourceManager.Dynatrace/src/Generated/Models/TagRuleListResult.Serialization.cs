// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Dynatrace;

namespace Azure.ResourceManager.Dynatrace.Models
{
    internal partial class TagRuleListResult
    {
        internal static TagRuleListResult DeserializeTagRuleListResult(JsonElement element)
        {
            IReadOnlyList<DynatraceTagRuleData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DynatraceTagRuleData> array = new List<DynatraceTagRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DynatraceTagRuleData.DeserializeDynatraceTagRuleData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TagRuleListResult(value, nextLink.Value);
        }
    }
}
