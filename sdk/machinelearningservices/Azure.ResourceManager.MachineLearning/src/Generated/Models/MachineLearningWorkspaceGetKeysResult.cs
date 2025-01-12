// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningWorkspaceGetKeysResult.
    /// Serialized Name: ListWorkspaceKeysResult
    /// </summary>
    public partial class MachineLearningWorkspaceGetKeysResult
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspaceGetKeysResult. </summary>
        internal MachineLearningWorkspaceGetKeysResult()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningWorkspaceGetKeysResult. </summary>
        /// <param name="userStorageKey"> Serialized Name: ListWorkspaceKeysResult.userStorageKey. </param>
        /// <param name="userStorageResourceId"> Serialized Name: ListWorkspaceKeysResult.userStorageResourceId. </param>
        /// <param name="appInsightsInstrumentationKey"> Serialized Name: ListWorkspaceKeysResult.appInsightsInstrumentationKey. </param>
        /// <param name="containerRegistryCredentials"> Serialized Name: ListWorkspaceKeysResult.containerRegistryCredentials. </param>
        /// <param name="notebookAccessKeys"> Serialized Name: ListWorkspaceKeysResult.notebookAccessKeys. </param>
        internal MachineLearningWorkspaceGetKeysResult(string userStorageKey, string userStorageResourceId, string appInsightsInstrumentationKey, MachineLearningContainerRegistryCredentials containerRegistryCredentials, MachineLearningWorkspaceGetNotebookKeysResult notebookAccessKeys)
        {
            UserStorageKey = userStorageKey;
            UserStorageResourceId = userStorageResourceId;
            AppInsightsInstrumentationKey = appInsightsInstrumentationKey;
            ContainerRegistryCredentials = containerRegistryCredentials;
            NotebookAccessKeys = notebookAccessKeys;
        }

        /// <summary> Serialized Name: ListWorkspaceKeysResult.userStorageKey. </summary>
        public string UserStorageKey { get; }
        /// <summary> Serialized Name: ListWorkspaceKeysResult.userStorageResourceId. </summary>
        public string UserStorageResourceId { get; }
        /// <summary> Serialized Name: ListWorkspaceKeysResult.appInsightsInstrumentationKey. </summary>
        public string AppInsightsInstrumentationKey { get; }
        /// <summary> Serialized Name: ListWorkspaceKeysResult.containerRegistryCredentials. </summary>
        public MachineLearningContainerRegistryCredentials ContainerRegistryCredentials { get; }
        /// <summary> Serialized Name: ListWorkspaceKeysResult.notebookAccessKeys. </summary>
        public MachineLearningWorkspaceGetNotebookKeysResult NotebookAccessKeys { get; }
    }
}
