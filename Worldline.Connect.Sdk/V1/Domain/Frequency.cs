/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
namespace Worldline.Connect.Sdk.V1.Domain
{
    public class Frequency
    {
        /// <summary>
        /// <p>The interval between recurring payments specified as days, weeks, quarters, or years.</p>
        /// <p>Allowed values:</p>
        /// <list type="bullet">
        ///   <item><description>days</description></item>
        ///   <item><description>weeks</description></item>
        ///   <item><description>months</description></item>
        ///   <item><description>quarters</description></item>
        ///   <item><description>years</description></item>
        /// </list>
        /// </summary>
        public string Interval { get; set; }

        /// <summary>
        /// The number of days, weeks, months, quarters, or years between recurring payments.
        /// </summary>
        public int? IntervalFrequency { get; set; }
    }
}
