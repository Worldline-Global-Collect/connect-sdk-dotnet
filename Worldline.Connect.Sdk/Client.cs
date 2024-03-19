/*
 * This class was auto-generated from the API references found at
 * https://apireference.connect.worldline-solutions.com/
 */
using System;
using Worldline.Connect.Sdk.Json;
using Worldline.Connect.Sdk.Logging;
using Worldline.Connect.Sdk.V1;

namespace Worldline.Connect.Sdk
{
    /// <summary>
    /// Worldline Global Collect platform client. Thread-safe.
    ///
    /// This client and all its child clients are bound to one specific value for the <i>X-GCS-ClientMetaInfo</i> header.
    /// To get a new client with a different header value, use <see cref="WithClientMetaInfo"/>.
    /// </summary>
    public class Client : ApiResource, IDisposable, ILoggingCapable, IObfuscationCapable
    {
        public Client(Communicator communicator) : this(communicator, null)
        {
        }

        private Client(Communicator communicator, string clientMetaInfo) :
            base(communicator, clientMetaInfo, null)
        {
        }

        /// <summary>
        /// Returns a new Client which uses the passed meta data for the <i>X-GCS-ClientMetaInfo</i> header.
        /// </summary>
        /// <param name="clientMetaInfo">JSON string containing the meta data for the client</param>
        /// <exception cref="MarshallerSyntaxException">if the given clientMetaInfo is not a valid JSON string</exception>
        public Client WithClientMetaInfo(string clientMetaInfo)
        {
            if (_clientMetaInfo == null && clientMetaInfo == null)
            {
                return this;
            }
            if (clientMetaInfo == null)
            {
                return new Client(_communicator, null);
            }
            // Checking to see if this is valid JSON (no JSON parse exceptions)
            _communicator.Marshaller.Unmarshal<object>(clientMetaInfo);
            clientMetaInfo = clientMetaInfo.ToBase64String();

            return clientMetaInfo.Equals(_clientMetaInfo) ? this : new Client(_communicator, clientMetaInfo);
        }

        /// <summary>
        /// Utility method that delegates the call to this client's communicator.
        /// </summary>
        public void CloseExpiredConnections()
        {
            _communicator.CloseExpiredConnections();
        }

        /// <summary>
        /// Utility method that delegates the call to this client's communicator.
        /// </summary>
        /// <param name="timespan">Idle time.</param>
        public void CloseIdleConnections(TimeSpan timespan)
        {
            _communicator.CloseIdleConnections(timespan);
        }

        #region IObfuscationCapable support
        public BodyObfuscator BodyObfuscator
        {
            set => _communicator.BodyObfuscator = value;
        }

        public HeaderObfuscator HeaderObfuscator
        {
            set => _communicator.HeaderObfuscator = value;
        }
        #endregion

        #region ILoggingCapable support
        public void EnableLogging(ICommunicatorLogger communicatorLogger)
        {
            // delegate to the communicator
            _communicator.EnableLogging(communicatorLogger);
        }

        public void DisableLogging()
        {
            // delegate to the communicator
            _communicator.DisableLogging();
        }
        #endregion

        #region IDisposable support
        /// <summary>
        /// Releases any system resources associated with this object.
        /// </summary>
        public void Dispose()
        {
            _communicator.Dispose();
        }
        #endregion

        public V1Client V1 => new V1Client(this, null);
    }
}
