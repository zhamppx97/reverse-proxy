// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Microsoft.ReverseProxy.Configuration.Contract
{
    /// <summary>
    /// Describes the matching criteria for a route.
    /// </summary>
    public class ProxyMatchData
    {
        /// <summary>
        /// Only match requests that use these optional HTTP methods. E.g. GET, POST.
        /// </summary>
        public IReadOnlyList<string> Methods { get; set; }

        /// <summary>
        /// Only match requests with the given Host header.
        /// </summary>
        public IReadOnlyList<string> Hosts { get; set; }

        /// <summary>
        /// Only match requests with the given Path pattern.
        /// </summary>
        public string Path { get; set; }

        // TODO:
        /// <summary>
        /// Only match requests that contain all of these query parameters.
        /// </summary>
        // public ICollection<KeyValuePair<string, string>> QueryParameters { get; set; }

        /// <summary>
        /// Only match requests that contain all of these headers.
        /// </summary>
        public IReadOnlyList<RouteHeaderData> Headers { get; set; }
    }
}
