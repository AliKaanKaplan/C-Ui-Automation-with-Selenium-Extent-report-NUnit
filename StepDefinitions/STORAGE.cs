using MeDirectUiProject.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeDirectUiProject.StepDefinitions
{
    [Binding]
    public sealed class STORAGE
    {
        private IWebDriver driver;
        private readonly HomePage _homePage;

        public STORAGE(IWebDriver driver)
        {
            this.driver = driver;
            _homePage = new HomePage(driver);
        }

        [Given("BASIT1")]
        public void Deneme1()
        {
          
        }

        [When("User enters {string} and {string}")]
        public void Deneme1234(string username, string password)
        {
           
        }

        [Given(@"User has selected a product with code ([A-Z0-9]{6})")]
        public void Deneme12345(string productCode)
        {
           
        }

        [When(@"User adds (\d+) products to the cart")]
        public void Deneme123456(int quantity)
        {
            
        }

        [Then(@"User should receive an error message containing '(.+)'")]
        public void Deneme1234567(string errorMessage)
        {
           
        }

        /*
         Senaryo: Ürün arama
    Verilen Kullanıcı ana sayfada
    When Kullanıcı "[searchTerm]" için arama yapar
    Sonuç Kullanıcı sonuçları "[expectedResultCount]" olarak görür

    Örnekler:
    | searchTerm  | expectedResultCount |
    | Telefon     | 10                  |
    | Laptop      | 5                   |



        Senaryo: Ürün miktarı kontrolü
    Verilen Kullanıcı sepetine <productCount> ürün ekler
    Sonuç Kullanıcı sepetindeki ürün sayısı <productCount> ile eşleşir

    Senaryo Dışı Şablon:
    | productCount |
    | 0            |
    | 3            |
    | 5            |

        */




    }
}