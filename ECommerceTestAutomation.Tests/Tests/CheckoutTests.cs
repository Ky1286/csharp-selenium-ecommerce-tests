using NUnit.Framework;
using ECommerceTestAutomation.Tests.Pages;
using ECommerceTestAutomation.Tests.Fixtures;

namespace ECommerceTestAutomation.Tests.Tests;

public class CheckoutTests : BaseTest
{
    [Test]
    public void CompleteCheckout_WithValidInfo_ShowsConfirmationMessage()
    {
        var loginPage = new LoginPage(driver);
        var inventoryPage = new InventoryPage(driver);
        var cartPage = new CartPage(driver);
        var checkoutPage = new CheckoutPage(driver);

        loginPage.NavigateToLoginPage();
        loginPage.LoginAs("standard_user", "secret_sauce");

        inventoryPage.AddBackpackToCart();
        inventoryPage.OpenCart();

        cartPage.ClickCheckout();

        checkoutPage.EnterCustomerInformation("Kenneth", "Kui", "M1A 1A1");
        checkoutPage.FinishCheckout();

        Assert.That(checkoutPage.GetConfirmationMessage(), Is.EqualTo("Thank you for your order!"));
    }
}