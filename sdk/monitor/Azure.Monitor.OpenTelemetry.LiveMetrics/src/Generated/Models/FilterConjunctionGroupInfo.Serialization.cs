// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class FilterConjunctionGroupInfo
    {
        internal static FilterConjunctionGroupInfo DeserializeFilterConjunctionGroupInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<FilterInfo> filters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Filters"u8))
                {
                    List<FilterInfo> array = new List<FilterInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilterInfo.DeserializeFilterInfo(item));
                    }
                    filters = array;
                    continue;
                }
            }
            return new FilterConjunctionGroupInfo(filters);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static FilterConjunctionGroupInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeFilterConjunctionGroupInfo(document.RootElement);
        }
    }
}
