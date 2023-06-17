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
    public class ManageListings
    {

        public void Seller_Delete(IWebDriver driver)
        {

            //navigate to managelisting page

            IWebElement table = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]"));
                        driver.Navigate().GoToUrl("http://localhost:5000/Home/ListingManagement");

            //IWebElement column = table.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/thead/tr/th[8]"));

            //click on remove button
             IWebElement tablerow1 = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[2]/td[8]"));
            tablerow1.Click();

            IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[2]/td[8]/div/button[3]"));
            deletebutton.Click();

            //click delete button
            IWebElement deleteYes = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            deleteYes.Click();

            Thread.Sleep(1000);
        }

    }






}
