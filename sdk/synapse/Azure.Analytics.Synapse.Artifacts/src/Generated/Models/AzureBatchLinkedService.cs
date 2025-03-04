// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure Batch linked service. </summary>
    public partial class AzureBatchLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AzureBatchLinkedService"/>. </summary>
        /// <param name="accountName"> The Azure Batch account name. Type: string (or Expression with resultType string). </param>
        /// <param name="batchUri"> The Azure Batch URI. Type: string (or Expression with resultType string). </param>
        /// <param name="poolName"> The Azure Batch pool name. Type: string (or Expression with resultType string). </param>
        /// <param name="linkedServiceName"> The Azure Storage linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="batchUri"/>, <paramref name="poolName"/> or <paramref name="linkedServiceName"/> is null. </exception>
        public AzureBatchLinkedService(object accountName, object batchUri, object poolName, LinkedServiceReference linkedServiceName)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(batchUri, nameof(batchUri));
            Argument.AssertNotNull(poolName, nameof(poolName));
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            AccountName = accountName;
            BatchUri = batchUri;
            PoolName = poolName;
            LinkedServiceName = linkedServiceName;
            Type = "AzureBatch";
        }

        /// <summary> Initializes a new instance of <see cref="AzureBatchLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="version"> Version of the linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="accountName"> The Azure Batch account name. Type: string (or Expression with resultType string). </param>
        /// <param name="accessKey">
        /// The Azure Batch account access key.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="batchUri"> The Azure Batch URI. Type: string (or Expression with resultType string). </param>
        /// <param name="poolName"> The Azure Batch pool name. Type: string (or Expression with resultType string). </param>
        /// <param name="linkedServiceName"> The Azure Storage linked service reference. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureBatchLinkedService(string type, string version, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object accountName, SecretBase accessKey, object batchUri, object poolName, LinkedServiceReference linkedServiceName, object encryptedCredential, CredentialReference credential) : base(type, version, connectVia, description, parameters, annotations, additionalProperties)
        {
            AccountName = accountName;
            AccessKey = accessKey;
            BatchUri = batchUri;
            PoolName = poolName;
            LinkedServiceName = linkedServiceName;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            Type = type ?? "AzureBatch";
        }

        /// <summary> The Azure Batch account name. Type: string (or Expression with resultType string). </summary>
        public object AccountName { get; set; }
        /// <summary>
        /// The Azure Batch account access key.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase AccessKey { get; set; }
        /// <summary> The Azure Batch URI. Type: string (or Expression with resultType string). </summary>
        public object BatchUri { get; set; }
        /// <summary> The Azure Batch pool name. Type: string (or Expression with resultType string). </summary>
        public object PoolName { get; set; }
        /// <summary> The Azure Storage linked service reference. </summary>
        public LinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
