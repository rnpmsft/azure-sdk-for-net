// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The container group encryption properties. </summary>
    public partial class EncryptionProperties
    {
        /// <summary> Initializes a new instance of EncryptionProperties. </summary>
        /// <param name="vaultBaseUrl"> The keyvault base url. </param>
        /// <param name="keyName"> The encryption key name. </param>
        /// <param name="keyVersion"> The encryption key version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="keyName"/>, or <paramref name="keyVersion"/> is null. </exception>
        public EncryptionProperties(string vaultBaseUrl, string keyName, string keyVersion)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (keyName == null)
            {
                throw new ArgumentNullException(nameof(keyName));
            }
            if (keyVersion == null)
            {
                throw new ArgumentNullException(nameof(keyVersion));
            }

            VaultBaseUrl = vaultBaseUrl;
            KeyName = keyName;
            KeyVersion = keyVersion;
        }

        /// <summary> The keyvault base url. </summary>
        public string VaultBaseUrl { get; set; }
        /// <summary> The encryption key name. </summary>
        public string KeyName { get; set; }
        /// <summary> The encryption key version. </summary>
        public string KeyVersion { get; set; }
    }
}