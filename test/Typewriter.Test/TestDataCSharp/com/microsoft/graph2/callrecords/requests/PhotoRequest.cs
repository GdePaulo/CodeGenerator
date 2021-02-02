// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph2.CallRecords
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type PhotoRequest.
    /// </summary>
    public partial class PhotoRequest : Microsoft.Graph.BaseRequest, IPhotoRequest
    {
        /// <summary>
        /// Constructs a new PhotoRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PhotoRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Photo using POST.
        /// </summary>
        /// <param name="photoToCreate">The Photo to create.</param>
        /// <returns>The created Photo.</returns>
        public System.Threading.Tasks.Task<Photo> CreateAsync(Photo photoToCreate)
        {
            return this.CreateAsync(photoToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Photo using POST.
        /// </summary>
        /// <param name="photoToCreate">The Photo to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Photo.</returns>
        public async System.Threading.Tasks.Task<Photo> CreateAsync(Photo photoToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Photo>(photoToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Photo.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Photo.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Photo>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Photo and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync()
        {
            return this.DeleteResponseAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Photo and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public async System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            return await this.SendAsyncWithGraphResponse(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Photo.
        /// </summary>
        /// <returns>The Photo.</returns>
        public System.Threading.Tasks.Task<Photo> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Photo.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Photo.</returns>
        public async System.Threading.Tasks.Task<Photo> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Photo>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Photo using PATCH.
        /// </summary>
        /// <param name="photoToUpdate">The Photo to update.</param>
        /// <returns>The updated Photo.</returns>
        public System.Threading.Tasks.Task<Photo> UpdateAsync(Photo photoToUpdate)
        {
            return this.UpdateAsync(photoToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Photo using PATCH.
        /// </summary>
        /// <param name="photoToUpdate">The Photo to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Photo.</returns>
        public async System.Threading.Tasks.Task<Photo> UpdateAsync(Photo photoToUpdate, CancellationToken cancellationToken)
        {
			if (photoToUpdate.AdditionalData != null)
			{
				if (photoToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
					photoToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
				{
					throw new Microsoft.Graph.ClientException(
						new Microsoft.Graph.Error
						{
							Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
							Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, photoToUpdate.GetType().Name)
						});
				}
			}
            if (photoToUpdate.AdditionalData != null)
            {
                if (photoToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.ResponseHeaders) ||
                    photoToUpdate.AdditionalData.ContainsKey(Microsoft.Graph.Constants.HttpPropertyNames.StatusCode))
                {
                    throw new Microsoft.Graph.ClientException(
                        new Microsoft.Graph.Error
                        {
                            Code = Microsoft.Graph.GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(Microsoft.Graph.GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, photoToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Photo>(photoToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPhotoRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPhotoRequest Expand(Expression<Func<Photo, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IPhotoRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPhotoRequest Select(Expression<Func<Photo, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="photoToInitialize">The <see cref="Photo"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Photo photoToInitialize)
        {

        }
    }
}
