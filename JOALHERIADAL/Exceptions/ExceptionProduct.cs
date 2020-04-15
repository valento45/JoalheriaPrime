using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOALHERIADAL.Exceptions
{
    public class ExceptionProduct : Exception
    {
        public string Message { get; set; }

        public ExceptionProduct(string message)
        {
            Message = message;
        }
    }
}
