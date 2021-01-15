// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The container probe, for liveness or readiness. </summary>
    public partial class ContainerProbe
    {
        /// <summary> Initializes a new instance of ContainerProbe. </summary>
        public ContainerProbe()
        {
        }

        /// <summary> Initializes a new instance of ContainerProbe. </summary>
        /// <param name="exec"> The execution command to probe. </param>
        /// <param name="httpGet"> The Http Get settings to probe. </param>
        /// <param name="initialDelaySeconds"> The initial delay seconds. </param>
        /// <param name="periodSeconds"> The period seconds. </param>
        /// <param name="failureThreshold"> The failure threshold. </param>
        /// <param name="successThreshold"> The success threshold. </param>
        /// <param name="timeoutSeconds"> The timeout seconds. </param>
        internal ContainerProbe(ContainerExec exec, ContainerHttpGet httpGet, int? initialDelaySeconds, int? periodSeconds, int? failureThreshold, int? successThreshold, int? timeoutSeconds)
        {
            Exec = exec;
            HttpGet = httpGet;
            InitialDelaySeconds = initialDelaySeconds;
            PeriodSeconds = periodSeconds;
            FailureThreshold = failureThreshold;
            SuccessThreshold = successThreshold;
            TimeoutSeconds = timeoutSeconds;
        }

        /// <summary> The execution command to probe. </summary>
        public ContainerExec Exec { get; set; }
        /// <summary> The Http Get settings to probe. </summary>
        public ContainerHttpGet HttpGet { get; set; }
        /// <summary> The initial delay seconds. </summary>
        public int? InitialDelaySeconds { get; set; }
        /// <summary> The period seconds. </summary>
        public int? PeriodSeconds { get; set; }
        /// <summary> The failure threshold. </summary>
        public int? FailureThreshold { get; set; }
        /// <summary> The success threshold. </summary>
        public int? SuccessThreshold { get; set; }
        /// <summary> The timeout seconds. </summary>
        public int? TimeoutSeconds { get; set; }
    }
}