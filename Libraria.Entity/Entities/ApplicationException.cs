using System;
using System.Collections.Generic;
using System.Text;

namespace Libraria.Entity.Entities
{
    public class ApplicationException : Exception
    {
        public ApplicationException(string message)
        : base(String.Format("Application Error: {0}", message))
        {

        }
    }
}
