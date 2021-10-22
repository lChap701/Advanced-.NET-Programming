using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Windows;
using CheapLoansProject;
using OpenQA.Selenium;

namespace CheapLoansProjectPart5
{
    /// <summary>
    /// Created 4/28/2021 by Lucas Chapman.
    /// Runs NUnit/Selenium tests using the ChromeDriver.
    /// </summary>
    public class CheapLoansChromeTests
    {
        // A list of loan objects that will be used for testing
        public static List<Loan> loans = new List<Loan>();

        // The URL to navigate to
        readonly string url = "https://localhost:44356/CheapLoans.aspx";

        // The current WebDriver that will be used for testing
        ChromeDriver chrome;

        /// <summary>
        /// Opens the browser and reads the file
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            try
            {
                // Checks if the values have been retrieved
                if (loans.Count == 0)
                {
                    // Sets the current directory to search for (update it if your path is different)
                    Environment.CurrentDirectory = "C:\\IHCC\\Spring 2021\\Advanced .NET Programming\\CheapLoansProjectPart5";

                    // Gets the path that should be used
                    string path = Directory.GetCurrentDirectory() + "\\TestData.txt";

                    // Sets up the stream required to read the file
                    FileStream inFile = new FileStream(path, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(inFile);
                    
                    // Counter for getting the loan number on each loan
                    int ctr = 0;

                    // Prime read
                    string recordIn = reader.ReadLine();

                    // EOF loop
                    while (recordIn != null)
                    {
                        // Splits the values in the file, creating an array
                        string[] fields = recordIn.Split(',');

                        // Creates a new Loan object with the values in the file
                        Loan l = new Loan
                        {
                            LoanNum = ++ctr,
                            CustName = fields[0],
                            LoanAmount = decimal.Parse(fields[1]),
                            AnnualIntRate = decimal.Parse(fields[2]),
                            NumPayments = int.Parse(fields[3]),
                            MonPayment = decimal.Parse(fields[4])
                        };

                        // Adds the Loan object to the array
                        loans.Add(l);

                        // Attempts to read the next line in the file
                        recordIn = reader.ReadLine();
                    }

                    reader.Close();
                    inFile.Close();
                }

                // Opens the Chrome browser
                chrome = new ChromeDriver();
                chrome.Navigate().GoToUrl(url);
                chrome.Manage().Window.Maximize();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                chrome.Quit();
            }
        }

        /// <summary>
        /// Tests the logic for calculating the monthly payment (should pass)
        /// </summary>
        [Test]
        public void CalcTest1()
        {
            try
            {
                Calc(0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Fills out and submits the Cheap Loans form
        /// </summary>
        /// <param name="i">Represents the index that should be used</param>
        public void Calc(int i)
        {
            if (IsAlertPresent())
            {
                // Closes the alert
                chrome.SwitchTo().Alert().Accept();
            }

            // Fills out the form
            chrome.FindElementById("CustName").SendKeys(loans[i].CustName);
            chrome.FindElementById("LoanAmt").SendKeys(loans[i].LoanAmount.ToString());
            chrome.FindElementById("AnnualIntRate").SendKeys(loans[i].AnnualIntRate.ToString());
            chrome.FindElementById("NumPayments").SendKeys(loans[i].NumPayments.ToString());

            // Sumbits the form
            chrome.FindElementById("Submit").Click();

            // Closes the alert
            chrome.SwitchTo().Alert().Accept();

            // Gets the value that should be presented
            string value = CheapLoans.Calc(double.Parse(loans[i].AnnualIntRate.ToString()),
                int.Parse(loans[i].NumPayments.ToString()), double.Parse(loans[i].LoanAmount.ToString()));

            // Waits at most 10 seconds to find a value in the MonPayment textbox the matches what was found above
            new WebDriverWait(chrome, TimeSpan.FromSeconds(10)).Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(
                    chrome.FindElementById("MonPayment"), value));

            // Retrieves the monthly payment
            string monPayment = chrome.FindElementById("MonPayment").GetAttribute("value");

            // Tests the value
            Assert.AreEqual(loans[i].MonPayment.ToString(), monPayment);
        }

        /// <summary>
        /// Checks if an alert message is displayed during startup
        /// </summary>
        /// <returns>Returns a boolean value</returns>
        public bool IsAlertPresent()
        {
            try
            {
                chrome.SwitchTo().Alert();
                return true;
            } 
            catch (NoAlertPresentException)
            {
                return false;
            }   
        }   

        /// <summary>
        /// Tests the logic for calculating the monthly payment (should fail)
        /// </summary>
        [Test]
        public void CalcTest2()
        {
            try
            {
                Calc(1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Tests the logic for calculating the monthly payment (should pass)
        /// </summary>
        [Test]
        public void CalcTest3()
        {
            try
            {
                Calc(2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Closes the browser and disposes the WebDriver
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            chrome.Quit();
        }
    }
}