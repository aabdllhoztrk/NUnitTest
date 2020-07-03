using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    public class Program
    {
        

        static void Main(string[] args)
        {
          
        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            Console.WriteLine("Opened Url");
        }

        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", "Id");

            SeleniumSetMethods.EnterText( "Initial", "Software Test", "Name");

            Console.WriteLine("The value from my title is: " + SeleniumGetMethods.GetText( "TitleId","Id"));
            Console.WriteLine("The value from my initial is: " + SeleniumGetMethods.GetText( "Initial", "Name"));
            

            SeleniumSetMethods.EnterText( "FirstName", "Abdullah", "Name");

            Console.WriteLine("The value from my username is " + SeleniumGetMethods.GetText( "FirstName", "Name"));

            SeleniumSetMethods.EnterText( "MiddleName", "Ozturk", "Name");

            SeleniumSetMethods.Click( "Save", "Name");
        }
        [TearDown]
        public void CleanUp()
        {

            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }

}
