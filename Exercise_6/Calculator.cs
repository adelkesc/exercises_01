using System;

namespace Exercise_6
{
    class Calculator
    {
        private int x;
        private int y;
        private int[] array;
        
        public Calculator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Calculator(int[] array)
        {
            this.array = array;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int[] array)
        {
            int sum = 0;
            for(int index = 0; index < array.Length; index++)
            {
                sum += array[index];
            }
            return sum;
        }
    }
    //when to use a default constructor?
}