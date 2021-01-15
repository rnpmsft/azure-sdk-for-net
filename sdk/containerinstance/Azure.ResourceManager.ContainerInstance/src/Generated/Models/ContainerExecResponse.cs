// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The information for the container exec command. </summary>
    public partial class ContainerExecResponse
    {
        /// <summary> Initializes a new instance of ContainerExecResponse. </summary>
        internal ContainerExecResponse()
        {
        }

        /// <summary> Initializes a new instance of ContainerExecResponse. </summary>
        /// <param name="webSocketUri"> The uri for the exec websocket. </param>
        /// <param name="password"> The password to start the exec command. </param>
        internal ContainerExecResponse(string webSocketUri, string password)
        {
            WebSocketUri = webSocketUri;
            Password = password;
        }

        /// <summary> The uri for the exec websocket. </summary>
        public string WebSocketUri { get; }
        /// <summary> The password to start the exec command. </summary>
        public string Password { get; }
    }
}