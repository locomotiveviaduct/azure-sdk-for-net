// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.KeyVault.Administration.Models
{
    /// <summary> An authentication method and location for the operation. </summary>
    internal partial class SASTokenParameter
    {
        /// <summary> Initializes a new instance of <see cref="SASTokenParameter"/>. </summary>
        /// <param name="storageResourceUri"> Azure Blob storage container Uri. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageResourceUri"/> is null. </exception>
        public SASTokenParameter(string storageResourceUri)
        {
            Argument.AssertNotNull(storageResourceUri, nameof(storageResourceUri));

            StorageResourceUri = storageResourceUri;
        }

        /// <summary> Initializes a new instance of <see cref="SASTokenParameter"/>. </summary>
        /// <param name="storageResourceUri"> Azure Blob storage container Uri. </param>
        /// <param name="token"> The SAS token pointing to an Azure Blob storage container. </param>
        /// <param name="useManagedIdentity"> Indicates which authentication method should be used. If set to true, Managed HSM will use the configured user-assigned managed identity to authenticate with Azure Storage. Otherwise, a SAS token has to be specified. </param>
        internal SASTokenParameter(string storageResourceUri, string token, bool? useManagedIdentity)
        {
            StorageResourceUri = storageResourceUri;
            Token = token;
            UseManagedIdentity = useManagedIdentity;
        }

        /// <summary> Azure Blob storage container Uri. </summary>
        public string StorageResourceUri { get; }
        /// <summary> The SAS token pointing to an Azure Blob storage container. </summary>
        public string Token { get; set; }
        /// <summary> Indicates which authentication method should be used. If set to true, Managed HSM will use the configured user-assigned managed identity to authenticate with Azure Storage. Otherwise, a SAS token has to be specified. </summary>
        public bool? UseManagedIdentity { get; set; }
    }
}
