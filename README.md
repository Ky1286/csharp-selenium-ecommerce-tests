# C# Selenium E-Commerce Test Automation Suite

[![.NET Selenium Tests](https://github.com/Ky1286/csharp-selenium-ecommerce-tests/actions/workflows/dotnet-tests.yml/badge.svg)](https://github.com/Ky1286/csharp-selenium-ecommerce-tests/actions/workflows/dotnet-tests.yml)

This project is a UI test automation suite for a demo e-commerce application using C#, Selenium WebDriver, NUnit, and the Page Object Model pattern.

## Tech Stack

- C#
- .NET
- Selenium WebDriver
- NUnit
- ChromeDriver
- Page Object Model
- Explicit waits

## Test Coverage

Current automated tests cover:

- Successful login
- Invalid login validation
- Adding an item to the cart
- Removing an item from the cart
- Completing checkout with valid customer information
- Checkout validation when first name is missing

## Framework Structure

- `Tests/` contains NUnit test cases
- `Pages/` contains Page Object Model classes
- `Fixtures/BaseTest.cs` handles browser setup and teardown
- `Utilities/WaitHelper.cs` handles explicit waits

## How to Run

```bash
dotnet test
