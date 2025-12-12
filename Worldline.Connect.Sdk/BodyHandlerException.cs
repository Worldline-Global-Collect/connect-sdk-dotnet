using System;
using System.Runtime.Serialization;

namespace Worldline.Connect.Sdk
{
    [Serializable]
    public class BodyHandlerException : Exception
    {
        public BodyHandlerException(string message) : base(message)
        {
        }

        public BodyHandlerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BodyHandlerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
