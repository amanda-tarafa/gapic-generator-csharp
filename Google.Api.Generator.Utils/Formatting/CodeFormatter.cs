﻿// Copyright 2018 Google Inc. All Rights Reserved.
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

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Google.Api.Generator.Utils.Formatting
{
    public static class CodeFormatter
    {
        public static CompilationUnitSyntax Format(CompilationUnitSyntax code)
        {
            var whitespace = new WhitespaceFormatter(maxLineLength: 120);
            code = (CompilationUnitSyntax) whitespace.Visit(code);
            code = PragmaWarningFormatter.Visit(code);
            // TODO: Line length formatting
            return code;
        }
    }
}
