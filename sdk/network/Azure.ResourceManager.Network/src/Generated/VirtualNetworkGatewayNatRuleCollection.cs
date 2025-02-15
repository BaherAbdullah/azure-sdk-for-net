// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualNetworkGatewayNatRule and their operations over its parent. </summary>
    public partial class VirtualNetworkGatewayNatRuleCollection : ArmCollection, IEnumerable<VirtualNetworkGatewayNatRule>, IAsyncEnumerable<VirtualNetworkGatewayNatRule>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualNetworkGatewayNatRulesRestOperations _virtualNetworkGatewayNatRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayNatRuleCollection"/> class for mocking. </summary>
        protected VirtualNetworkGatewayNatRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayNatRuleCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkGatewayNatRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(VirtualNetworkGatewayNatRule.ResourceType, out string apiVersion);
            _virtualNetworkGatewayNatRulesRestClient = new VirtualNetworkGatewayNatRulesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualNetworkGateway.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualNetworkGateway.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public virtual VirtualNetworkGatewayNatRuleCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken);
                var operation = new VirtualNetworkGatewayNatRuleCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualNetworkGatewayNatRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a nat rule to a scalable virtual network gateway if it doesn&apos;t exist else updates the existing nat rules. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="natRuleParameters"> Parameters supplied to create or Update a Nat Rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> or <paramref name="natRuleParameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkGatewayNatRuleCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string natRuleName, VirtualNetworkGatewayNatRuleData natRuleParameters, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }
            if (natRuleParameters == null)
            {
                throw new ArgumentNullException(nameof(natRuleParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualNetworkGatewayNatRuleCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _virtualNetworkGatewayNatRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, natRuleParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a nat rule. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayNatRule> Get(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a nat rule. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGatewayNatRule>> GetAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayNatRule> GetIfExists(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayNatRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkGatewayNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkGatewayNatRule>> GetIfExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayNatRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualNetworkGatewayNatRule>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayNatRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(natRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natRuleName"> The name of the nat rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string natRuleName, CancellationToken cancellationToken = default)
        {
            if (natRuleName == null)
            {
                throw new ArgumentNullException(nameof(natRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(natRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkGatewayNatRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkGatewayNatRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayNatRulesRestClient.ListByVirtualNetworkGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkGatewayNatRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualNetworkGatewayNatRulesRestClient.ListByVirtualNetworkGatewayNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all nat rules for a particular virtual network gateway. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGatewayNatRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkGatewayNatRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkGatewayNatRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayNatRulesRestClient.ListByVirtualNetworkGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkGatewayNatRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayNatRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualNetworkGatewayNatRulesRestClient.ListByVirtualNetworkGatewayNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkGatewayNatRule(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<VirtualNetworkGatewayNatRule> IEnumerable<VirtualNetworkGatewayNatRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkGatewayNatRule> IAsyncEnumerable<VirtualNetworkGatewayNatRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, VirtualNetworkGatewayNatRule, VirtualNetworkGatewayNatRuleData> Construct() { }
    }
}
