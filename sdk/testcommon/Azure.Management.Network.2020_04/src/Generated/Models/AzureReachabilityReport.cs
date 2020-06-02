// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Management.Network.Models
{
    /// <summary> Azure reachability report details. </summary>
    public partial class AzureReachabilityReport
    {
        /// <summary> Initializes a new instance of AzureReachabilityReport. </summary>
        /// <param name="aggregationLevel"> The aggregation level of Azure reachability report. Can be Country, State or City. </param>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="reachabilityReport"> List of Azure reachability report items. </param>
        internal AzureReachabilityReport(string aggregationLevel, AzureReachabilityReportLocation providerLocation, IEnumerable<AzureReachabilityReportItem> reachabilityReport)
        {
            if (aggregationLevel == null)
            {
                throw new ArgumentNullException(nameof(aggregationLevel));
            }
            if (providerLocation == null)
            {
                throw new ArgumentNullException(nameof(providerLocation));
            }
            if (reachabilityReport == null)
            {
                throw new ArgumentNullException(nameof(reachabilityReport));
            }

            AggregationLevel = aggregationLevel;
            ProviderLocation = providerLocation;
            ReachabilityReport = reachabilityReport.ToArray();
        }

        /// <summary> Initializes a new instance of AzureReachabilityReport. </summary>
        /// <param name="aggregationLevel"> The aggregation level of Azure reachability report. Can be Country, State or City. </param>
        /// <param name="providerLocation"> Parameters that define a geographic location. </param>
        /// <param name="reachabilityReport"> List of Azure reachability report items. </param>
        internal AzureReachabilityReport(string aggregationLevel, AzureReachabilityReportLocation providerLocation, IReadOnlyList<AzureReachabilityReportItem> reachabilityReport)
        {
            AggregationLevel = aggregationLevel;
            ProviderLocation = providerLocation;
            ReachabilityReport = reachabilityReport;
        }

        /// <summary> The aggregation level of Azure reachability report. Can be Country, State or City. </summary>
        public string AggregationLevel { get; }
        /// <summary> Parameters that define a geographic location. </summary>
        public AzureReachabilityReportLocation ProviderLocation { get; }
        /// <summary> List of Azure reachability report items. </summary>
        public IReadOnlyList<AzureReachabilityReportItem> ReachabilityReport { get; }
    }
}