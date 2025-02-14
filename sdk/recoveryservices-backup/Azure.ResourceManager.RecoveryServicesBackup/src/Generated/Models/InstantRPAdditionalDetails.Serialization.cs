// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class InstantRPAdditionalDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureBackupRGNamePrefix))
            {
                writer.WritePropertyName("azureBackupRGNamePrefix"u8);
                writer.WriteStringValue(AzureBackupRGNamePrefix);
            }
            if (Optional.IsDefined(AzureBackupRGNameSuffix))
            {
                writer.WritePropertyName("azureBackupRGNameSuffix"u8);
                writer.WriteStringValue(AzureBackupRGNameSuffix);
            }
            writer.WriteEndObject();
        }

        internal static InstantRPAdditionalDetails DeserializeInstantRPAdditionalDetails(JsonElement element)
        {
            Optional<string> azureBackupRGNamePrefix = default;
            Optional<string> azureBackupRGNameSuffix = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureBackupRGNamePrefix"u8))
                {
                    azureBackupRGNamePrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureBackupRGNameSuffix"u8))
                {
                    azureBackupRGNameSuffix = property.Value.GetString();
                    continue;
                }
            }
            return new InstantRPAdditionalDetails(azureBackupRGNamePrefix.Value, azureBackupRGNameSuffix.Value);
        }
    }
}
