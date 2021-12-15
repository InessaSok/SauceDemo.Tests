using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SauceDemo.Tests.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;
        public BasePage (IWebDriver driver)
        {
            this.driver = driver;
        }
         
    }
}
