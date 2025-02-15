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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The operation to update the VMSS VM extension. </summary>
    public partial class VirtualMachineScaleSetVmExtensionUpdateOperation : Operation<VirtualMachineScaleSetVmExtension>, IOperationSource<VirtualMachineScaleSetVmExtension>
    {
        private readonly OperationInternals<VirtualMachineScaleSetVmExtension> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmExtensionUpdateOperation for mocking. </summary>
        protected VirtualMachineScaleSetVmExtensionUpdateOperation()
        {
        }

        internal VirtualMachineScaleSetVmExtensionUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineScaleSetVmExtension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualMachineScaleSetVmExtensionUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineScaleSetVmExtension Value => _operation.Value;

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
        public override ValueTask<Response<VirtualMachineScaleSetVmExtension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineScaleSetVmExtension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualMachineScaleSetVmExtension IOperationSource<VirtualMachineScaleSetVmExtension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualMachineScaleSetVmExtensionData.DeserializeVirtualMachineScaleSetVmExtensionData(document.RootElement);
            return new VirtualMachineScaleSetVmExtension(_operationBase, data);
        }

        async ValueTask<VirtualMachineScaleSetVmExtension> IOperationSource<VirtualMachineScaleSetVmExtension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualMachineScaleSetVmExtensionData.DeserializeVirtualMachineScaleSetVmExtensionData(document.RootElement);
            return new VirtualMachineScaleSetVmExtension(_operationBase, data);
        }
    }
}
