// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IManagementTemplateCollectionRequest.
    /// </summary>
    public partial interface IManagementTemplateCollectionRequest : Microsoft.Graph.IBaseRequest
    {
        /// <summary>
        /// Creates the specified ManagementTemplateCollection using POST.
        /// </summary>
        /// <param name="managementTemplateCollectionToCreate">The ManagementTemplateCollection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ManagementTemplateCollection.</returns>
        System.Threading.Tasks.Task<ManagementTemplateCollection> CreateAsync(ManagementTemplateCollection managementTemplateCollectionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ManagementTemplateCollection using POST and returns a <see cref="GraphResponse{ManagementTemplateCollection}"/> object.
        /// </summary>
        /// <param name="managementTemplateCollectionToCreate">The ManagementTemplateCollection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementTemplateCollection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateCollection>> CreateResponseAsync(ManagementTemplateCollection managementTemplateCollectionToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagementTemplateCollection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ManagementTemplateCollection and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagementTemplateCollection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ManagementTemplateCollection.</returns>
        System.Threading.Tasks.Task<ManagementTemplateCollection> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ManagementTemplateCollection and returns a <see cref="GraphResponse{ManagementTemplateCollection}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ManagementTemplateCollection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateCollection>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementTemplateCollection using PATCH.
        /// </summary>
        /// <param name="managementTemplateCollectionToUpdate">The ManagementTemplateCollection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ManagementTemplateCollection.</returns>
        System.Threading.Tasks.Task<ManagementTemplateCollection> UpdateAsync(ManagementTemplateCollection managementTemplateCollectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementTemplateCollection using PATCH and returns a <see cref="GraphResponse{ManagementTemplateCollection}"/> object.
        /// </summary>
        /// <param name="managementTemplateCollectionToUpdate">The ManagementTemplateCollection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ManagementTemplateCollection}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateCollection>> UpdateResponseAsync(ManagementTemplateCollection managementTemplateCollectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementTemplateCollection using PUT.
        /// </summary>
        /// <param name="managementTemplateCollectionToUpdate">The ManagementTemplateCollection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ManagementTemplateCollection> PutAsync(ManagementTemplateCollection managementTemplateCollectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ManagementTemplateCollection using PUT and returns a <see cref="GraphResponse{ManagementTemplateCollection}"/> object.
        /// </summary>
        /// <param name="managementTemplateCollectionToUpdate">The ManagementTemplateCollection object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ManagementTemplateCollection}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ManagementTemplateCollection>> PutResponseAsync(ManagementTemplateCollection managementTemplateCollectionToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementTemplateCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IManagementTemplateCollectionRequest Expand(Expression<Func<ManagementTemplateCollection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementTemplateCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IManagementTemplateCollectionRequest Select(Expression<Func<ManagementTemplateCollection, object>> selectExpression);

    }
}