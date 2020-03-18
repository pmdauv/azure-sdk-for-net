// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NamedValueOperations.
    /// </summary>
    public static partial class NamedValueOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of NamedValues defined within a service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-properties" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<NamedValueContract> ListByService(this INamedValueOperations operations, string resourceGroupName, string serviceName, ODataQuery<NamedValueContract> odataQuery = default(ODataQuery<NamedValueContract>))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of NamedValues defined within a service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-properties" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamedValueContract>> ListByServiceAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, ODataQuery<NamedValueContract> odataQuery = default(ODataQuery<NamedValueContract>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the NamedValue specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            public static NamedValueGetEntityTagHeaders GetEntityTag(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, namedValueId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the NamedValue specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamedValueGetEntityTagHeaders> GetEntityTagAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, namedValueId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the details of the NamedValue specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            public static NamedValueContract Get(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId)
            {
                return operations.GetAsync(resourceGroupName, serviceName, namedValueId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the NamedValue specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamedValueContract> GetAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, namedValueId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static NamedValueContract CreateOrUpdate(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, NamedValueCreateContract parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, namedValueId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamedValueContract> CreateOrUpdateAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, NamedValueCreateContract parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, namedValueId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specific NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static NamedValueContract Update(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, NamedValueUpdateParameters parameters, string ifMatch)
            {
                return operations.UpdateAsync(resourceGroupName, serviceName, namedValueId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specific NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamedValueContract> UpdateAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, NamedValueUpdateParameters parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, namedValueId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes specific NamedValue from the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, namedValueId, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes specific NamedValue from the API Management service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, namedValueId, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the secret value of the NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            public static PropertyValueContract ListValue(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId)
            {
                return operations.ListValueAsync(resourceGroupName, serviceName, namedValueId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the secret value of the NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PropertyValueContract> ListValueAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListValueWithHttpMessagesAsync(resourceGroupName, serviceName, namedValueId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static NamedValueContract BeginCreateOrUpdate(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, NamedValueCreateContract parameters, string ifMatch = default(string))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serviceName, namedValueId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='parameters'>
            /// Create parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamedValueContract> BeginCreateOrUpdateAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, NamedValueCreateContract parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, namedValueId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specific NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static NamedValueContract BeginUpdate(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, NamedValueUpdateParameters parameters, string ifMatch)
            {
                return operations.BeginUpdateAsync(resourceGroupName, serviceName, namedValueId, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specific NamedValue.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='namedValueId'>
            /// Identifier of the NamedValue.
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NamedValueContract> BeginUpdateAsync(this INamedValueOperations operations, string resourceGroupName, string serviceName, string namedValueId, NamedValueUpdateParameters parameters, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, namedValueId, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists a collection of NamedValues defined within a service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-properties" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NamedValueContract> ListByServiceNext(this INamedValueOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of NamedValues defined within a service instance.
            /// <see href="https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-properties" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NamedValueContract>> ListByServiceNextAsync(this INamedValueOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}