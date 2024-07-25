using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Range
{
    internal interface IOperators<T> where T : notnull 
    {
        public T Subtract( T obj);
        public T  Add ( T obj);
    }
}
