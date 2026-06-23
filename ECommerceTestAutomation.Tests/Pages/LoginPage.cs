using OpenQA.Selenium;

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
        driver.FindElement(usernameInput).SendKeys(username);
        driver.FindElement(passwordInput).SendKeys(password);
        driver.FindElement(loginButton).Click();
    }

    public string GetErrorMessage()
    {
        return driver.FindElement(errorMessageLocator).Text;
    }
}