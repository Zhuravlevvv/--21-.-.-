using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTep
{
    public class DepoAlreadyHaveException : Exception
    {
        public DepoAlreadyHaveException() : base("В депо уже есть такой поезд") { }
    }
}
