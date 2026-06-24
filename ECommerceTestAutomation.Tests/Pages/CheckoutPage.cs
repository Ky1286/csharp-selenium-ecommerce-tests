using OpenQA.Selenium;
using ECommerceTestAutomation.Tests.Utilities;

namespace ECommerceTestAutomation.Tests.Pages;

public class CheckoutPage
{
    private readonly IWebDriver driver;
    private readonly By firstNameInput = By.Id("first-name");
    private readonly By lastNameInput = By.Id("last-name");
    private readonly By postalCodeInput = By.Id("postal-code");
    private readonly By continueButton = By.Id("continue");
    private readonly By finishButton = By.Id("finish");
    private readonly By confirmationHeader = By.ClassName("complete-header");

    public CheckoutPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void EnterCustomerInformation(string firstName, string lastName, string postalCode)
    {
        driver.FindElement(firstNameInput).SendKeys(firstName);
        driver.FindElement(lastNameInput).SendKeys(lastName);
        driver.FindElement(postalCodeInput).SendKeys(postalCode);
        WaitHelper.WaitUntilClickable(driver, continueButton).Click();
    }

    public void FinishCheckout()
    {
        WaitHelper.WaitUntilClickable(driver, finishButton).Click();
    }

    public string GetConfirmationMessage()
    {
        return WaitHelper.WaitUntilVisible(driver, confirmationHeader).Text;
    }
}