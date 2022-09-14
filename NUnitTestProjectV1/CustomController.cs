using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProjectV1
{
    public class CustomController : DriverHelper


    {
        public void ComboBox(string container, string value)
        {
            var Combonbox = driver.FindElement(By.XPath($"//input[@id='{container}-awed']"));
            Combonbox.Clear();
            Combonbox.SendKeys($"{value}");
            driver.FindElement(By.XPath($"//div[@id='{container}-dropmenu']//following-sibling::li[text()='{value}']")).Click();
        }

    }
}
