using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSymphony.Exceptions
{
    internal class InputNullException : Exception
    {
        const string message = "Input is null !!!";

        public InputNullException() : base(message)
        { }
        public InputNullException(string errorMessage) : base($"Error : {message}, {errorMessage}") { }
        public InputNullException(string infoMessage, Exception innerException) : base(String.Format($"Error : {message}, {infoMessage}. {innerException}"))
        { }
    }
}
