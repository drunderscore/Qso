using System;
using System.Net;
using Newtonsoft.Json;
using Qso.DTO;

namespace Qso
{
    [Serializable]
    public class QsoEndpointException : QsoException
    {
        public ErrorResponse ErrorResponse { get; }
        public HttpStatusCode Status { get; }

        public QsoEndpointException( string response, HttpStatusCode status, string message ) : base( message )
        {
            ErrorResponse = JsonConvert.DeserializeObject<ErrorResponse>( response );
            Status = status;
        }
        public QsoEndpointException( string response, HttpStatusCode status ) : this( response, status, null ) { }
    }
}