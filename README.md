# frontend-automation-csharp

A minimal Selenium starter framework in C# targeting .NET 8.

## Purpose

This repository provides a simple browser bootstrap for new contributors so they can start writing their own tests without being forced into a specific structure or test pattern.

## Structure

SeleniumTests.slnx
├── Core/
│   ├── Config/
│   │   └── TestSettings.cs
│   ├── Factories/
│   │   └── WebDriverFactory.cs
│   └── Core.csproj
└── ProjectA.Tests/
    └── ProjectA.Tests.csproj

## Included packages

- Selenium.WebDriver
- Selenium.Support
- WebDriverManager
- xUnit
- Microsoft.NET.Test.Sdk

## Build

Run the following from the repository root:

```bash
dotnet restore
dotnet build
```

The browser factory uses WebDriverManager to resolve the ChromeDriver automatically, so contributors can focus on their own test design and implementation.