using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ECommerceTestAutomation.Tests.Fixtures;

public class BaseTest
{
    protected IWebDriver driver = null!;

    [SetUp]
    public void SetUp()
    {
        var options = new ChromeOptions();

        options.AddUserProfilePreference("credentials_enable_service", false);
        options.AddUserProfilePreference("profile.password_manager_enabled", false);
        options.AddUserProfilePreference("profile.password_manager_leak_detection", false);

        options.AddArgument("--disable-save-password-bubble");
        options.AddArgument("--disable-features=PasswordLeakDetection,PasswordManagerOnboarding,PasswordCheck");
        options.AddArgument("--disable-notifications");
        options.AddArgument("--incognito");

        driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        driver?.Quit();
        driver?.Dispose();
    }
}