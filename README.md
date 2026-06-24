# C# Selenium E-Commerce Test Automation Suite

[![.NET Selenium Tests](https://github.com/Ky1286/csharp-selenium-ecommerce-tests/actions/workflows/dotnet-tests.yml/badge.svg)](https://github.com/Ky1286/csharp-selenium-ecommerce-tests/actions/workflows/dotnet-tests.yml)

## Project Overview

This project is a C# Selenium WebDriver test automation suite for a demo e-commerce application. It validates core user workflows including login, cart management, checkout, and form validation.

The goal of this project is to demonstrate a maintainable UI test automation using NUnit, Page Object Model, explicit waits, and GitHub Actions CI.

## Tech Stack

- C#
- .NET
- Selenium WebDriver
- NUnit
- ChromeDriver
- Page Object Model
- Explicit waits

## Test Coverage

| Test Area | Test Case | Validation |
|---|---|---|
| Login | Valid user can log in | Verifies successful authentication and inventory page load |
| Login | Invalid password shows error | Verifies login validation messaging |
| Cart | Add item to cart | Verifies cart badge updates and remove button appears |
| Cart | Remove item from cart | Verifies cart badge disappears when cart is empty |
| Checkout | Complete checkout with valid info | Verifies full end-to-end checkout flow |
| Checkout | Missing first name shows error | Verifies checkout form validation |

## Framework Structure
```
ECommerceTestAutomation.Tests/
├── Fixtures/
│   └── BaseTest.cs
├── Pages/
│   ├── LoginPage.cs
│   ├── InventoryPage.cs
│   ├── CartPage.cs
│   └── CheckoutPage.cs
├── Tests/
│   ├── LoginTests.cs
│   ├── CartTests.cs
│   └── CheckoutTests.cs
└── Utilities/
    └── WaitHelper.cs
```

## Key Practices Demonstrated

- Page Object Model for maintainable test structure
- Shared setup and teardown using a base test fixture
- Explicit waits to reduce flaky UI interactions
- Positive and negative test coverage
- End-to-end workflow validation
- GitHub Actions CI for automated test execution

## How to Run Tests Locally

1. Clone the repository.
2. Ensure .NET SDK and Google Chrome are installed.
3. Restore dependencies:

```bash
dotnet restore
```
### To run:
```bash
dotnet test
```

## Future Improvements

- Add API tests for supporting backend endpoints
- Add test categories for smoke and regression suites
- Add screenshots on test failure
- Add test reporting
- Support multiple browsers
- Add data-driven tests for multiple login scenarios