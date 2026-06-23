using OpenQA.Selenium;

namespace ECommerceTestAutomation.Tests.Pages;

public class InventoryPage
{
    private readonly IWebDriver driver;

    private readonly By inventoryContainer = By.Id("inventory_container");
    private readonly By shoppingCartLink = By.ClassName("shopping_cart_link");
    private readonly By pageTitle = By.ClassName("title");

    public InventoryPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public bool IsLoaded()
    {
        return driver.Url.Contains("inventory") &&
                driver.FindElement(inventoryContainer).Displayed &&
                driver.FindElement(pageTitle).Text == "Products";
    }

    public bool IsShoppingCartDisplayed()
    {
        return driver.FindElement(shoppingCartLink).Displayed;
    }
}