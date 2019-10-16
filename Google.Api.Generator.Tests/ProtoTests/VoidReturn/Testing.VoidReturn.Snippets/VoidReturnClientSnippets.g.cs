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

namespace Testing.VoidReturn.Snippets
{
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedVoidReturnClientSnippets
    {
        /// <summary>Snippet for VoidMethod</summary>
        public void VoidMethod_RequestObject()
        {
            // Snippet: VoidMethod(Request, CallSettings)
            // Create client
            VoidReturnClient voidReturnClient = VoidReturnClient.Create();
            // Initialize request argument(s)
            Request request = new Request
            {
                ResourceName = new ResourceName("[ITEM_ID]"),
            };
            // Make the request
            voidReturnClient.VoidMethod(request);
            // End snippet
        }

        /// <summary>Snippet for VoidMethodAsync</summary>
        public async Task VoidMethodAsync_RequestObject()
        {
            // Snippet: VoidMethodAsync(Request, CallSettings)
            // Additional: VoidMethodAsync(Request, CancellationToken)
            // Create client
            VoidReturnClient voidReturnClient = await VoidReturnClient.CreateAsync();
            // Initialize request argument(s)
            Request request = new Request
            {
                ResourceName = new ResourceName("[ITEM_ID]"),
            };
            // Make the request
            await voidReturnClient.VoidMethodAsync(request);
            // End snippet
        }

        /// <summary>Snippet for VoidMethod</summary>
        public void VoidMethod()
        {
            // Snippet: VoidMethod(String, CallSettings)
            // Create client
            VoidReturnClient voidReturnClient = VoidReturnClient.Create();
            // Initialize request argument(s)
            string name = "items/[ITEM_ID]";
            // Make the request
            voidReturnClient.VoidMethod(name);
            // End snippet
        }

        /// <summary>Snippet for VoidMethodAsync</summary>
        public async Task VoidMethodAsync()
        {
            // Snippet: VoidMethodAsync(String, CallSettings)
            // Additional: VoidMethodAsync(String, CancellationToken)
            // Create client
            VoidReturnClient voidReturnClient = await VoidReturnClient.CreateAsync();
            // Initialize request argument(s)
            string name = "items/[ITEM_ID]";
            // Make the request
            await voidReturnClient.VoidMethodAsync(name);
            // End snippet
        }

        /// <summary>Snippet for VoidMethod</summary>
        public void VoidMethod_ResourceNames()
        {
            // Snippet: VoidMethod(ResourceName, CallSettings)
            // Create client
            VoidReturnClient voidReturnClient = VoidReturnClient.Create();
            // Initialize request argument(s)
            ResourceName name = new ResourceName("[ITEM_ID]");
            // Make the request
            voidReturnClient.VoidMethod(name);
            // End snippet
        }

        /// <summary>Snippet for VoidMethodAsync</summary>
        public async Task VoidMethodAsync_ResourceNames()
        {
            // Snippet: VoidMethodAsync(ResourceName, CallSettings)
            // Additional: VoidMethodAsync(ResourceName, CancellationToken)
            // Create client
            VoidReturnClient voidReturnClient = await VoidReturnClient.CreateAsync();
            // Initialize request argument(s)
            ResourceName name = new ResourceName("[ITEM_ID]");
            // Make the request
            await voidReturnClient.VoidMethodAsync(name);
            // End snippet
        }
    }
}