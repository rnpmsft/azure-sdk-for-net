// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The container instance state. </summary>
    public partial class ContainerState
    {
        /// <summary> Initializes a new instance of ContainerState. </summary>
        internal ContainerState()
        {
        }

        /// <summary> Initializes a new instance of ContainerState. </summary>
        /// <param name="state"> The state of the container instance. </param>
        /// <param name="startTime"> The date-time when the container instance state started. </param>
        /// <param name="exitCode"> The container instance exit codes correspond to those from the `docker run` command. </param>
        /// <param name="finishTime"> The date-time when the container instance state finished. </param>
        /// <param name="detailStatus"> The human-readable status of the container instance state. </param>
        internal ContainerState(string state, DateTimeOffset? startTime, int? exitCode, DateTimeOffset? finishTime, string detailStatus)
        {
            State = state;
            StartTime = startTime;
            ExitCode = exitCode;
            FinishTime = finishTime;
            DetailStatus = detailStatus;
        }

        /// <summary> The state of the container instance. </summary>
        public string State { get; }
        /// <summary> The date-time when the container instance state started. </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The container instance exit codes correspond to those from the `docker run` command. </summary>
        public int? ExitCode { get; }
        /// <summary> The date-time when the container instance state finished. </summary>
        public DateTimeOffset? FinishTime { get; }
        /// <summary> The human-readable status of the container instance state. </summary>
        public string DetailStatus { get; }
    }
}