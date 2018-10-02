using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_LINQ_LamdaDemo
{
    class MyArray<ArrayType>
    {
        ArrayType[] internalArray = new ArrayType[10];
        int count = 0;

        public void Add(ArrayType data)
        {
            if (count == 10)
                throw new ArgumentOutOfRangeException("Sorry, out of space");
            internalArray[count++] = data;
        }
    }
}
