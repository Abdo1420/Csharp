using System;
using System.Collections.Generic;
using System.Text;

namespace C_.Basics
{
    public static class Methods
    {
        public static void Swap<T>(ref T value1,ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
        public static T? findMax<T>(T?[] arr)where T:IComparable
        {
            if (arr == null || arr.Length == 0)
                return default;
            T? max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(max)>0)
                    max = arr[i];
            }
            return max;
        }

        
    }
}
