// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.IotOperations.Models
{
    /// <summary> Dataflow BuiltIn Transformation dataset properties. </summary>
    public partial class DataflowBuiltInTransformationDataset
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationDataset"/>. </summary>
        /// <param name="key"> The key of the dataset. </param>
        /// <param name="inputs"> List of fields for enriching from the Broker State Store. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="inputs"/> is null. </exception>
        public DataflowBuiltInTransformationDataset(string key, IEnumerable<string> inputs)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(inputs, nameof(inputs));

            Key = key;
            Inputs = inputs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationDataset"/>. </summary>
        /// <param name="key"> The key of the dataset. </param>
        /// <param name="description"> A user provided optional description of the dataset. </param>
        /// <param name="schemaRef"> The reference to the schema that describes the dataset. Allowed: JSON Schema/draft-7. </param>
        /// <param name="inputs"> List of fields for enriching from the Broker State Store. </param>
        /// <param name="expression"> Condition to enrich data from Broker State Store. Example: $1 &lt; 0 || $1 &gt; $2 (Assuming inputs section $1 and $2 are provided). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataflowBuiltInTransformationDataset(string key, string description, string schemaRef, IList<string> inputs, string expression, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Key = key;
            Description = description;
            SchemaRef = schemaRef;
            Inputs = inputs;
            Expression = expression;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataflowBuiltInTransformationDataset"/> for deserialization. </summary>
        internal DataflowBuiltInTransformationDataset()
        {
        }

        /// <summary> The key of the dataset. </summary>
        public string Key { get; set; }
        /// <summary> A user provided optional description of the dataset. </summary>
        public string Description { get; set; }
        /// <summary> The reference to the schema that describes the dataset. Allowed: JSON Schema/draft-7. </summary>
        public string SchemaRef { get; set; }
        /// <summary> List of fields for enriching from the Broker State Store. </summary>
        public IList<string> Inputs { get; }
        /// <summary> Condition to enrich data from Broker State Store. Example: $1 &lt; 0 || $1 &gt; $2 (Assuming inputs section $1 and $2 are provided). </summary>
        public string Expression { get; set; }
    }
}
