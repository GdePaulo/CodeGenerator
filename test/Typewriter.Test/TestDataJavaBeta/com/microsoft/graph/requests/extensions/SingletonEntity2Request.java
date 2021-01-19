// Template Source: BaseEntityRequest.java.tt
// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph.requests.extensions;

import com.microsoft.graph.http.IRequestBuilder;
import com.microsoft.graph.core.ClientException;
import com.microsoft.graph.models.extensions.SingletonEntity2;
import com.microsoft.graph.requests.extensions.EntityType3RequestBuilder;
import java.util.Arrays;
import java.util.EnumSet;
import javax.annotation.Nullable;
import javax.annotation.Nonnull;
import com.microsoft.graph.core.IBaseClient;
import com.microsoft.graph.http.BaseRequest;
import com.microsoft.graph.http.HttpMethod;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The class for the Singleton Entity2Request.
 */
public class SingletonEntity2Request extends BaseRequest<SingletonEntity2> {
	
    /**
     * The request for the SingletonEntity2
     *
     * @param requestUrl     the request URL
     * @param client         the service client
     * @param requestOptions the options for this request
     */
    public SingletonEntity2Request(@Nonnull final String requestUrl, @Nonnull final IBaseClient client, @Nullable final java.util.List<? extends com.microsoft.graph.options.Option> requestOptions) {
        super(requestUrl, client, requestOptions, SingletonEntity2.class);
    }

    /**
     * Gets the SingletonEntity2 from the service
     *
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<SingletonEntity2> getAsync() {
        return sendAsync(HttpMethod.GET, null);
    }

    /**
     * Gets the SingletonEntity2 from the service
     *
     * @return the SingletonEntity2 from the request
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public SingletonEntity2 get() throws ClientException {
       return send(HttpMethod.GET, null);
    }

    /**
     * Delete this item from the service
     *
     * @return a future with the deletion result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<SingletonEntity2> deleteAsync() {
        return sendAsync(HttpMethod.DELETE, null);
    }

    /**
     * Delete this item from the service
     * @return the resulting response if the service returns anything on deletion
     *
     * @throws ClientException if there was an exception during the delete operation
     */
    @Nullable
    public SingletonEntity2 delete() throws ClientException {
        return send(HttpMethod.DELETE, null);
    }

    /**
     * Patches this SingletonEntity2 with a source
     *
     * @param sourceSingletonEntity2 the source object with updates
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<SingletonEntity2> patchAsync(@Nonnull final SingletonEntity2 sourceSingletonEntity2) {
        return sendAsync(HttpMethod.PATCH, sourceSingletonEntity2);
    }

    /**
     * Patches this SingletonEntity2 with a source
     *
     * @param sourceSingletonEntity2 the source object with updates
     * @return the updated SingletonEntity2
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public SingletonEntity2 patch(@Nonnull final SingletonEntity2 sourceSingletonEntity2) throws ClientException {
        return send(HttpMethod.PATCH, sourceSingletonEntity2);
    }

    /**
     * Creates a SingletonEntity2 with a new object
     *
     * @param newSingletonEntity2 the new object to create
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<SingletonEntity2> postAsync(@Nonnull final SingletonEntity2 newSingletonEntity2) {
        return sendAsync(HttpMethod.POST, newSingletonEntity2);
    }

    /**
     * Creates a SingletonEntity2 with a new object
     *
     * @param newSingletonEntity2 the new object to create
     * @return the created SingletonEntity2
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public SingletonEntity2 post(@Nonnull final SingletonEntity2 newSingletonEntity2) throws ClientException {
        return send(HttpMethod.POST, newSingletonEntity2);
    }

    /**
     * Creates a SingletonEntity2 with a new object
     *
     * @param newSingletonEntity2 the object to create/update
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<SingletonEntity2> putAsync(@Nonnull final SingletonEntity2 newSingletonEntity2) {
        return sendAsync(HttpMethod.PUT, newSingletonEntity2);
    }

    /**
     * Creates a SingletonEntity2 with a new object
     *
     * @param newSingletonEntity2 the object to create/update
     * @return the created SingletonEntity2
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public SingletonEntity2 put(@Nonnull final SingletonEntity2 newSingletonEntity2) throws ClientException {
        return send(HttpMethod.PUT, newSingletonEntity2);
    }

    /**
     * Sets the select clause for the request
     *
     * @param value the select clause
     * @return the updated request
     */
     @Nonnull
     public SingletonEntity2Request select(@Nonnull final String value) {
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
     public SingletonEntity2Request expand(@Nonnull final String value) {
         addExpandOption(value);
         return this;
     }

}

