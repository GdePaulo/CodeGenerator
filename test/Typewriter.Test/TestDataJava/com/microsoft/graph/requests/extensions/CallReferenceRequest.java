// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph.requests.extensions;

import com.microsoft.graph.http.IRequestBuilder;
import com.microsoft.graph.core.ClientException;
import com.microsoft.graph.concurrency.ICallback;
import com.microsoft.graph.models.extensions.Call;
import java.util.Arrays;
import java.util.EnumSet;

import com.microsoft.graph.options.QueryOption;
import com.microsoft.graph.http.BaseRequest;
import com.microsoft.graph.http.HttpMethod;
import com.microsoft.graph.core.IBaseClient;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The class for the Call Reference Request.
 */
public class CallReferenceRequest extends BaseRequest implements ICallReferenceRequest {

    /**
     * The request for the Call
     *
     * @param requestUrl     the request URL
     * @param client         the service client
     * @param requestOptions the options for this request
     */
    public CallReferenceRequest(String requestUrl, IBaseClient client, java.util.List<? extends com.microsoft.graph.options.Option> requestOptions) {
        super(requestUrl, client, requestOptions, Call.class);
    }

    public void delete(final ICallback<Call> callback) {
        send(HttpMethod.DELETE, callback, null);
    }

    public Call delete() throws ClientException {
       return send(HttpMethod.DELETE, null);
    }

    /**
     * Sets the select clause for the request
     *
     * @param value the select clause
     * @return the updated request
     */
    public ICallReferenceRequest select(final String value) {
        getQueryOptions().add(new com.microsoft.graph.options.QueryOption("$select", value));
        return (CallReferenceRequest)this;
    }

    /**
     * Sets the expand clause for the request
     *
     * @param value the expand clause
     * @return the updated request
     */
    public ICallReferenceRequest expand(final String value) {
        getQueryOptions().add(new com.microsoft.graph.options.QueryOption("$expand", value));
        return (CallReferenceRequest)this;
    }
    /**
     * Puts the Call
     *
     * @param srcCall the Call reference to PUT
     * @param callback the callback to be called after success or failure
     */
    public void put(Call srcCall, final ICallback<Call> callback) {
        send(HttpMethod.PUT, callback, srcCall);
    }

    /**
     * Puts the Call
     *
     * @param srcCall the Call reference to PUT
     * @return the Call
     * @throws ClientException an exception occurs if there was an error while the request was sent
     */
    public Call put(Call srcCall) throws ClientException {
        return send(HttpMethod.PUT, srcCall);
    }
}