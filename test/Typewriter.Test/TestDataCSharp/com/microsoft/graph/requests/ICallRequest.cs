﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ICallRequest.
    /// </summary>
    public partial interface ICallRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Call using POST.
        /// </summary>
        /// <param name="callToCreate">The Call to create.</param>
        /// <returns>The created Call.</returns>
        System.Threading.Tasks.Task<Call> CreateAsync(Call callToCreate);        /// <summary>
        /// Creates the specified Call using POST.
        /// </summary>
        /// <param name="callToCreate">The Call to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Call.</returns>
        System.Threading.Tasks.Task<Call> CreateAsync(Call callToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Call.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Call.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Call and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync();

        /// <summary>
        /// Deletes the specified Call and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Call.
        /// </summary>
        /// <returns>The Call.</returns>
        System.Threading.Tasks.Task<Call> GetAsync();

        /// <summary>
        /// Gets the specified Call.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Call.</returns>
        System.Threading.Tasks.Task<Call> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Call using PATCH.
        /// </summary>
        /// <param name="callToUpdate">The Call to update.</param>
        /// <returns>The updated Call.</returns>
        System.Threading.Tasks.Task<Call> UpdateAsync(Call callToUpdate);

        /// <summary>
        /// Updates the specified Call using PATCH.
        /// </summary>
        /// <param name="callToUpdate">The Call to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Call.</returns>
        System.Threading.Tasks.Task<Call> UpdateAsync(Call callToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICallRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICallRequest Expand(Expression<Func<Call, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICallRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICallRequest Select(Expression<Func<Call, object>> selectExpression);

    }
}
