using OpenQA.Selenium;
using ECommerceTestAutomation.Tests.Utilities;

namespace ECommerceTestAutomation.Tests.Pages;

public class LoginPage
{
    private readonly IWebDriver driver;

    private readonly By usernameInput = By.Id("user-name");
    private readonly By passwordInput = By.Id("password");
    private readonly By loginButton = By.Id("login-button");
    private readonly By errorMessageLocator = By.CssSelector("[data-test='error']");

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void NavigateToLoginPage()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    }

    public void LoginAs(string username, string password)
    {
        WaitHelper.WaitUntilVisible(driver, usernameInput).SendKeys(username);
        WaitHelper.WaitUntilVisible(driver, passwordInput).SendKeys(password);
        WaitHelper.WaitUntilClickable(driver, loginButton).Click();
    }

    public string GetErrorMessage()
    {
        return driver.FindElement(errorMessageLocator).Text;
    }
}