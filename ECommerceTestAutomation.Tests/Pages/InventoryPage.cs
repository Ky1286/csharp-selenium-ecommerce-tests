using OpenQA.Selenium;

namespace ECommerceTestAutomation.Tests.Pages;

public class InventoryPage
{
    private readonly IWebDriver driver;

    private readonly By inventoryContainer = By.Id("inventory_container");
    private readonly By shoppingCartLink = By.ClassName("shopping_cart_link");
    private readonly By pageTitle = By.ClassName("title");
    private readonly By addBackpackButton = By.Id("add-to-cart-sauce-labs-backpack");
    private readonly By removeBackpackButton = By.Id("remove-sauce-labs-backpack");
    private readonly By cartBadge = By.ClassName("shopping_cart_badge");

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

    public void AddBackpackToCart()
    {
        driver.FindElement(addBackpackButton).Click();
    }

    public void RemoveBackpackFromCart()
    {
        driver.FindElement(removeBackpackButton).Click();
    }

    public int GetCartBadgeCount()
    {
        return int.Parse(driver.FindElement(cartBadge).Text);
    }

    public bool IsCartBadgeDisplayed()
    {
        return driver.FindElements(cartBadge).Count > 0;
    }

    public void OpenCart()
    {
        driver.FindElement(shoppingCartLink).Click();
    }
    public bool IsBackpackRemoveButtonDisplayed()
    {
        return driver.FindElement(removeBackpackButton).Displayed;
    }
}