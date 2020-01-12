using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using SpecflowPages.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.Utils
{
    public class Start : Driver
    {
        [BeforeScenario]
        public void SetUp()
        {
            //Launch the browser
            Initialize();
            Thread.Sleep(500);

            //Call the Login Class  
            LoginPage loginPage = new LoginPage();
            loginPage.LoginStep();
        }

        [AfterScenario]
        public void TearDown()
        {
            Thread.Sleep(500);
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));
            //Close the browser
            //Close();

            // end test. (Reports)
            extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Screenshot
            

            //Close the browser
            Close();
        }
       public void Description()
        {

            Initialize();
            Thread.Sleep(500);

            //Call the Login Class  
            LoginPage loginPage = new LoginPage();
            loginPage.LoginStep();
            loginPage.profileclick();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i")).Click();
            //Add First Name
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]")).Clear();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]")).SendKeys("Jijitha");
            //Add Last Name
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]")).Clear();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]")).SendKeys("Anand");
            //Click on Save
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button")).Click();

            //Click on Add New button
            Thread.Sleep(1500);
            waitVisiblity(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div");
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            //Add Language
            //  waitVisiblity(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input");
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[1];
            Lang.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

            //Click description
            Thread.Sleep(1500);
            //Driver.waitVisiblity(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span");
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span")).Click();

            //Add description

            //Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Text;
            Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).Clear();
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")).SendKeys("Hi, have experience with eWam, which uses Gold language");
            //Click save
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();
            //click on share skill
            Thread.Sleep(1500);
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div[2]/a")).Click();
            //wait
            Driver.waitVisiblity(Driver.driver, "XPath", "/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input");
            //Add Title
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input")).SendKeys("eWam");
            //Add Description
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea")).SendKeys("Automation and Manual Testing Enginner");
            //Click dropdown
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div/select")).Click();
           
            //Select category
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]")).Click();
            //Click dropdown
             Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select")).Click();
           
            //Select Sub-category
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]")).Click();
            //Tag
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")).SendKeys("Manual");
            Driver.driver.FindElement(By.XPath("/ html / body / div / div / div[1] / div[2] / div / form / div[4] / div[2] / div / div / div / div / input")).SendKeys(Keys.Enter);
            
            //Service type
            Driver.driver.FindElement(By.XPath("/ html / body / div / div / div[1] / div[2] / div / form / div[5] / div[2] / div[1] / div[1] / div / input")).Click();

            //Location Type
            Driver.driver.FindElement(By.XPath("/ html / body / div / div / div[1] / div[2] / div / form / div[6] / div[2] / div / div[2] / div / input")).Click();

            //Avaliable days
            Driver.driver.FindElement(By.XPath("/ html / body / div / div / div[1] / div[2] / div / form / div[7] / div[2] / div / div[3] / div[1] / div / input")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input")).Click();
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[7]/div[2]/div/div[5]/div[1]/div/input")).Click();

            //Skill Trade
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")).Click();
            //Skill Exchange
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")).SendKeys("ManualTesting");
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")).SendKeys(Keys.Enter);
            //Active
            Driver.driver.FindElement(By.XPath("/ html / body / div / div / div[1] / div[2] / div / form / div[10] / div[2] / div / div[1] / div / input")).Click();
           
            //Save
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div[1]/div[2]/div/form/div[11]/div/input[1]")).Click();
            
            //log out
            Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/div/a[2]/button")).Click();
            Driver.Close();
            //login again

            //Launch the browser
            Initialize();
            Thread.Sleep(500);
            Driver.NavigateUrl();
            //Enter Url

            Driver.driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")).Click();
            //Enter Username
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("test1@yahoo.com");

            //Enter password
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("123456");
            Thread.Sleep(1000);
            //Click on Login Button
            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();

            Thread.Sleep(1500);
            //Enter Search skill
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[1]/input")).SendKeys("eWam");
            //click on search button
            Driver.driver.FindElement(By.XPath("/ html / body / div[1] / div / div[1] / div[1] / i")).Click();
                while (true)
                {
                for (var j = 2; j <= 100; j++)
                {
                    for (var i = 1; i <= 9; i++)
                    {

                        IWebElement Name = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[" + i + "]/div[1]/a[1]"));
                        IWebElement Title = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[" + i + "]/div[1]/a[2]/p"));
                        Thread.Sleep(500);
                        if (Name.Text == "Jijitha Anand" && Title.Text == "eWam")
                        {
                            //Click on Skill
                            Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/a/img")).Click();

                            //Click on Profile 
                            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div[2]/div[2]/div[1]/div/div[1]/a/i")).Click();
                            Thread.Sleep(1500);
                            string Description = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;

                            //Click on Language Tab
                            Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
                            string Language = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/table/tbody/tr/td[1]")).Text;
                            string LanguageLevel = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/table/tbody/tr/td[2]")).Text;
                            if((Description == "Hi, have experience with eWam, which uses Gold language") && (Language == "English") && (LanguageLevel == "Basic"))
                            {
                                CommonMethods.test.Log(LogStatus.Pass,"Test Passed, Profile Viewed Successfully with specific skill");
                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Profile viewed successfully with specific skill ");
                                Assert.IsTrue(true);
                            }
                        }

                    }
                    Driver.driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[3]/div[2]/div/button[" + j + "]")).Click();

                }
                 
                }
        }
    }
}
