// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class ThreeTierConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration");
                writer.WriteObjectValue(NetworkConfiguration);
            }
            writer.WritePropertyName("centralServer");
            writer.WriteObjectValue(CentralServer);
            writer.WritePropertyName("applicationServer");
            writer.WriteObjectValue(ApplicationServer);
            writer.WritePropertyName("databaseServer");
            writer.WriteObjectValue(DatabaseServer);
            if (Optional.IsDefined(HighAvailabilityConfig))
            {
                writer.WritePropertyName("highAvailabilityConfig");
                writer.WriteObjectValue(HighAvailabilityConfig);
            }
            writer.WritePropertyName("deploymentType");
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("appResourceGroup");
            writer.WriteStringValue(AppResourceGroup);
            writer.WriteEndObject();
        }

        internal static ThreeTierConfiguration DeserializeThreeTierConfiguration(JsonElement element)
        {
            Optional<NetworkConfiguration> networkConfiguration = default;
            CentralServerConfiguration centralServer = default;
            ApplicationServerConfiguration applicationServer = default;
            DatabaseConfiguration databaseServer = default;
            Optional<HighAvailabilityConfiguration> highAvailabilityConfig = default;
            SapDeploymentType deploymentType = default;
            string appResourceGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkConfiguration"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    networkConfiguration = NetworkConfiguration.DeserializeNetworkConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("centralServer"))
                {
                    centralServer = CentralServerConfiguration.DeserializeCentralServerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("applicationServer"))
                {
                    applicationServer = ApplicationServerConfiguration.DeserializeApplicationServerConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("databaseServer"))
                {
                    databaseServer = DatabaseConfiguration.DeserializeDatabaseConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("highAvailabilityConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    highAvailabilityConfig = HighAvailabilityConfiguration.DeserializeHighAvailabilityConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("deploymentType"))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceGroup"))
                {
                    appResourceGroup = property.Value.GetString();
                    continue;
                }
            }
            return new ThreeTierConfiguration(deploymentType, appResourceGroup, networkConfiguration.Value, centralServer, applicationServer, databaseServer, highAvailabilityConfig.Value);
        }
    }
}
