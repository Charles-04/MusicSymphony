using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSymphony.Exceptions
{
    public  class InputChecker
    {
        public bool NullValidator(string input, string message)
        {

            if (string.IsNullOrWhiteSpace(input) && string.IsNullOrEmpty(input))
            {
                Exception ex = new();
                throw new InputNullException(message, ex);
              

            }
            else
            {
                return false;
            }

        }
    }
}
