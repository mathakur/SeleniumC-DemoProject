using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace NUnitTestProjectV1
{
    public class Tests : DriverHelper
    {
        
        [SetUp]
        public void Setup()
        {
            
            driver = new ChromeDriver("C:\\Drivers");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("test method");
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']//following-sibling::div[text()='Lettuce']")).Click();
            var Combonbox = driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
            Combonbox.Clear();
            Combonbox.SendKeys("C");
            driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//following-sibling::li[text()='Celery']")).Click();
                                           //div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//following-sibling::li[text()='Celery']

            CustomController control = new CustomController();
            control.ComboBox("ContentPlaceHolder1_AllMealsCombo", "CeleryM");


            driver.Quit();
        }
    }
}
