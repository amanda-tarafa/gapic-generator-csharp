// Copyright 2019 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START deprecated_generated_DeprecatedService_DeprecatedMethod_async]
    using System;
    using System.Threading.Tasks;
    using Testing.Deprecated;

    public sealed partial class GeneratedDeprecatedServiceClientSnippets
    {
        /// <summary>Snippet for DeprecatedMethodAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        [ObsoleteAttribute]
        public async Task DeprecatedMethodRequestObjectAsync()
        {
            // Create client
            DeprecatedServiceClient deprecatedServiceClient = await DeprecatedServiceClient.CreateAsync();
            // Initialize request argument(s)
            Request request = new Request { };
            // Make the request
#pragma warning disable CS0612
            Response response = await deprecatedServiceClient.DeprecatedMethodAsync(request);
#pragma warning restore CS0612
        }
    }
    // [END deprecated_generated_DeprecatedService_DeprecatedMethod_async]
}
