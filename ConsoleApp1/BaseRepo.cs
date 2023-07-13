using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class BaseRepo
    {
        public virtual object GetIndex()
        {
            return new object();
        }
    }
}
