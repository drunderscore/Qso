using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qso
{
    public class QsoException : Exception
    {
        public QsoException( string message ) : base( message ) { }
        public QsoException( string message, Exception innerException ) : base( message, innerException ) { }
        protected QsoException( SerializationInfo info, StreamingContext context ) : base( info, context ) { }
    }
}
