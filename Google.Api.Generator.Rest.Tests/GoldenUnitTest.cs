// Copyright 2020 Google LLC
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

using Xunit;

namespace Google.Api.Generator.Rest.Tests
{
    public class GoldenUnitTest
    {
        [Fact]
        public void Webfonts() => TestResources.TestOutput("Google.Apis.Webfonts.v1");

        [Fact]
        public void Storage() => TestResources.TestOutput("Google.Apis.Storage.v1");

        [Fact]
        public void Translate() => TestResources.TestOutput("Google.Apis.Translate.v2");

        [Fact]
        public void ManufacturerCenter() => TestResources.TestOutput("Google.Apis.ManufacturerCenter.v1");

        [Fact]
        public void CloudSupport() => TestResources.TestOutput("Google.Apis.CloudSupport.v2");

        [Fact]
        public void Metastore() => TestResources.TestOutput("Google.Apis.DataprocMetastore.v1");

        [Fact]
        public void Calendar() => TestResources.TestOutput("Google.Apis.Calendar.v3");

        [Fact]
        public void Assuredworkloads() => TestResources.TestOutput("Google.Apis.Assuredworkloads.v1");

        [Fact]
        public void CloudRun() => TestResources.TestOutput("Google.Apis.CloudRun.v1");
    }
}
