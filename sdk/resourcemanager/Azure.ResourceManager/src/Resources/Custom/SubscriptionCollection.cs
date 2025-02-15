// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of Subscription and their operations over its parent. </summary>
    [CodeGenSuppress("SubscriptionCollection", typeof(ArmResource))]
    public partial class SubscriptionCollection : ArmCollection, IEnumerable<Subscription>, IAsyncEnumerable<Subscription>

    {
        /// <summary> Initializes a new instance of the <see cref="SubscriptionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubscriptionCollection(Tenant parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _subscriptionsRestClient = new SubscriptionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary>
        /// Gets the parent resource of this resource.
        /// </summary>
        protected new Tenant Parent { get { return base.Parent as Tenant; } }
    }
}
