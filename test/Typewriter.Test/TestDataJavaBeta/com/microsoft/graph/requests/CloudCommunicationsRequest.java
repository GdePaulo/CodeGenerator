// Template Source: BaseEntityRequest.java.tt
// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph.requests;

import com.microsoft.graph.http.IRequestBuilder;
import com.microsoft.graph.core.ClientException;
import com.microsoft.graph.models.CloudCommunications;
import com.microsoft.graph.requests.CallCollectionRequestBuilder;
import com.microsoft.graph.requests.CallRequestBuilder;
import com.microsoft.graph2.callrecords.requests.CallRecordCollectionRequestBuilder;
import com.microsoft.graph2.callrecords.requests.CallRecordRequestBuilder;
import java.util.Arrays;
import java.util.EnumSet;
import javax.annotation.Nullable;
import javax.annotation.Nonnull;
import com.microsoft.graph.core.IBaseClient;
import com.microsoft.graph.http.BaseRequest;
import com.microsoft.graph.http.HttpMethod;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The class for the Cloud Communications Request.
 */
public class CloudCommunicationsRequest extends BaseRequest<CloudCommunications> {
	
    /**
     * The request for the CloudCommunications
     *
     * @param requestUrl     the request URL
     * @param client         the service client
     * @param requestOptions the options for this request
     */
    public CloudCommunicationsRequest(@Nonnull final String requestUrl, @Nonnull final IBaseClient client, @Nullable final java.util.List<? extends com.microsoft.graph.options.Option> requestOptions) {
        super(requestUrl, client, requestOptions, CloudCommunications.class);
    }

    /**
     * Gets the CloudCommunications from the service
     *
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<CloudCommunications> getAsync() {
        return sendAsync(HttpMethod.GET, null);
    }

    /**
     * Gets the CloudCommunications from the service
     *
     * @return the CloudCommunications from the request
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public CloudCommunications get() throws ClientException {
       return send(HttpMethod.GET, null);
    }

    /**
     * Delete this item from the service
     *
     * @return a future with the deletion result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<CloudCommunications> deleteAsync() {
        return sendAsync(HttpMethod.DELETE, null);
    }

    /**
     * Delete this item from the service
     * @return the resulting response if the service returns anything on deletion
     *
     * @throws ClientException if there was an exception during the delete operation
     */
    @Nullable
    public CloudCommunications delete() throws ClientException {
        return send(HttpMethod.DELETE, null);
    }

    /**
     * Patches this CloudCommunications with a source
     *
     * @param sourceCloudCommunications the source object with updates
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<CloudCommunications> patchAsync(@Nonnull final CloudCommunications sourceCloudCommunications) {
        return sendAsync(HttpMethod.PATCH, sourceCloudCommunications);
    }

    /**
     * Patches this CloudCommunications with a source
     *
     * @param sourceCloudCommunications the source object with updates
     * @return the updated CloudCommunications
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public CloudCommunications patch(@Nonnull final CloudCommunications sourceCloudCommunications) throws ClientException {
        return send(HttpMethod.PATCH, sourceCloudCommunications);
    }

    /**
     * Creates a CloudCommunications with a new object
     *
     * @param newCloudCommunications the new object to create
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<CloudCommunications> postAsync(@Nonnull final CloudCommunications newCloudCommunications) {
        return sendAsync(HttpMethod.POST, newCloudCommunications);
    }

    /**
     * Creates a CloudCommunications with a new object
     *
     * @param newCloudCommunications the new object to create
     * @return the created CloudCommunications
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public CloudCommunications post(@Nonnull final CloudCommunications newCloudCommunications) throws ClientException {
        return send(HttpMethod.POST, newCloudCommunications);
    }

    /**
     * Creates a CloudCommunications with a new object
     *
     * @param newCloudCommunications the object to create/update
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<CloudCommunications> putAsync(@Nonnull final CloudCommunications newCloudCommunications) {
        return sendAsync(HttpMethod.PUT, newCloudCommunications);
    }

    /**
     * Creates a CloudCommunications with a new object
     *
     * @param newCloudCommunications the object to create/update
     * @return the created CloudCommunications
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public CloudCommunications put(@Nonnull final CloudCommunications newCloudCommunications) throws ClientException {
        return send(HttpMethod.PUT, newCloudCommunications);
    }

    /**
     * Sets the select clause for the request
     *
     * @param value the select clause
     * @return the updated request
     */
     @Nonnull
     public CloudCommunicationsRequest select(@Nonnull final String value) {
         addSelectOption(value);
         return this;
     }

    /**
     * Sets the expand clause for the request
     *
     * @param value the expand clause
     * @return the updated request
     */
     @Nonnull
     public CloudCommunicationsRequest expand(@Nonnull final String value) {
         addExpandOption(value);
         return this;
     }

}

