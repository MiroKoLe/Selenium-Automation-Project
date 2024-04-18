using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing.Imaging;

namespace Selenium_Automation_Project
{
    public class TestClass
    {
      Login login = new();
        public void RunTest() 
        { 
            login.LoginTest();
        
        }

    }
       
}
