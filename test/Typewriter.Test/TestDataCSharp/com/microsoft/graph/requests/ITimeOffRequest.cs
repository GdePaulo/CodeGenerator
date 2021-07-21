// ------------------------------------------------------------------------------
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
    /// The interface ITimeOffRequest.
    /// </summary>
    public partial interface ITimeOffRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TimeOff using POST.
        /// </summary>
        /// <param name="timeOffToCreate">The TimeOff to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> CreateAsync(TimeOff timeOffToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified TimeOff using POST and returns a <see cref="GraphResponse{TimeOff}"/> object.
        /// </summary>
        /// <param name="timeOffToCreate">The TimeOff to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TimeOff}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TimeOff>> CreateResponseAsync(TimeOff timeOffToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TimeOff.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified TimeOff and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TimeOff.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified TimeOff and returns a <see cref="GraphResponse{TimeOff}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{TimeOff}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TimeOff>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TimeOff using PATCH.
        /// </summary>
        /// <param name="timeOffToUpdate">The TimeOff to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TimeOff.</returns>
        System.Threading.Tasks.Task<TimeOff> UpdateAsync(TimeOff timeOffToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TimeOff using PATCH and returns a <see cref="GraphResponse{TimeOff}"/> object.
        /// </summary>
        /// <param name="timeOffToUpdate">The TimeOff to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{TimeOff}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<TimeOff>> UpdateResponseAsync(TimeOff timeOffToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TimeOff using PUT.
        /// </summary>
        /// <param name="timeOffToUpdate">The TimeOff object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<TimeOff> PutAsync(TimeOff timeOffToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified TimeOff using PUT and returns a <see cref="GraphResponse{TimeOff}"/> object.
        /// </summary>
        /// <param name="timeOffToUpdate">The TimeOff object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{TimeOff}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<TimeOff>> PutResponseAsync(TimeOff timeOffToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequest Expand(Expression<Func<TimeOff, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITimeOffRequest Select(Expression<Func<TimeOff, object>> selectExpression);

    }
}
