using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Range
{
    internal class Range<T> where T : IComparable<T> ,IOperators<T>
    {
		private T min;
		private T max;

		public T MAX
		{
			get { return max; }
		}

		public T MIN
		{
			get { return min; }
		}

        public Range(T _min , T _max)
        {
            min =_min;
			max =_max;
        }

        public bool IsInRange(T value) {
			return (value.CompareTo(min) == 1 || value.CompareTo(min) == 0) && (value.CompareTo( max ) == -1 || value.CompareTo(max) == 0);
		}

		public T Length()
		{
			return max.Subtract(min);
		}

        public override string ToString()
        {
            return $"{this.Length()}";
        }

    }
}
