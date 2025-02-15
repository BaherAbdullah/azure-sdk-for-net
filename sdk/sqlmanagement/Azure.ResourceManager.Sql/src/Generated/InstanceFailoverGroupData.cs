// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the InstanceFailoverGroup data model. </summary>
    public partial class InstanceFailoverGroupData : Resource
    {
        /// <summary> Initializes a new instance of InstanceFailoverGroupData. </summary>
        public InstanceFailoverGroupData()
        {
            PartnerRegions = new ChangeTrackingList<PartnerRegionInfo>();
            ManagedInstancePairs = new ChangeTrackingList<ManagedInstancePairInfo>();
        }

        /// <summary> Initializes a new instance of InstanceFailoverGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="readWriteEndpoint"> Read-write endpoint of the failover group instance. </param>
        /// <param name="readOnlyEndpoint"> Read-only endpoint of the failover group instance. </param>
        /// <param name="replicationRole"> Local replication role of the failover group instance. </param>
        /// <param name="replicationState"> Replication state of the failover group instance. </param>
        /// <param name="partnerRegions"> Partner region information for the failover group. </param>
        /// <param name="managedInstancePairs"> List of managed instance pairs in the failover group. </param>
        internal InstanceFailoverGroupData(ResourceIdentifier id, string name, ResourceType type, InstanceFailoverGroupReadWriteEndpoint readWriteEndpoint, InstanceFailoverGroupReadOnlyEndpoint readOnlyEndpoint, InstanceFailoverGroupReplicationRole? replicationRole, string replicationState, IList<PartnerRegionInfo> partnerRegions, IList<ManagedInstancePairInfo> managedInstancePairs) : base(id, name, type)
        {
            ReadWriteEndpoint = readWriteEndpoint;
            ReadOnlyEndpoint = readOnlyEndpoint;
            ReplicationRole = replicationRole;
            ReplicationState = replicationState;
            PartnerRegions = partnerRegions;
            ManagedInstancePairs = managedInstancePairs;
        }

        /// <summary> Read-write endpoint of the failover group instance. </summary>
        public InstanceFailoverGroupReadWriteEndpoint ReadWriteEndpoint { get; set; }
        /// <summary> Read-only endpoint of the failover group instance. </summary>
        public InstanceFailoverGroupReadOnlyEndpoint ReadOnlyEndpoint { get; set; }
        /// <summary> Local replication role of the failover group instance. </summary>
        public InstanceFailoverGroupReplicationRole? ReplicationRole { get; }
        /// <summary> Replication state of the failover group instance. </summary>
        public string ReplicationState { get; }
        /// <summary> Partner region information for the failover group. </summary>
        public IList<PartnerRegionInfo> PartnerRegions { get; }
        /// <summary> List of managed instance pairs in the failover group. </summary>
        public IList<ManagedInstancePairInfo> ManagedInstancePairs { get; }
    }
}
