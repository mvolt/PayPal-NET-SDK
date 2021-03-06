using System.Net;

namespace PayPal
{
    public class ConnectionException : PayPalException
    {
        /// <summary>
        /// Gets the response payload for non-200 response
        /// </summary>
        public string Response { get; private set; }

        /// <summary>
        /// Gets the <see cref="System.Net.WebExceptionStatus"/> returned from a failed HTTP request.
        /// </summary>
        public WebExceptionStatus WebExceptionStatus { get; private set; }

        /// <summary>
        /// Represents errors that occur during application execution
        /// </summary>
        /// <param name="message">The message that describes the error</param>
        /// <param name="response">The response from server</param>
        /// <param name="status">The <see cref="System.Net.WebExceptionStatus"/> that triggered this exception.</param>
        public ConnectionException(string message, string response, WebExceptionStatus status) : base(message)
        {
            this.Response = response;
            this.WebExceptionStatus = status;
        }

        /// <summary>
        /// Copy constructor provided by convenience for derived classes.
        /// </summary>
        /// <param name="ex">The original exception to copy information from.</param>
        protected ConnectionException(ConnectionException ex) : this(ex.Message, ex.Response, ex.WebExceptionStatus)
        {
        }

        /// <summary>
        /// Gets the prefix to use when logging the exception information.
        /// </summary>
        protected override string ExceptionMessagePrefix { get { return "Connection Exception"; } }
    }
}
