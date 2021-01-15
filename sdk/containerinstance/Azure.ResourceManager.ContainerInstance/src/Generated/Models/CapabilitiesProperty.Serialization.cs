// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class CapabilitiesProperty
    {
        internal static CapabilitiesProperty DeserializeCapabilitiesProperty(JsonElement element)
        {
            Optional<float> maxMemoryInGB = default;
            Optional<float> maxCpu = default;
            Optional<float> maxGpuCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxMemoryInGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxMemoryInGB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("maxCpu"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxCpu = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("maxGpuCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxGpuCount = property.Value.GetSingle();
                    continue;
                }
            }
            return new CapabilitiesProperty(Optional.ToNullable(maxMemoryInGB), Optional.ToNullable(maxCpu), Optional.ToNullable(maxGpuCount));
        }
    }
}