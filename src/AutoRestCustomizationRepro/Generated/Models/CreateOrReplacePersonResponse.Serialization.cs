// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace AutoRestCustomizationRepro.Models
{
    public partial class CreateOrReplacePersonResponse
    {
        internal static CreateOrReplacePersonResponse DeserializeCreateOrReplacePersonResponse(JsonElement element)
        {
            Optional<string> id = default;
            Optional<object> additionalProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    additionalProperties = property.Value.GetObject();
                    continue;
                }
            }
            return new CreateOrReplacePersonResponse(id.Value, additionalProperties.Value);
        }
    }
}
