using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ECommerceTestAutomation.Tests.Utilities;

public static class WaitHelper
{
    public static IWebElement WaitUntilVisible(IWebDriver driver, By locator, int timeoutInSeconds = 10)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        return wait.Until(d =>
        {
            var element = d.FindElement(locator);
            return element.Displayed ? element : null;
        });
    }

    public static IWebElement WaitUntilClickable(IWebDriver driver, By locator, int timeoutInSeconds = 10)
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        return wait.Until(d =>
        {
            var element = d.FindElement(locator);
            return (element.Displayed && element.Enabled) ? element : null;
        });
    }
}