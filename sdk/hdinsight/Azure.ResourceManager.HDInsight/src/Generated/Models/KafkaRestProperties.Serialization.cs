// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class KafkaRestProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClientGroupInfo))
            {
                writer.WritePropertyName("clientGroupInfo"u8);
                writer.WriteObjectValue(ClientGroupInfo);
            }
            if (Optional.IsCollectionDefined(ConfigurationOverride))
            {
                writer.WritePropertyName("configurationOverride"u8);
                writer.WriteStartObject();
                foreach (var item in ConfigurationOverride)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static KafkaRestProperties DeserializeKafkaRestProperties(JsonElement element)
        {
            Optional<ClientGroupInfo> clientGroupInfo = default;
            Optional<IDictionary<string, string>> configurationOverride = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientGroupInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clientGroupInfo = ClientGroupInfo.DeserializeClientGroupInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("configurationOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    configurationOverride = dictionary;
                    continue;
                }
            }
            return new KafkaRestProperties(clientGroupInfo.Value, Optional.ToDictionary(configurationOverride));
        }
    }
}
