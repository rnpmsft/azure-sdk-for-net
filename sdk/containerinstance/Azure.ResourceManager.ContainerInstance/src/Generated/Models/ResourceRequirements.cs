// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The resource requirements. </summary>
    public partial class ResourceRequirements
    {
        /// <summary> Initializes a new instance of ResourceRequirements. </summary>
        /// <param name="requests"> The resource requests of this container instance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requests"/> is null. </exception>
        public ResourceRequirements(ResourceRequests requests)
        {
            if (requests == null)
            {
                throw new ArgumentNullException(nameof(requests));
            }

            Requests = requests;
        }

        /// <summary> Initializes a new instance of ResourceRequirements. </summary>
        /// <param name="requests"> The resource requests of this container instance. </param>
        /// <param name="limits"> The resource limits of this container instance. </param>
        internal ResourceRequirements(ResourceRequests requests, ResourceLimits limits)
        {
            Requests = requests;
            Limits = limits;
        }

        /// <summary> The resource requests of this container instance. </summary>
        public ResourceRequests Requests { get; set; }
        /// <summary> The resource limits of this container instance. </summary>
        public ResourceLimits Limits { get; set; }
    }
}