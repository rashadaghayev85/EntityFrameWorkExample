using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample.Helpers.Exceptions
{
    internal class NotFoundException:Exception
    {
      public NotFoundException(string msj):base(msj) { }
    }       
}
