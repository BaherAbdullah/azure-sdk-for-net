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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Update RUs per second of an Azure Cosmos DB Table. </summary>
    public partial class DatabaseAccountTableThroughputSettingCreateOrUpdateOperation : Operation<DatabaseAccountTableThroughputSetting>, IOperationSource<DatabaseAccountTableThroughputSetting>
    {
        private readonly OperationInternals<DatabaseAccountTableThroughputSetting> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of DatabaseAccountTableThroughputSettingCreateOrUpdateOperation for mocking. </summary>
        protected DatabaseAccountTableThroughputSettingCreateOrUpdateOperation()
        {
        }

        internal DatabaseAccountTableThroughputSettingCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DatabaseAccountTableThroughputSetting>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DatabaseAccountTableThroughputSettingCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DatabaseAccountTableThroughputSetting Value => _operation.Value;

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
        public override ValueTask<Response<DatabaseAccountTableThroughputSetting>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DatabaseAccountTableThroughputSetting>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DatabaseAccountTableThroughputSetting IOperationSource<DatabaseAccountTableThroughputSetting>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement);
            return new DatabaseAccountTableThroughputSetting(_operationBase, data);
        }

        async ValueTask<DatabaseAccountTableThroughputSetting> IOperationSource<DatabaseAccountTableThroughputSetting>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement);
            return new DatabaseAccountTableThroughputSetting(_operationBase, data);
        }
    }
}
