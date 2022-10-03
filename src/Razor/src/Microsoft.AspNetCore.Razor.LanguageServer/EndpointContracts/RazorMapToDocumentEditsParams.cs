﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Razor.LanguageServer.Protocol;
using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.AspNetCore.Razor.LanguageServer.EndpointContracts
{
    internal class RazorMapToDocumentEditsParams
    {
        public RazorLanguageKind Kind { get; init; }

        public required Uri RazorDocumentUri { get; init; }

        public required TextEdit[] ProjectedTextEdits { get; init; }

        public TextEditKind TextEditKind { get; init; }

        public required FormattingOptions FormattingOptions { get; init; }
    }
}