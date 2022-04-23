﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace April2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // launch turnup protal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
           // identify username textbox and enter valid usename

              IWebElement usernameTextbox=driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            //identify password text box and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //click an login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
             loginButton.Click();
           //check if user is logged in sucessfully
           IWebElement helloHari=driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

                     
               if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("login failed, test failed");
            }
                   
         }
    }
    
}
