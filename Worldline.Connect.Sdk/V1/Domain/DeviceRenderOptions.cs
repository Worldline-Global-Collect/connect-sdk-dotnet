/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using System.Collections.Generic;

namespace Worldline.Connect.Sdk.V1.Domain
{
    public class DeviceRenderOptions
    {
        /// <summary>
        /// Lists all of the SDK Interface types that the device supports for displaying specific challenge user interfaces within the SDK.
        /// <list type="bullet">
        ///   <item><description>native = The app supports only a native user interface</description></item>
        ///   <item><description>html = The app supports only an HTML user interface</description></item>
        ///   <item><description>both = Both Native and HTML user interfaces are supported by the app</description></item>
        /// </list>
        /// </summary>
        public string SdkInterface { get; set; }

        /// <summary>
        /// Lists all UI types that the device supports for displaying specific challenge user interfaces within the SDK.
        /// <list type="bullet">
        ///   <item><description>text = Text interface</description></item>
        ///   <item><description>single-select = Select a single option</description></item>
        ///   <item><description>multi-select = Select multiple options</description></item>
        ///   <item><description>oob = Out of ounds</description></item>
        ///   <item><description>html-other = HTML Other (only valid when cardPaymentMethodSpecificInput.threeDSecure.sdkData.deviceRenderOptions.sdkInterface is set to html)</description></item>
        /// </list>
        /// </summary>
        [Obsolete("Use deviceRenderOptions.sdkUiTypes instead")]
        public string SdkUiType { get; set; }

        /// <summary>
        /// Lists all UI types that the device supports for displaying specific challenge user interfaces within the SDK.
        /// <list type="bullet">
        ///   <item><description>text = Text interface</description></item>
        ///   <item><description>single-select = Select a single option</description></item>
        ///   <item><description>multi-select = Select multiple options</description></item>
        ///   <item><description>oob = Out of ounds</description></item>
        ///   <item><description>html-other = HTML Other (only valid when cardPaymentMethodSpecificInput.threeDSecure.sdkData.deviceRenderOptions.sdkInterface is set to html)</description></item>
        /// </list>
        /// </summary>
        public IList<string> SdkUiTypes { get; set; }
    }
}
