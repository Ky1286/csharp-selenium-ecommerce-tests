using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ECommerceTestAutomation.Tests.Pages;

namespace ECommerceTestAutomation.Tests.Tests
{
    public class LoginTests
    {
        private IWebDriver driver = null!;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void ValidUser_CanLogin()
        {
            var loginPage = new LoginPage(driver);
            var inventoryPage = new InventoryPage(driver);

            loginPage.NavigateToLoginPage();
            loginPage.LoginAs("standard_user", "secret_sauce");

            Assert.That(inventoryPage.IsLoaded(), Is.True);
        }

        [Test]
        public void InvalidPassword_ShowsErrorMessage()
        {
            var loginPage = new LoginPage(driver);

            loginPage.NavigateToLoginPage();
            loginPage.LoginAs("standard_user", "wrong_password");

            Assert.That(loginPage.GetErrorMessage(), Does.Contain("Username and password do not match"));
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
            driver?.Dispose();
        }
    }
}