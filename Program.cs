using CompetetionT2.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

IWebDriver driver = new ChromeDriver();

driver.Manage().Window.Maximize();


// Login page object Initialization and definition
Login login = new Login();
login.Seller_Login_Page(driver);



// Delete object Initialization and definition
ManageListings delete = new ManageListings();
delete.Seller_Delete(driver);


// Edit object initialization and definition
Edit editobj = new Edit();
editobj.Seller_Edit(driver);
//Thread.Sleep(1000);



// View object Initialization and definition
View sellerview =  new View();
sellerview.Seller_View(driver);
//Thread.Sleep(1000);

// Shareskill object Initialization and definition
Shareskill sharePageObj = new Shareskill();
sharePageObj.SkillsPage(driver);
//Thread.Sleep(1000);
