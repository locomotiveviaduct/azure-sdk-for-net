// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ExportPipelineTargetProperties : IUtf8JsonSerializable, IJsonModel<ExportPipelineTargetProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExportPipelineTargetProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExportPipelineTargetProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportPipelineTargetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportPipelineTargetProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PipelineTargetType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PipelineTargetType);
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("uri"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            writer.WritePropertyName("keyVaultUri"u8);
            writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ExportPipelineTargetProperties IJsonModel<ExportPipelineTargetProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportPipelineTargetProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExportPipelineTargetProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExportPipelineTargetProperties(document.RootElement, options);
        }

        internal static ExportPipelineTargetProperties DeserializeExportPipelineTargetProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Uri uri = default;
            Uri keyVaultUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExportPipelineTargetProperties(type, uri, keyVaultUri, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PipelineTargetType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PipelineTargetType))
                {
                    builder.Append("  type: ");
                    if (PipelineTargetType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PipelineTargetType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PipelineTargetType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Uri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  uri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Uri))
                {
                    builder.Append("  uri: ");
                    builder.AppendLine($"'{Uri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyVaultUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  keyVaultUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyVaultUri))
                {
                    builder.Append("  keyVaultUri: ");
                    builder.AppendLine($"'{KeyVaultUri.AbsoluteUri}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ExportPipelineTargetProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportPipelineTargetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ExportPipelineTargetProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ExportPipelineTargetProperties IPersistableModel<ExportPipelineTargetProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExportPipelineTargetProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExportPipelineTargetProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExportPipelineTargetProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExportPipelineTargetProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
