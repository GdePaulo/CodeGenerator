// Template Source: BaseEntityRequest.java.tt
// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph.managedtenants.requests;

import com.microsoft.graph.http.IRequestBuilder;
import com.microsoft.graph.core.ClientException;
import com.microsoft.graph.managedtenants.models.ManagementTemplate;
import java.util.Arrays;
import java.util.EnumSet;
import javax.annotation.Nullable;
import javax.annotation.Nonnull;
import com.microsoft.graph.core.IBaseClient;
import com.microsoft.graph.http.BaseRequest;
import com.microsoft.graph.http.HttpMethod;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The class for the Management Template Request.
 */
public class ManagementTemplateRequest extends BaseRequest<ManagementTemplate> {
	
    /**
     * The request for the ManagementTemplate
     *
     * @param requestUrl     the request URL
     * @param client         the service client
     * @param requestOptions the options for this request
     */
    public ManagementTemplateRequest(@Nonnull final String requestUrl, @Nonnull final IBaseClient<?> client, @Nullable final java.util.List<? extends com.microsoft.graph.options.Option> requestOptions) {
        super(requestUrl, client, requestOptions, ManagementTemplate.class);
    }

    /**
     * Gets the ManagementTemplate from the service
     *
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<ManagementTemplate> getAsync() {
        return sendAsync(HttpMethod.GET, null);
    }

    /**
     * Gets the ManagementTemplate from the service
     *
     * @return the ManagementTemplate from the request
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public ManagementTemplate get() throws ClientException {
       return send(HttpMethod.GET, null);
    }

    /**
     * Delete this item from the service
     *
     * @return a future with the deletion result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<ManagementTemplate> deleteAsync() {
        return sendAsync(HttpMethod.DELETE, null);
    }

    /**
     * Delete this item from the service
     * @return the resulting response if the service returns anything on deletion
     *
     * @throws ClientException if there was an exception during the delete operation
     */
    @Nullable
    public ManagementTemplate delete() throws ClientException {
        return send(HttpMethod.DELETE, null);
    }

    /**
     * Patches this ManagementTemplate with a source
     *
     * @param sourceManagementTemplate the source object with updates
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<ManagementTemplate> patchAsync(@Nonnull final ManagementTemplate sourceManagementTemplate) {
        return sendAsync(HttpMethod.PATCH, sourceManagementTemplate);
    }

    /**
     * Patches this ManagementTemplate with a source
     *
     * @param sourceManagementTemplate the source object with updates
     * @return the updated ManagementTemplate
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public ManagementTemplate patch(@Nonnull final ManagementTemplate sourceManagementTemplate) throws ClientException {
        return send(HttpMethod.PATCH, sourceManagementTemplate);
    }

    /**
     * Creates a ManagementTemplate with a new object
     *
     * @param newManagementTemplate the new object to create
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<ManagementTemplate> postAsync(@Nonnull final ManagementTemplate newManagementTemplate) {
        return sendAsync(HttpMethod.POST, newManagementTemplate);
    }

    /**
     * Creates a ManagementTemplate with a new object
     *
     * @param newManagementTemplate the new object to create
     * @return the created ManagementTemplate
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public ManagementTemplate post(@Nonnull final ManagementTemplate newManagementTemplate) throws ClientException {
        return send(HttpMethod.POST, newManagementTemplate);
    }

    /**
     * Creates a ManagementTemplate with a new object
     *
     * @param newManagementTemplate the object to create/update
     * @return a future with the result
     */
    @Nonnull
    public java.util.concurrent.CompletableFuture<ManagementTemplate> putAsync(@Nonnull final ManagementTemplate newManagementTemplate) {
        return sendAsync(HttpMethod.PUT, newManagementTemplate);
    }

    /**
     * Creates a ManagementTemplate with a new object
     *
     * @param newManagementTemplate the object to create/update
     * @return the created ManagementTemplate
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    @Nullable
    public ManagementTemplate put(@Nonnull final ManagementTemplate newManagementTemplate) throws ClientException {
        return send(HttpMethod.PUT, newManagementTemplate);
    }

    /**
     * Sets the select clause for the request
     *
     * @param value the select clause
     * @return the updated request
     */
     @Nonnull
     public ManagementTemplateRequest select(@Nonnull final String value) {
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
     public ManagementTemplateRequest expand(@Nonnull final String value) {
         addExpandOption(value);
         return this;
     }

}

