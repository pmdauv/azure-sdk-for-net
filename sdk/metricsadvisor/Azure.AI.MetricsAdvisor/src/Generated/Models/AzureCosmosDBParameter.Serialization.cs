// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class AzureCosmosDBParameter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("connectionString");
            writer.WriteStringValue(ConnectionString);
            writer.WritePropertyName("sqlQuery");
            writer.WriteStringValue(SqlQuery);
            writer.WritePropertyName("database");
            writer.WriteStringValue(Database);
            writer.WritePropertyName("collectionId");
            writer.WriteStringValue(CollectionId);
            writer.WriteEndObject();
        }

        internal static AzureCosmosDBParameter DeserializeAzureCosmosDBParameter(JsonElement element)
        {
            string connectionString = default;
            string sqlQuery = default;
            string database = default;
            string collectionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionString"))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlQuery"))
                {
                    sqlQuery = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("database"))
                {
                    database = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collectionId"))
                {
                    collectionId = property.Value.GetString();
                    continue;
                }
            }
            return new AzureCosmosDBParameter(connectionString, sqlQuery, database, collectionId);
        }
    }
}
