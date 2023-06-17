using CompetetionT2.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetetionT2.Pages
{



    public class Edit
    {
        public void Seller_Edit(IWebDriver driver)

        {
            driver.Manage().Window.Maximize();

            //navigate to managelisting page
            driver.Navigate().GoToUrl("http://localhost:5000/Home/ListingManagement");

            //click on Edit button
           IWebElement editbutton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[4]/td[8]/div/button[2]"));
            editbutton.Click();

            Thread.Sleep(1000);

            //save button
            IWebElement savebutton1 = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            savebutton1.Click();


        }

    }
}