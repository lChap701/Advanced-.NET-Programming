using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Windows;
using System.IO;
using CheapLoansProject;
using OpenQA.Selenium;

namespace CheapLoansProjectPart5
{
    /// <summary>
    /// Created 4/28/2021 by Lucas Chapman.
    /// Runs NUnit/Selenium tests using the FirefoxDriver.
    /// </summary>
    public class CheapLoansFirefoxTests
    {
        // A list of loan objects that will be used for testing
        public static List<Loan> loans = new List<Loan>();

        // The URL to navigate to
        readonly string url = "https://localhost:44356/CheapLoans.aspx";

        // The current WebDriver that will be used for testing
        FirefoxDriver firefox;

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

                // Allows the page to be displayed without any errors
                var op = new FirefoxOptions
                {
                    AcceptInsecureCertificates = true,
                    BrowserExecutableLocation = "C:\\Program Files\\Mozilla Firefox\\firefox.exe"
                };

                // Opens the Firefox browser
                firefox = new FirefoxDriver(op);
                firefox.Navigate().GoToUrl(url);
            }
            catch (Exception e)
            {
                firefox.Quit();
                MessageBox.Show(e.Message);
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
                Calc(3);
            }
            catch (Exception e)
            {
                TearDown();
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Fills out and submits the Cheap Loans form
        /// </summary>
        /// <param name="i">Represents the index that should be used</param>
        void Calc(int i)
        {
            // Fills out the form
            firefox.FindElementById("CustName").SendKeys(loans[i].CustName);
            firefox.FindElementById("LoanAmt").SendKeys(loans[i].LoanAmount.ToString());
            firefox.FindElementById("AnnualIntRate").SendKeys(loans[i].AnnualIntRate.ToString());
            firefox.FindElementById("NumPayments").SendKeys(loans[i].NumPayments.ToString());

            // Sumbits the form
            firefox.FindElementById("Submit").Click();

            // Closes the alert
            firefox.SwitchTo().Alert().Accept();

            //
            string value = CheapLoans.Calc(double.Parse(loans[i].AnnualIntRate.ToString()),
                int.Parse(loans[i].NumPayments.ToString()), double.Parse(loans[i].LoanAmount.ToString()));

            for (int attempts = 0; attempts < 100; attempts++)
            {
                if (IsExists())
                {
                    new WebDriverWait(firefox, TimeSpan.FromSeconds(20)).Until(
                        SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("MonPayment")));
                }

                string monPayment = firefox.FindElementById("MonPayment").GetAttribute("value");

                if (monPayment == value)
                {
                    // Tests the value
                    Assert.AreEqual(loans[i].MonPayment.ToString(), monPayment);
                    break;
                }
            }
        }

        /// <summary>
        /// Checks if an alert message is displayed during startup
        /// </summary>
        /// <returns>Returns a boolean value</returns>
        public bool IsAlertPresent()
        {
            try
            {
                firefox.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if an element exists
        /// </summary>
        /// <returns>Returns a boolean value</returns>
        public bool IsExists()
        {
            try
            {
                firefox.FindElementById("MonPayment");
                return true;
            }
            catch (NoSuchElementException)
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
                Calc(4);
            }
            catch (Exception e)
            {
                TearDown();
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
                Calc(5);
            }
            catch (Exception e)
            {
                TearDown();
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Closes the browser and disposes the WebDriver
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            firefox.Quit();
        }
    }
}
