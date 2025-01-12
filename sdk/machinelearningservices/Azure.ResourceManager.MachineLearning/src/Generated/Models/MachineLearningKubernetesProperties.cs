// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Kubernetes properties
    /// Serialized Name: KubernetesProperties
    /// </summary>
    public partial class MachineLearningKubernetesProperties
    {
        /// <summary> Initializes a new instance of MachineLearningKubernetesProperties. </summary>
        public MachineLearningKubernetesProperties()
        {
            InstanceTypes = new ChangeTrackingDictionary<string, MachineLearningInstanceTypeSchema>();
        }

        /// <summary> Initializes a new instance of MachineLearningKubernetesProperties. </summary>
        /// <param name="relayConnectionString">
        /// Relay connection string.
        /// Serialized Name: KubernetesProperties.relayConnectionString
        /// </param>
        /// <param name="serviceBusConnectionString">
        /// ServiceBus connection string.
        /// Serialized Name: KubernetesProperties.serviceBusConnectionString
        /// </param>
        /// <param name="extensionPrincipalId">
        /// Extension principal-id.
        /// Serialized Name: KubernetesProperties.extensionPrincipalId
        /// </param>
        /// <param name="extensionInstanceReleaseTrain">
        /// Extension instance release train.
        /// Serialized Name: KubernetesProperties.extensionInstanceReleaseTrain
        /// </param>
        /// <param name="vcName">
        /// VC name.
        /// Serialized Name: KubernetesProperties.vcName
        /// </param>
        /// <param name="namespace">
        /// Compute namespace
        /// Serialized Name: KubernetesProperties.namespace
        /// </param>
        /// <param name="defaultInstanceType">
        /// Default instance type
        /// Serialized Name: KubernetesProperties.defaultInstanceType
        /// </param>
        /// <param name="instanceTypes">
        /// Instance Type Schema
        /// Serialized Name: KubernetesProperties.instanceTypes
        /// </param>
        internal MachineLearningKubernetesProperties(string relayConnectionString, string serviceBusConnectionString, string extensionPrincipalId, string extensionInstanceReleaseTrain, string vcName, string @namespace, string defaultInstanceType, IDictionary<string, MachineLearningInstanceTypeSchema> instanceTypes)
        {
            RelayConnectionString = relayConnectionString;
            ServiceBusConnectionString = serviceBusConnectionString;
            ExtensionPrincipalId = extensionPrincipalId;
            ExtensionInstanceReleaseTrain = extensionInstanceReleaseTrain;
            VcName = vcName;
            Namespace = @namespace;
            DefaultInstanceType = defaultInstanceType;
            InstanceTypes = instanceTypes;
        }

        /// <summary>
        /// Relay connection string.
        /// Serialized Name: KubernetesProperties.relayConnectionString
        /// </summary>
        public string RelayConnectionString { get; set; }
        /// <summary>
        /// ServiceBus connection string.
        /// Serialized Name: KubernetesProperties.serviceBusConnectionString
        /// </summary>
        public string ServiceBusConnectionString { get; set; }
        /// <summary>
        /// Extension principal-id.
        /// Serialized Name: KubernetesProperties.extensionPrincipalId
        /// </summary>
        public string ExtensionPrincipalId { get; set; }
        /// <summary>
        /// Extension instance release train.
        /// Serialized Name: KubernetesProperties.extensionInstanceReleaseTrain
        /// </summary>
        public string ExtensionInstanceReleaseTrain { get; set; }
        /// <summary>
        /// VC name.
        /// Serialized Name: KubernetesProperties.vcName
        /// </summary>
        public string VcName { get; set; }
        /// <summary>
        /// Compute namespace
        /// Serialized Name: KubernetesProperties.namespace
        /// </summary>
        public string Namespace { get; set; }
        /// <summary>
        /// Default instance type
        /// Serialized Name: KubernetesProperties.defaultInstanceType
        /// </summary>
        public string DefaultInstanceType { get; set; }
        /// <summary>
        /// Instance Type Schema
        /// Serialized Name: KubernetesProperties.instanceTypes
        /// </summary>
        public IDictionary<string, MachineLearningInstanceTypeSchema> InstanceTypes { get; }
    }
}
