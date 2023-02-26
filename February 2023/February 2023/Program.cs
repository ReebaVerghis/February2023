
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
};

//create a new Time Record
// Navigate to time and material page
IWebElement admministrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
admministrationDropdown.Click();
IWebElement timeoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeoption.Click();
Thread.Sleep(1000);

//Click Create new button
IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNewButton.Click();
Thread.Sleep(1000);

//select Time option from Typcode dropdown list
IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
typecodedropdown.Click();
Thread .Sleep(1000);
IWebElement tmOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
tmOption.Click();

//input code into code textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("February2023");

//input decription into description textbox
IWebElement descriptionTesxbox = driver.FindElement(By.Id("Description"));
descriptionTesxbox.SendKeys("February2023");

//input price per unit into price per init textbox
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("12");

//Click savebutton
IWebElement save = driver.FindElement(By.Id("SaveButton"));
save.Click();
Thread .Sleep (2000);

//Check if new time record has been created
IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPage.Click();
Thread.Sleep(5000);
//check the newcode
IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[1]"));
if(newCode.Text == "February2023")
{
    Console.WriteLine("New time record is created succesfully");
}
else
{
    Console.WriteLine("Time record is not created");
}









