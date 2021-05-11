using System;

namespace CheapLoansProjectPart5
{
    /// <summary>
    /// Created 5/4/2021 by Lucas Chapman. 
    /// Class for creating Loan objects for tests
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// Property for loan numbers
        /// </summary>
        public int LoanNum { get; set; }

        /// <summary>
        /// Property for customer names
        /// </summary>
        public string CustName { get; set; }

        /// <summary>
        /// Property for the amount of a loan
        /// </summary>
        public Nullable<decimal> LoanAmount { get; set; }

        /// <summary>
        /// Property for the annual interest rate on a loan
        /// </summary>
        public Nullable<decimal> AnnualIntRate { get; set; }

        /// <summary>
        /// Property for the number of payments on a loan
        /// </summary>
        public Nullable<int> NumPayments { get; set; }

        /// <summary>
        /// Property for the expected monthly payment of a loan
        /// </summary>
        public decimal MonPayment { get; set; }
    }
}
