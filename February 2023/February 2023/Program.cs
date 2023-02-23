
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//open the browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//check the user name textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("Hari");

//check the password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");
//identify the login button ang click
IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();
//check if user is succesfully loggedin
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("logged in sucessfully");
}
else
{
    Console.WriteLine("login failed");
}














     