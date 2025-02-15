// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    public partial class PrivateEndpointConnectionProxyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RemotePrivateEndpoint))
            {
                writer.WritePropertyName("remotePrivateEndpoint");
                writer.WriteObjectValue(RemotePrivateEndpoint);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status);
            }
            writer.WriteEndObject();
        }

        internal static PrivateEndpointConnectionProxyData DeserializePrivateEndpointConnectionProxyData(JsonElement element)
        {
            Optional<string> eTag = default;
            Optional<RemotePrivateEndpoint> remotePrivateEndpoint = default;
            Optional<PrivateEndpointConnectionProxyProvisioningState> provisioningState = default;
            Optional<string> status = default;
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remotePrivateEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    remotePrivateEndpoint = RemotePrivateEndpoint.DeserializeRemotePrivateEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new PrivateEndpointConnectionProxyProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateEndpointConnectionProxyData(id, name, type, systemData, eTag.Value, remotePrivateEndpoint.Value, Optional.ToNullable(provisioningState), status.Value);
        }
    }
}
