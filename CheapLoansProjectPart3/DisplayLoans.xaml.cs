using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace CheapLoansProjectPart3
{
    /// <summary>
    /// Interaction logic for DisplayLoans.xaml
    /// </summary>
    public partial class DisplayLoans : Window
    {
        // DbContext class for the CheapLoans database
        readonly CheapLoansEntities cheapLoans = new CheapLoansEntities();

        static bool displayed = false;
        int prevSelectedIndex = 0;

        /// <summary>
        /// Default constructor for the DisplayLoans window
        /// </summary>
        public DisplayLoans()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executes the code below when the DisplayLoans window has loaded
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Gets all the loans in the Loans table
            var query = from loan in cheapLoans.Loans
                        orderby loan.LoanNum
                        select new
                        {
                            loan.LoanNum,
                            loan.CustName,
                            loan.LoanAmount,
                            loan.AnnualIntRate,
                            loan.NumPayments
                        };

            // Displays all loans in the CheapLoans database in the DataGrid
            loans.ItemsSource = query.ToList();

            // Gets the total loan amount
            decimal sum = decimal.Parse(query.Sum(s => s.LoanAmount).ToString());

            // Displays the total loan amount
            total.Text = sum.ToString("#,###,###,###,###,##0.00");

            // Displays a welcome message one time
            if (!displayed)
            {
                MessageBox.Show("Welcome to the Display Loans form!", "Welcome", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                displayed = true;
            }
        }

        /// <summary>
        /// Executes the code below when auto generating columns in the DataGrid
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Loans_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            // Checks the property name to determine how the column should be modified
            switch (e.PropertyName)
            {
                case "LoanNum":
                    e.Column.Header = "ID";
                    (e.Column as DataGridTextColumn).Binding.StringFormat = "D11";
                    break;
                case "CustName":
                    e.Column.Header = "Name";
                    break;
                case "LoanAmount":
                    e.Column.Header = "Amount";
                    (e.Column as DataGridTextColumn).Binding.StringFormat = "C";
                    break;
                case "AnnualIntRate":
                    e.Column.Header = "Annual Interest Rate";
                    (e.Column as DataGridTextColumn).Binding.StringFormat = "P1";
                    break;
                case "NumPayments":
                    e.Column.Header = "Payments";
                    break;
            }

            // Allows users to sort the DataGrid by this column
            e.Column.CanUserSort = true;

            // Adds a header style to the column
            e.Column.HeaderStyle = new Style(typeof(DataGridColumnHeader));
            e.Column.HeaderStyle.Setters.Add(new Setter(CursorProperty, Cursors.Hand));
        }

        /// <summary>
        /// Executes the code below when sorting the DataGrid
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Loans_Sorting(object sender, DataGridSortingEventArgs e)
        {
            // Enables the Reset button
            reset.IsEnabled = true;
            loans.Focus();  // Ensures that the Reset button is not in focus right after being enabled
        }

        /// <summary>
        /// Executes the code below when the cheapLoansLink is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void CheapLoansLink_Click(object sender, RoutedEventArgs e)
        {
            // Closes the DisplayLoans window
            Close();
        }

        /// <summary>
        /// Executes the code below when the reset button is clicked
        /// </summary>
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Reset_Click(object sender, RoutedEventArgs e)
        {
            // Displays the reset message
            MessageBox.Show("The Display Loans form has been resetted!", "Reset", MessageBoxButton.OK,
                MessageBoxImage.Information);

            // Resets the DataGrid
            var query = from loan in cheapLoans.Loans
                        orderby loan.LoanNum
                        select new
                        {
                            loan.LoanNum,
                            loan.CustName,
                            loan.LoanAmount,
                            loan.AnnualIntRate,
                            loan.NumPayments
                        };

            loans.ItemsSource = query.ToList();
            loans.SelectedIndex = -1;
            reset.IsEnabled = false;
        }

        /// <summary>
        /// Executes the code below when the DataGrid is selected
        /// </summary> 
        /// <param name="sender">Used to represent the "sender"</param>
        /// <param name="e">Represents the event that occurred</param>
        void Loans_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // Checks if the row has been selected before
            if (loans.SelectedIndex == prevSelectedIndex)
            {
                // Unselects all rows
                loans.SelectedIndex = -1;
            }
            else
            {
                // Stores the index of the selected row
                prevSelectedIndex = loans.SelectedIndex;
            }
        }
    }
}