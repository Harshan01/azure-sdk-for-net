// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class AnalyzeOperationResult
    {
        internal static AnalyzeOperationResult DeserializeAnalyzeOperationResult(JsonElement element)
        {
            OperationStatus status = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            Optional<V2AnalyzeResult> analyzeResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToOperationStatus();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("analyzeResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        analyzeResult = null;
                        continue;
                    }
                    analyzeResult = V2AnalyzeResult.DeserializeV2AnalyzeResult(property.Value);
                    continue;
                }
            }
            return new AnalyzeOperationResult(status, createdDateTime, lastUpdatedDateTime, analyzeResult.Value);
        }
    }
}
