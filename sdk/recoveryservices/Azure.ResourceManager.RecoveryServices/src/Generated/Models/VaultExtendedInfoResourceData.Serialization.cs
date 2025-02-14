// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServices
{
    public partial class VaultExtendedInfoResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IntegrityKey))
            {
                writer.WritePropertyName("integrityKey"u8);
                writer.WriteStringValue(IntegrityKey);
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                writer.WritePropertyName("encryptionKey"u8);
                writer.WriteStringValue(EncryptionKey);
            }
            if (Optional.IsDefined(EncryptionKeyThumbprint))
            {
                writer.WritePropertyName("encryptionKeyThumbprint"u8);
                writer.WriteStringValue(EncryptionKeyThumbprint);
            }
            if (Optional.IsDefined(Algorithm))
            {
                writer.WritePropertyName("algorithm"u8);
                writer.WriteStringValue(Algorithm);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VaultExtendedInfoResourceData DeserializeVaultExtendedInfoResourceData(JsonElement element)
        {
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> integrityKey = default;
            Optional<string> encryptionKey = default;
            Optional<string> encryptionKeyThumbprint = default;
            Optional<string> algorithm = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("integrityKey"u8))
                        {
                            integrityKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKey"u8))
                        {
                            encryptionKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKeyThumbprint"u8))
                        {
                            encryptionKeyThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("algorithm"u8))
                        {
                            algorithm = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VaultExtendedInfoResourceData(id, name, type, systemData.Value, integrityKey.Value, encryptionKey.Value, encryptionKeyThumbprint.Value, algorithm.Value, Optional.ToNullable(etag));
        }
    }
}
