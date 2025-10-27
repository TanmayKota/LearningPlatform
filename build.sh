#!/bin/bash
dotnet add package Microsoft.AspNetCore.Components.WebAssembly --version <version> \
    && dotnet add package Microsoft.AspNetCore.Components.WebAssembly.DevServer --version <version> \
    && dotnet add package Microsoft.Extensions.Configuration.Binder --version <version>
