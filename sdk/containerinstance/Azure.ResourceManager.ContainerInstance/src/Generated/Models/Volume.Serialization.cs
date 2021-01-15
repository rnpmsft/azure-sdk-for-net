// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class Volume : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(AzureFile))
            {
                writer.WritePropertyName("azureFile");
                writer.WriteObjectValue(AzureFile);
            }
            if (Optional.IsDefined(EmptyDir))
            {
                writer.WritePropertyName("emptyDir");
                writer.WriteObjectValue(EmptyDir);
            }
            if (Optional.IsCollectionDefined(Secret))
            {
                writer.WritePropertyName("secret");
                writer.WriteStartObject();
                foreach (var item in Secret)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(GitRepo))
            {
                writer.WritePropertyName("gitRepo");
                writer.WriteObjectValue(GitRepo);
            }
            writer.WriteEndObject();
        }

        internal static Volume DeserializeVolume(JsonElement element)
        {
            string name = default;
            Optional<AzureFileVolume> azureFile = default;
            Optional<object> emptyDir = default;
            Optional<IDictionary<string, string>> secret = default;
            Optional<GitRepoVolume> gitRepo = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureFile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    azureFile = AzureFileVolume.DeserializeAzureFileVolume(property.Value);
                    continue;
                }
                if (property.NameEquals("emptyDir"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    emptyDir = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("secret"))
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
                    secret = dictionary;
                    continue;
                }
                if (property.NameEquals("gitRepo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gitRepo = GitRepoVolume.DeserializeGitRepoVolume(property.Value);
                    continue;
                }
            }
            return new Volume(name, azureFile.Value, emptyDir.Value, Optional.ToDictionary(secret), gitRepo.Value);
        }
    }
}