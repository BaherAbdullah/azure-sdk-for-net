// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Creates a new AzureFrontDoor endpoint with the specified endpoint name under the specified subscription, resource group and profile. </summary>
    public partial class AfdEndpointCreateOrUpdateOperation : Operation<AfdEndpoint>, IOperationSource<AfdEndpoint>
    {
        private readonly OperationInternals<AfdEndpoint> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of AfdEndpointCreateOrUpdateOperation for mocking. </summary>
        protected AfdEndpointCreateOrUpdateOperation()
        {
        }

        internal AfdEndpointCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<AfdEndpoint>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "AfdEndpointCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AfdEndpoint Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AfdEndpoint>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AfdEndpoint>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        AfdEndpoint IOperationSource<AfdEndpoint>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = AfdEndpointData.DeserializeAfdEndpointData(document.RootElement);
            return new AfdEndpoint(_operationBase, data);
        }

        async ValueTask<AfdEndpoint> IOperationSource<AfdEndpoint>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = AfdEndpointData.DeserializeAfdEndpointData(document.RootElement);
            return new AfdEndpoint(_operationBase, data);
        }
    }
}
