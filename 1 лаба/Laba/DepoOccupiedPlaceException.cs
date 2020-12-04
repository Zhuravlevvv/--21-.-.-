using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTep
{
    class DepoOccupiedPlaceException : Exception
    {
        public DepoOccupiedPlaceException() : base("Не удалось загрузить депо!") { }
    }
}
