// ------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

package com.microsoft.graph.requests.extensions;
import com.microsoft.graph.models.extensions.TimeOff;

import com.microsoft.graph.concurrency.ICallback;
import com.microsoft.graph.core.ClientException;
import com.microsoft.graph.http.IHttpRequest;

// **NOTE** This file was generated by a tool and any changes will be overwritten.

/**
 * The interface for the Time Off Request.
 */
public interface ITimeOffRequest extends IHttpRequest {

    /**
     * Gets the TimeOff from the service
     *
     * @param callback the callback to be called after success or failure
     */
    void get(final ICallback<TimeOff> callback);

    /**
     * Gets the TimeOff from the service
     *
     * @return the TimeOff from the request
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    TimeOff get() throws ClientException;

    /**
     * Delete this item from the service
     *
     * @param callback the callback when the deletion action has completed
     */
    void delete(final ICallback<TimeOff> callback);

    /**
     * Delete this item from the service
     *
     * @throws ClientException if there was an exception during the delete operation
     */
    void delete() throws ClientException;

    /**
     * Patches this TimeOff with a source
     *
     * @param sourceTimeOff the source object with updates
     * @param callback the callback to be called after success or failure
     */
    void patch(final TimeOff sourceTimeOff, final ICallback<TimeOff> callback);

    /**
     * Patches this TimeOff with a source
     *
     * @param sourceTimeOff the source object with updates
     * @return the updated TimeOff
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    TimeOff patch(final TimeOff sourceTimeOff) throws ClientException;

    /**
     * Posts a TimeOff with a new object
     *
     * @param newTimeOff the new object to create
     * @param callback the callback to be called after success or failure
     */
    void post(final TimeOff newTimeOff, final ICallback<TimeOff> callback);

    /**
     * Posts a TimeOff with a new object
     *
     * @param newTimeOff the new object to create
     * @return the created TimeOff
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    TimeOff post(final TimeOff newTimeOff) throws ClientException;

    /**
     * Posts a TimeOff with a new object
     *
     * @param newTimeOff the object to create/update
     * @param callback the callback to be called after success or failure
     */
    void put(final TimeOff newTimeOff, final ICallback<TimeOff> callback);

    /**
     * Posts a TimeOff with a new object
     *
     * @param newTimeOff the object to create/update
     * @return the created TimeOff
     * @throws ClientException this exception occurs if the request was unable to complete for any reason
     */
    TimeOff put(final TimeOff newTimeOff) throws ClientException;

    /**
     * Sets the select clause for the request
     *
     * @param value the select clause
     * @return the updated request
     */
    ITimeOffRequest select(final String value);

    /**
     * Sets the expand clause for the request
     *
     * @param value the expand clause
     * @return the updated request
     */
    ITimeOffRequest expand(final String value);

}

