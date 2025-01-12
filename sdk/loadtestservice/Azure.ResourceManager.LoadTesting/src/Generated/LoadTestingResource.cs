// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.LoadTesting.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LoadTesting
{
    /// <summary>
    /// A Class representing a LoadTesting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="LoadTestingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetLoadTestingResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetLoadTesting method.
    /// </summary>
    public partial class LoadTestingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="LoadTestingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string loadTestName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _loadTestingLoadTestsClientDiagnostics;
        private readonly LoadTestsRestOperations _loadTestingLoadTestsRestClient;
        private readonly LoadTestingData _data;

        /// <summary> Initializes a new instance of the <see cref="LoadTestingResource"/> class for mocking. </summary>
        protected LoadTestingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "LoadTestingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal LoadTestingResource(ArmClient client, LoadTestingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="LoadTestingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal LoadTestingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _loadTestingLoadTestsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.LoadTesting", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string loadTestingLoadTestsApiVersion);
            _loadTestingLoadTestsRestClient = new LoadTestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, loadTestingLoadTestsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.LoadTestService/loadTests";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual LoadTestingData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a LoadTest resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}
        /// Operation Id: LoadTests_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LoadTestingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.Get");
            scope.Start();
            try
            {
                var response = await _loadTestingLoadTestsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadTestingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a LoadTest resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}
        /// Operation Id: LoadTests_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LoadTestingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.Get");
            scope.Start();
            try
            {
                var response = _loadTestingLoadTestsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LoadTestingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a LoadTest resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}
        /// Operation Id: LoadTests_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.Delete");
            scope.Start();
            try
            {
                var response = await _loadTestingLoadTestsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new LoadTestingArmOperation(_loadTestingLoadTestsClientDiagnostics, Pipeline, _loadTestingLoadTestsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a LoadTest resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}
        /// Operation Id: LoadTests_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.Delete");
            scope.Start();
            try
            {
                var response = _loadTestingLoadTestsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                var operation = new LoadTestingArmOperation(_loadTestingLoadTestsClientDiagnostics, Pipeline, _loadTestingLoadTestsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a loadtest resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}
        /// Operation Id: LoadTests_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> LoadTest resource update data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual async Task<ArmOperation<LoadTestingResource>> UpdateAsync(WaitUntil waitUntil, LoadTestingPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.Update");
            scope.Start();
            try
            {
                var response = await _loadTestingLoadTestsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken).ConfigureAwait(false);
                var operation = new LoadTestingArmOperation<LoadTestingResource>(new LoadTestingOperationSource(Client), _loadTestingLoadTestsClientDiagnostics, Pipeline, _loadTestingLoadTestsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update a loadtest resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}
        /// Operation Id: LoadTests_Update
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="patch"> LoadTest resource update data. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patch"/> is null. </exception>
        public virtual ArmOperation<LoadTestingResource> Update(WaitUntil waitUntil, LoadTestingPatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(patch, nameof(patch));

            using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.Update");
            scope.Start();
            try
            {
                var response = _loadTestingLoadTestsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch, cancellationToken);
                var operation = new LoadTestingArmOperation<LoadTestingResource>(new LoadTestingOperationSource(Client), _loadTestingLoadTestsClientDiagnostics, Pipeline, _loadTestingLoadTestsRestClient.CreateUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, patch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the endpoints that agents may call as part of load testing.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}/outboundNetworkDependenciesEndpoints
        /// Operation Id: LoadTests_ListOutboundNetworkDependenciesEndpoints
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OutboundEnvironmentEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OutboundEnvironmentEndpoint> GetOutboundNetworkDependenciesEndpointsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<OutboundEnvironmentEndpoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.GetOutboundNetworkDependenciesEndpoints");
                scope.Start();
                try
                {
                    var response = await _loadTestingLoadTestsRestClient.ListOutboundNetworkDependenciesEndpointsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OutboundEnvironmentEndpoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.GetOutboundNetworkDependenciesEndpoints");
                scope.Start();
                try
                {
                    var response = await _loadTestingLoadTestsRestClient.ListOutboundNetworkDependenciesEndpointsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists the endpoints that agents may call as part of load testing.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.LoadTestService/loadTests/{loadTestName}/outboundNetworkDependenciesEndpoints
        /// Operation Id: LoadTests_ListOutboundNetworkDependenciesEndpoints
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OutboundEnvironmentEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OutboundEnvironmentEndpoint> GetOutboundNetworkDependenciesEndpoints(CancellationToken cancellationToken = default)
        {
            Page<OutboundEnvironmentEndpoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.GetOutboundNetworkDependenciesEndpoints");
                scope.Start();
                try
                {
                    var response = _loadTestingLoadTestsRestClient.ListOutboundNetworkDependenciesEndpoints(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OutboundEnvironmentEndpoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _loadTestingLoadTestsClientDiagnostics.CreateScope("LoadTestingResource.GetOutboundNetworkDependenciesEndpoints");
                scope.Start();
                try
                {
                    var response = _loadTestingLoadTestsRestClient.ListOutboundNetworkDependenciesEndpointsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
