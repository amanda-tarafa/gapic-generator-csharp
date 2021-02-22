﻿// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Testing.Paginated.Snippets
{
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPaginatedClientStandaloneSnippets
    {
        /// <summary>Snippet for SignatureMethod</summary>
        public async Task SignatureMethod3Async()
        {
            // Snippet: SignatureMethodAsync(string, int?, CallSettings)
            // Create client
            PaginatedClient paginatedClient = await PaginatedClient.CreateAsync();
            // Make the request
            PagedAsyncEnumerable<Response, Response.Types.NestedResult> response = paginatedClient.SignatureMethodAsync();

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Response.Types.NestedResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((Response page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Response.Types.NestedResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Response.Types.NestedResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Response.Types.NestedResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}