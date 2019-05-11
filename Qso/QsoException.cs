using System;
using System.Runtime.Serialization;

namespace Qso
{
    [Serializable]
    public class QsoException : Exception
    {
        public QsoException( string message ) : base( message ) { }
        public QsoException( string message, Exception innerException ) : base( message, innerException ) { }
        protected QsoException( SerializationInfo info, StreamingContext context ) : base( info, context ) { }
    }
}
