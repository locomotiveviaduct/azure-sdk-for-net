// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.OpenAI;

namespace Azure.AI.OpenAI.Chat
{
    internal partial class InternalAzureChatDataSourceDeploymentNameVectorizationSource : DataSourceVectorizer
    {
        public InternalAzureChatDataSourceDeploymentNameVectorizationSource(string deploymentName) : base("deployment_name")
        {
            Argument.AssertNotNull(deploymentName, nameof(deploymentName));

            DeploymentName = deploymentName;
        }

        internal InternalAzureChatDataSourceDeploymentNameVectorizationSource(string @type, IDictionary<string, BinaryData> additionalBinaryDataProperties, string deploymentName, int? dimensions) : base(@type, additionalBinaryDataProperties)
        {
            DeploymentName = deploymentName;
            Dimensions = dimensions;
        }

        /// <summary>
        /// The embedding model deployment to use for vectorization. This deployment must exist within the same Azure OpenAI
        /// resource as the model deployment being used for chat completions.
        /// </summary>
        public string DeploymentName { get; set; }

        /// <summary>
        /// The number of dimensions to request on embeddings.
        /// Only supported in 'text-embedding-3' and later models.
        /// </summary>
        public int? Dimensions { get; set; }
    }
}
