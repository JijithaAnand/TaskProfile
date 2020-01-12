using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
    public class LoginPage
    {
        public void profileclick()
        {
            
            Driver.waitVisiblity(Driver.driver, "XPath", "//*[@id='account-profile-section']/div/section[1]/div/a[2]");
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();
            //skill
           // Driver.driver.FindElement(By.XPath("/ html / body / div[1] / div / section[2] / div / div / div / div[3] / form / div[1] / a[2]")).Click();
        
        }
       
        public void LoginStep()
        {
            Driver.NavigateUrl();
            //Thread.Sleep(1500);
            //Enter Url
            //Utils.ExcelLibHelpers.PopulateInCollection(@"C:\Users\JIJI\source\repos\SpecflowTests-Base\SpecflowTests\SpecflowTests\TestData\TestDatas.xls", "LoginPage");
            
            Driver.driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")).Click();
                  //Enter Username
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("test@yahoo.com");

            //Enter password
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("123456");
            Thread.Sleep(1000);
            //Click on Login Button
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
            
        }

    }
}
