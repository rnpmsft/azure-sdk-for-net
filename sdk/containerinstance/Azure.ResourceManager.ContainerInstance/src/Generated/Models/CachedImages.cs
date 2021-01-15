// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The cached image and OS type. </summary>
    public partial class CachedImages
    {
        /// <summary> Initializes a new instance of CachedImages. </summary>
        /// <param name="osType"> The OS type of the cached image. </param>
        /// <param name="image"> The cached image name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="osType"/> or <paramref name="image"/> is null. </exception>
        internal CachedImages(string osType, string image)
        {
            if (osType == null)
            {
                throw new ArgumentNullException(nameof(osType));
            }
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            OsType = osType;
            Image = image;
        }

        /// <summary> The OS type of the cached image. </summary>
        public string OsType { get; }
        /// <summary> The cached image name. </summary>
        public string Image { get; }
    }
}