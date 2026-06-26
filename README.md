# Blazor ComboBox - Pass Extra Parameters to ValueChange Handler

A Blazor sample demonstrating how to pass additional parameters to the `ValueChange` event handler of [Blazor ComboBox](https://www.syncfusion.com/blazor-components/blazor-combobox), enabling context-aware event handling with multiple ComboBox instances.

## Overview

This repository demonstrates a common scenario in Blazor applications: passing extra parameters to the `ValueChange` event handler of Blazor ComboBox components. Instead of relying solely on the `ChangeEventArgs`, you can pass additional context data to your event handlers, making it easier to manage state across multiple ComboBox instances or execute different logic based on the source component.

The sample includes two ComboBox instances bound to the same data source, each with its own event handler that receives an identifier parameter to distinguish between them.

## Features

- **Lambda Expression Event Binding** — Demonstrates using lambda expressions to capture and pass additional parameters to event handlers
- **Multi-Instance ComboBox Handling** — Shows how to manage multiple ComboBox components with distinct identifiers
- **Context-Aware Event Logic** — Execute different operations based on which ComboBox instance triggered the event
- **Type-Safe Implementation** — Fully typed generic ComboBox with `TValue` and `TItem` parameters
- **Data Source Binding** — Demonstrates binding ComboBox to strongly-typed data sources with field mapping
- **Interactive Server Rendering** — Built with Blazor Server components for real-time interactivity

## Prerequisites

* [.NET SDK 10.0](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) or later
* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
* [Visual Studio Code](https://code.visualstudio.com/)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/How-can-to-pass-an-extra-parameter-to-Blazor-ComboBox-ValueChange-handler.git
cd How-can-to-pass-an-extra-parameter-to-Blazor-ComboBox-ValueChange-handler
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run
```

## References

**Documentation**: https://blazor.syncfusion.com/documentation/combobox/getting-started-with-server-app

**Online example**: https://blazor.syncfusion.com/demos/combobox/default-functionalities?theme=fluent2