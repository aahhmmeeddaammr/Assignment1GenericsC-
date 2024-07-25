using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Range
{
    internal class Test :IComparable<Test> ,IOperators<Test>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Test(int _x , int _y)
        {
            X= _x;
            Y= _y;
        }
        public Test()
        {
            
        }

        public int CompareTo(Test? obj)
        {
           if (obj == null) throw new ArgumentNullException();
           if(obj.X == this.X)
           {
                return this.Y.CompareTo(obj.Y);
           }
            return this.X.CompareTo(obj.X);

        }
        Test IOperators<Test>.Add(Test obj)
        {
            return new Test()
            {
                X = (obj?.X ?? 0) + (this?.X ?? 0),
                Y = (obj?.Y ?? 0) + (this?.Y ?? 0)
            };
        }
        Test IOperators<Test>.Subtract(Test obj)
        {
            return new Test()
            {
                X = (obj?.X ?? 0) - (this?.X ?? 0),
                Y = (obj?.Y ?? 0) - (this?.Y ?? 0)
            };
        }
    }
}
