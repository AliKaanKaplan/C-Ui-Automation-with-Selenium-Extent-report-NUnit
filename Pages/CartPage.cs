using MeDirectUiProject.Helpers;
using MeDirectUiProject.PageElements;
using OpenQA.Selenium;

namespace MeDirectUiProject.Pages
{
    public class CartPage
    {
        private readonly IWebDriver _driver;
        private CommonElements _commonElements;
        private CartPageElements _cartPageElements;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
            _commonElements = new CommonElements(driver);
            _cartPageElements = new CartPageElements(driver);
        }

        public void clickCartButton()
        {
            SeleniumHelper.clickToElement(_driver, _commonElements.cartButton);
        }


        public void verifyAddedProduct()
        {
            SeleniumHelper.IsElementDisplayed(_driver, _cartPageElements.removeButton);
        }

        public void isDisplayQuantityCard()
        {
            SeleniumHelper.IsElementDisplayed(_driver, _cartPageElements.quantityCard);
        }

        public void isDisplayProductName()
        {
            SeleniumHelper.IsElementDisplayed(_driver, _cartPageElements.productName);
        }

        public void isDisplayProductDescription()
        {
            SeleniumHelper.IsElementDisplayed(_driver, _cartPageElements.productDetailsDesc);
        }

        public void isDisplayProductPrice()
        {
            SeleniumHelper.IsElementDisplayed(_driver, _cartPageElements.productPrice);
        }

        public void clickRemoveButton()
        {
            SeleniumHelper.clickToElement(_driver, _cartPageElements.removeButton);
        }

        public void clickContinueShopping()
        {
            SeleniumHelper.clickToElement(_driver, _cartPageElements.continueShoppingButton);
        }

        public void clickCheckoutButton()
        {
            SeleniumHelper.clickToElement(_driver, _cartPageElements.checkoutButton);
        }
    }
}
