/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class TrialPeriod
    {
        /// <summary>
        /// The number of days, weeks, months, or years before the trial period ends.
        /// </summary>
        public int? Duration { get; set; } = null;

        /// <summary>
        /// The interval for the trial period to finish specified as days, weeks, months, quarters, or years.
        /// </summary>
        public string Interval { get; set; } = null;
    }
}
