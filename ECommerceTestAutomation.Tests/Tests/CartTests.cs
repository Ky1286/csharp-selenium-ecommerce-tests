using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ECommerceTestAutomation.Tests.Pages;
using ECommerceTestAutomation.Tests.Fixtures;

namespace ECommerceTestAutomation.Tests.Tests;

public class CartTests : BaseTest
{

    [Test]
    public void AddItemToCart_UpdatesCartBadge()
    {
        var loginPage = new LoginPage(driver);
        var inventoryPage = new InventoryPage(driver);

        loginPage.NavigateToLoginPage();
        loginPage.LoginAs("standard_user", "secret_sauce");

        inventoryPage.AddBackpackToCart();

        Assert.That(inventoryPage.GetCartBadgeCount(), Is.EqualTo(1));
        Assert.That(inventoryPage.IsBackpackRemoveButtonDisplayed(), Is.True);
    }

    [Test]
    public void RemoveItemFromCart_UpdatesCartBadge()
    {
        var loginPage = new LoginPage(driver);
        var inventoryPage = new InventoryPage(driver);

        loginPage.NavigateToLoginPage();
        loginPage.LoginAs("standard_user", "secret_sauce");

        inventoryPage.AddBackpackToCart();
        inventoryPage.RemoveBackpackFromCart();

        Assert.That(inventoryPage.IsCartBadgeDisplayed(), Is.False);
    }
}