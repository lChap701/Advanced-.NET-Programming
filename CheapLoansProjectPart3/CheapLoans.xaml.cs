using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace CheapLoansProjectPart3
{
    /// <summary>
    /// Interaction logic for CheapLoans.xaml
    /// </summary>
    public partial class CheapLoans : Window
    {
        // DbContext class for the CheapLoans database
        readonly CheapLoansEntities cheapLoans = new CheapLoansEntities();

        // Instance variables for incrementing numeric textbox fields
        int _NumValueInt = 0;
        double _NumValueCur = 0;
        double _NumValuePer = 0;

        /// <summary>
        /// Default constructor for the CheapLoans window
        /// </summary>
        public CheapLoans()
        {
            InitializeComponent();

            // Sets the default value for the monPayment textbox
            monPayment.Text = "0.00";

            // Displays a welcome message
            MessageBox.Show("Welcome to the Cheap Loans form!", "Welcome", MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        /// <summary>
        /// Property for incrementing the loanAmt textbox
        /// </summary>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control 
        /// </remarks>
        public double NumValueCur
        {
            get { return _NumValueCur; }
            set
            {
                _NumValueCur = value;
                loanAmt.Text = value.ToString();
            }
        }

        /// <summary>
        /// Property for incrementing the anIntRate textbox
        /// </summary>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control 
        /// </remarks>
        public double NumValuePer
        {
            get { return _NumValuePer; }
            set
            {
                _NumValuePer = value;
                anIntRate.Text = value.ToString();
            }
        }

        /// <summary>
        /// Property for incrementing the numPayments textbox 
        /// </summary>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control 
        /// </remarks>
        public int NumValueInt
        {
            get { return _NumValueInt; }
            set
            {
                _NumValueInt = value;
                numPayments.Text = value.ToString();
            }
        }

        /// <summary>
        /// Runs the method below when the custName textbox is not in focus
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void CustName_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidCustName();
        }

        /// <summary>
        /// Validates data in the customer name textbox
        /// </summary>
        void ValidCustName()
        {
            // Checks if a value has been entered and if its in the correct format
            if (string.IsNullOrEmpty(custName.Text.Trim()))
            {
                custNameError.Content = "Required";
            }
            else if (!Regex.IsMatch(custName.Text, "[A-Z|a-z]+[ ](([A-Z|a-z][.]|[A-Z|a-z]+){1}[ ])?[A-Z|a-z]+"))
            {
                custNameError.Content = "A full name (first and last) is required";
            }
            else
            {
                custNameError.Content = "";
            }
        }

        /// <summary>
        /// Executes the code below when the user types something in the loanAmt textbox
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control 
        /// </remarks>
        void LoanAmt_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Checks if a value has been entered
            if (string.IsNullOrEmpty(loanAmt.Text.Trim()))
            {
                return;
            }

            // Clears all non-numeric values if the value is not numeric
            if (!double.TryParse(loanAmt.Text, out _NumValueCur))
            {
                loanAmt.Text = Regex.Replace(loanAmt.Text, @"[^0-9,.]+", "");

                // Sets the caret to the correct the last position in the string
                loanAmt.CaretIndex = loanAmt.Text.Length;
            }
        }

        /// <summary>
        /// Executes the code below when a key is pressed while focused on the loanAmt textbox
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void LoanAmt_KeyUp(object sender, KeyEventArgs e)
        {
            // Checks if the loanAmt textbox should be incremented or decremented
            if (e.Key == Key.Up)
            {
                NumValueCur += 0.01;
            }
            else if (e.Key == Key.Down)
            {
                NumValueCur -= 0.01;
            }
        }

        /// <summary>
        /// Executes the code below when the cmdUpCur button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control
        /// </remarks>
        void CmdUpCur_Click(object sender, RoutedEventArgs e)
        {
            // Increases the loan amount by 0.01
            NumValueCur += 0.01;
            ValidLoanAmt();
        }

        /// <summary>
        /// Executes the code below when the cmdDownCur button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control
        /// </remarks>
        void CmdDownCur_Click(object sender, RoutedEventArgs e)
        {
            // Decreases the loan amount by 0.01
            NumValueCur -= 0.01;
            ValidLoanAmt();
        }

        /// <summary>
        /// Executes the code below when the loanAmt textbox loses focus
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void LoanAmt_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidLoanAmt();
        }

        /// <summary>
        /// Validates data in the loanAmt textbox
        /// </summary>
        void ValidLoanAmt()
        {
            // Checks if a value was entered and if the value is in the correct ranage
            if (string.IsNullOrEmpty(loanAmt.Text.Trim()))
            {
                loanAmtError.Content = "Required";
            }
            else if (double.Parse(loanAmt.Text) < 0.01 || double.Parse(loanAmt.Text) > 99999.99)
            {

                loanAmtError.Content = "Should be between $0.01 to $99,999.99";
            }
            else
            {
                loanAmtError.Content = "";
            }

            // Conditional expression for formatting the value in the textbox
            loanAmt.Text = !string.IsNullOrEmpty(loanAmt.Text.Trim()) ? _NumValueCur.ToString("###,##0.00") : "";
        }

        /// <summary>
        /// Executes the code below when the user types something in the anIntRate textbox
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control 
        /// </remarks>
        void AnIntRate_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Checks if a value has been entered
            if (string.IsNullOrEmpty(anIntRate.Text.Trim()))
            {
                return;
            }

            // Clears all values if the value is not numeric
            if (!double.TryParse(anIntRate.Text, out _NumValuePer))
            {
                anIntRate.Text = Regex.Replace(anIntRate.Text, @"[^0-9.]+", "");

                // Sets the caret to the correct the last position in the string
                anIntRate.CaretIndex = anIntRate.Text.Length;
            }
        }

        /// <summary>
        /// Executes the code below when the cmdUpPer button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control
        /// </remarks>
        void CmdUpPer_Click(object sender, RoutedEventArgs e)
        {
            // Increases the annual interest rate by 0.1
            NumValuePer += 0.1;
            ValidAnIntRate();
        }

        /// <summary>
        /// Executes the code below when the cmdDownPer button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control
        /// </remarks>
        void CmdDownPer_Click(object sender, RoutedEventArgs e)
        {
            // Decreases the annual interest rate by 0.1
            NumValuePer -= 0.1;
            ValidAnIntRate();
        }

        /// <summary>
        /// Executes the code below when a key is pressed while focused on the anIntRate textbox
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void AnIntRate_KeyUp(object sender, KeyEventArgs e)
        {
            // Checks if the anIntRate textbox should be incremented or decremented
            if (e.Key == Key.Up)
            {
                NumValuePer += 0.1;
            }
            else if (e.Key == Key.Down)
            {
                NumValuePer -= 0.1;
            }
        }

        /// <summary>
        /// Executes the code below when the anIntRate textbox loses focus
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void AnIntRate_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidAnIntRate();
        }

        /// <summary>
        /// Validates data in the anIntRate textbox
        /// </summary>
        void ValidAnIntRate()
        {
            // Checks if a value was entered and if the value is in the correct ranage
            if (string.IsNullOrEmpty(anIntRate.Text.Trim()))
            {
                anIntRateError.Content = "Required";
            }
            else if (double.Parse(anIntRate.Text) < 0.1 || double.Parse(anIntRate.Text) > 99.9)
            {
                anIntRateError.Content = "Should be between 0.1% and 99.9%";
            }
            else
            {
                anIntRateError.Content = "";
            }

            // Conditional expression for formatting the value in the textbox
            anIntRate.Text = !string.IsNullOrEmpty(anIntRate.Text.Trim()) ? _NumValuePer.ToString("#0.0") : "";
        }

        /// <summary>
        /// Executes the code below when the user types something in the numPayments textbox
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control </remarks>
        void NumPayments_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Checks if a value has been entered 
            if (string.IsNullOrEmpty(numPayments.Text.Trim()))
            {
                return;
            }

            // Clears all values if the value is not numeric or a decimal
            if (!int.TryParse(numPayments.Text, out _NumValueInt))
            {
                numPayments.Text = Regex.Replace(numPayments.Text, @"\D", "");

                // Sets the caret to the correct the last position in the string
                numPayments.CaretIndex = numPayments.Text.Length;
            }
        }

        /// <summary>
        /// Executes the code below when a key is pressed while focused on the numPayments textbox
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void NumPayments_KeyUp(object sender, KeyEventArgs e)
        {
            // Checks if the anIntRate textbox should be incremented or decremented
            if (e.Key == Key.Up)
            {
                NumValueInt++;
            }
            else if (e.Key == Key.Down)
            {
                NumValueInt--;
            }
        }

        /// <summary>
        /// Executes the code below when the cmdUpInt button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control 
        /// </remarks>
        void CmdUpInt_Click(object sender, RoutedEventArgs e)
        {
            // Increases the number of payments by 1
            NumValueInt++;
            ValidNumPayments();
        }

        /// <summary>
        /// Executes the code below when the cmdDownInt button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        /// <remarks>
        /// Based on https://stackoverflow.com/questions/841293/where-is-the-wpf-numeric-updown-control 
        /// </remarks>
        void CmdDownInt_Click(object sender, RoutedEventArgs e)
        {
            // Decreases the number of payments by 1
            NumValueInt--;
            ValidNumPayments();
        }

        /// <summary>
        /// Executes the code below when the numPayments textbox loses focus
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>s
        void NumPayments_LostFocus(object sender, RoutedEventArgs e)
        {
            ValidNumPayments();
        }

        /// <summary>
        /// Validates data in the number of payments textbox
        /// </summary>
        void ValidNumPayments()
        {
            // Checks if a value was entered and if the value is in the correct ranage
            if (string.IsNullOrEmpty(numPayments.Text.Trim()))
            {
                numPaymentsError.Content = "Required";
            }
            else if (int.Parse(numPayments.Text) < 1 || int.Parse(numPayments.Text) > 999)
            {
                numPaymentsError.Content = "Should be between 1 and 999";
            }
            else
            {
                numPaymentsError.Content = "";
            }

            // Conditional expression for formatting the value in the textbox
            numPayments.Text = !string.IsNullOrEmpty(numPayments.Text.Trim()) ? _NumValueInt.ToString("##0") : "";
        }

        /// <summary>
        /// Used to contain code or perform any actions after the the submit button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Submit_Click(object sender, RoutedEventArgs e)
        {
            // Displays a message to indicate that the monthly payment is being calculated
            MessageBox.Show("Calculating monthly payment...", "Calculating...", MessageBoxButton.OK,
                MessageBoxImage.Information);

            ValidCustName();
            ValidLoanAmt();
            ValidAnIntRate();
            ValidNumPayments();

            // Determines if the monthly payment should be calculated
            if (string.IsNullOrEmpty(custNameError.Content.ToString())
                && string.IsNullOrEmpty(loanAmtError.Content.ToString())
                && string.IsNullOrEmpty(anIntRateError.Content.ToString())
                && string.IsNullOrEmpty(numPaymentsError.Content.ToString()))
            {
                // Calculates the monthly payment
                monPayment.Text = Calc(double.Parse(anIntRate.Text), int.Parse(numPayments.Text),
                    double.Parse(loanAmt.Text));
            }
        }

        /// <summary>
        /// Calculates the monthly payment
        /// </summary>
        /// <param name="rate">Represents the annual interest rate</param>
        /// <param name="payments">Represents the number of payments</param>
        /// <param name="amt">Represents the loan amount</param>
        /// <returns>
        /// Returns the result that was calculated as a string, so the value can be formatted and displayed as text
        /// </returns>
        public static string Calc(double rate, double payments, double amt)
        {
            return Math.Round(-Financial.Pmt(rate / 100, payments, amt), 2).ToString("###,##0.00");
        }

        /// <summary>
        /// Used to contain code or perform any actions after the the reset button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Reset_Click(object sender, RoutedEventArgs e)
        {
            // Displays the cleared message
            MessageBox.Show("The Cheap Loans form has been cleared!", "Cleared", MessageBoxButton.OK,
                MessageBoxImage.Information);

            // Clears all values in the form and removes error messages
            custName.Text = "";
            custNameError.Content = "";

            loanAmt.Text = "";
            loanAmtError.Content = "";

            anIntRate.Text = "";
            anIntRateError.Content = "";

            numPayments.Text = "";
            numPaymentsError.Content = "";

            monPayment.Text = "0.00";
        }

        /// <summary>
        /// Used to contain code or perform any actions after the the save button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Save_Click(object sender, RoutedEventArgs e)
        {
            // Displays a message to indicate that the loan is being saved
            MessageBox.Show("Saving loan...", "Saving...", MessageBoxButton.OK, MessageBoxImage.Information);

            ValidCustName();
            ValidLoanAmt();
            ValidAnIntRate();
            ValidNumPayments();

            try
            {
                // Determines if the loan should be saved in the CheapLoans database
                if (string.IsNullOrEmpty(custNameError.Content.ToString())
                    && string.IsNullOrEmpty(loanAmtError.Content.ToString())
                    && string.IsNullOrEmpty(anIntRateError.Content.ToString())
                    && string.IsNullOrEmpty(numPaymentsError.Content.ToString()))
                {
                    // Creates a new Loan object
                    Loan loan = new Loan
                    {
                        CustName = custName.Text.Trim(),
                        LoanAmount = decimal.Parse(loanAmt.Text),
                        AnnualIntRate = decimal.Parse(anIntRate.Text) / 100,
                        NumPayments = int.Parse(numPayments.Text)
                    };

                    // Stores the Loan object in the database
                    cheapLoans.Loans.Add(loan);
                    cheapLoans.SaveChangesAsync();

                    // Displays a success message
                    MessageBox.Show("The loan has been saved", "Success", MessageBoxButton.OK,
                        MessageBoxImage.Information);

                    // Clears values
                    custName.Text = "";
                    loanAmt.Text = "";
                    anIntRate.Text = "";
                    numPayments.Text = "";
                    monPayment.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                // Displays an error message
                MessageBox.Show("Unable to save loan due to a serious error\n\n" + ex.Message, "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Used to contain code or perform any actions after the the display button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Display_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Loading the Display Loans form...", "Loading...", MessageBoxButton.OK,
                MessageBoxImage.Information);

            // Opens the DisplayLoans window
            DisplayLoans loans = new DisplayLoans();
            loans.ShowDialog();
        }
    }
}