using Assignment1.Range;

namespace Assignment1
{
    internal class Program
    {
        public static void SWAP<T>(ref T obj1, ref T obj2)
        {
            if (obj1 == null || obj2 == null) return;

            T temp = obj1;
            obj1 = obj2;
            obj2 = temp;
            return;
        }

        // Function to perform bubble sort on an array With Best Case O(n)
        public static void OptemeizedBubbleSort<T>(ref T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
                    {
                        SWAP(ref arr[i] ,ref  arr[j + 1]);
                        flag = true;
                    }
                }
                // If no elements were swapped in the inner loop, the array is already sorted
                if (!flag)
                {
                    return;
                }
            }
        }

        
        static void Main(string[] args)
        {
            #region Q1 
            //int[] arr = { 2, 3, 0, -1, 4, 1 };
            //OptemeizedBubbleSort(ref arr);
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} ");
            //} 
            #endregion

            #region Q2
            //Test t1 = new Test(2, 3);
            //Test t2 = new Test(4, 5);

            //Range<Test> range = new Range<Test>(t1, t2);
            //bool x = range.IsInRange(new Test(1, 2));

            //Console.WriteLine(x); 
            #endregion


        }
    }
}
