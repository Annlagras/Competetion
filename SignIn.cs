using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetetionT2.Pages;
using CompetetionT2.Utilities;

namespace CompetetionT2.TestClass
{
    public class SignIn
    {


        public void SignInclass()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();


            // Login page object Initialization and definition
            Login login = new Login();
            login.Seller_Login_Page(driver);

            // LanguagePage object Initialization and definition

            Shareskill sharePageObj = new Shareskill();
            sharePageObj.SkillsPage(driver);

        }
    }
}
 