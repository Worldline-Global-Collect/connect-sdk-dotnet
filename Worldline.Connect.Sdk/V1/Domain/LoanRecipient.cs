/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;

namespace Worldline.Connect.Sdk.V1.Domain
{
    [Obsolete("No replacement")]
    public class LoanRecipient
    {
        /// <summary>
        /// Should be filled with the last 10 digits of the bank account number of the recipient of the loan.
        /// </summary>
        [Obsolete("No replacement")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The date of birth of the customer of the recipient of the loan.
        /// <br />Format: YYYYMMDD
        /// </summary>
        [Obsolete("No replacement")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Should be filled with the first 6 and last 4 digits of the PAN number of the recipient of the loan.
        /// </summary>
        [Obsolete("No replacement")]
        public string PartialPan { get; set; }

        /// <summary>
        /// Surname of the recipient of the loan.
        /// </summary>
        [Obsolete("No replacement")]
        public string Surname { get; set; }

        /// <summary>
        /// Zip code of the recipient of the loan
        /// </summary>
        [Obsolete("No replacement")]
        public string Zip { get; set; }
    }
}
