using OpenQA.Selenium;

namespace ECommerceTestAutomation.Tests.Pages;

public class CartPage
{
    private readonly IWebDriver driver;
    private readonly By checkoutButton = By.Id("checkout");

    public CartPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void ClickCheckout()
    {
        driver.FindElement(checkoutButton).Click();
    }
}