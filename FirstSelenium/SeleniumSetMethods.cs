using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
   public class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText( string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click a button, Checkbox, option ect. 
        public static void Click( string element, string elementtype)
        {
            if (elementtype == "Id")
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }
        //Selecting drop down control
        public static void SelectDropDown( string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }

    }
}
