using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetetionT2.Utilities;

namespace CompetetionT2.Pages
{
    public class Shareskill
    {

        public void SkillsPage(IWebDriver driver)
        {


            //click shareskill botton
            IWebElement shareskillbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a"));
            shareskillbutton.Click();

            //click on title and enter title
            IWebElement title = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            title.SendKeys("Design");

            //click on description and enter description
            IWebElement description = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            description.SendKeys("digital painting");

            //select a category
            IWebElement category = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select"));
            category.Click();

            IWebElement categoryOption = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]"));
            categoryOption.Click();

            //select a subcategory
            IWebElement subCategoryselect = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subCategoryselect.Click();

            IWebElement subCategory = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[4]"));
            subCategory.Click();

            //enter tag value
            IWebElement tag = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input"));
            tag.SendKeys("A4");
            tag.SendKeys(Keys.Enter);


            //SERVICE TYPE
            IWebElement servicetype = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input"));
            servicetype.Click();

            //location type
            IWebElement locationtype = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
              locationtype.Click();

            //availabledays
            IWebElement startDate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[2]/input"));
            startDate.Click();

            IWebElement endDate = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            endDate.Click();

            //.....................


            //skilltrade
            IWebElement credit = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[2]/div/input"));
            credit.Click();

            //creditvalue
            IWebElement creditValue = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/input"));
            creditValue.SendKeys("2");


            //active
            IWebElement active = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            active.Click();

            //save button
            IWebElement savebutton = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]"));
            savebutton.Click();


        }
    }
}