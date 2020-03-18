// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Models
{
    /// <summary> Represents a datasource definition, which can be used to configure an indexer. </summary>
    public partial class DataSource
    {
        /// <summary> Initializes a new instance of DataSource. </summary>
        public DataSource()
        {
        }

        /// <summary> Initializes a new instance of DataSource. </summary>
        /// <param name="name"> The name of the datasource. </param>
        /// <param name="description"> The description of the datasource. </param>
        /// <param name="type"> The type of the datasource. </param>
        /// <param name="credentials"> Credentials for the datasource. </param>
        /// <param name="container"> The data container for the datasource. </param>
        /// <param name="dataChangeDetectionPolicy"> The data change detection policy for the datasource. </param>
        /// <param name="dataDeletionDetectionPolicy"> The data deletion detection policy for the datasource. </param>
        /// <param name="eTag"> The ETag of the DataSource. </param>
        internal DataSource(string name, string description, DataSourceType type, DataSourceCredentials credentials, DataContainer container, DataChangeDetectionPolicy dataChangeDetectionPolicy, DataDeletionDetectionPolicy dataDeletionDetectionPolicy, string eTag)
        {
            Name = name;
            Description = description;
            Type = type;
            Credentials = credentials;
            Container = container;
            DataChangeDetectionPolicy = dataChangeDetectionPolicy;
            DataDeletionDetectionPolicy = dataDeletionDetectionPolicy;
            ETag = eTag;
        }

        /// <summary> The name of the datasource. </summary>
        public string Name { get; set; }
        /// <summary> The description of the datasource. </summary>
        public string Description { get; set; }
        /// <summary> The type of the datasource. </summary>
        public DataSourceType Type { get; set; }
        /// <summary> Credentials for the datasource. </summary>
        public DataSourceCredentials Credentials { get; set; } = new DataSourceCredentials();
        /// <summary> The data container for the datasource. </summary>
        public DataContainer Container { get; set; } = new DataContainer();
        /// <summary> The data change detection policy for the datasource. </summary>
        public DataChangeDetectionPolicy DataChangeDetectionPolicy { get; set; }
        /// <summary> The data deletion detection policy for the datasource. </summary>
        public DataDeletionDetectionPolicy DataDeletionDetectionPolicy { get; set; }
        /// <summary> The ETag of the DataSource. </summary>
        public string ETag { get; set; }
    }
}