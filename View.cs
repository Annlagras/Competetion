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



    public class View
    {

        public void Seller_View(IWebDriver driver)
        {
            //navigate to managelisting page
            driver.Navigate().GoToUrl("http://localhost:5000/Home/ListingManagement");

            //click on view button
          //  IWebElement section = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]"));
         //   section.Click();

            IWebElement viewbutton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]"));
            viewbutton.Click();
            driver.Navigate().GoToUrl("http://localhost:5000/Home/ServiceDetail?id=648c6870d739e20001dd6d83");
            Thread.Sleep(1000);



        }

    }
}