using System;

namespace DinamycArray
{
    class Array
    {
        // private int[] firstArray;
        public int Count
        { get; private set; }
        public int[] NumbersArray
        { get; private set; }
        public int[] AddFirstArray
        { get; private set; }
        public int Length
        {
            get
            {
                return NumbersArray.Length;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstarray"></param>
        /// <param name="count"></param>
        public Array(int[] numbersArray, int count)
        {
            NumbersArray = numbersArray;
            Count = numbersArray.Length;
        }
        public void AddWithIncrease(int number, int index)//проверка, нужно ли выделять память. поле класса count(контроль размера)как только count == length, выделяется память
        {
            SizeIncreaseStrategy sizeIncreaseStrategy = new SizeIncreaseStrategy();
            AddFirstArray = new int[sizeIncreaseStrategy.TwoSizeIncrease(NumbersArray)];
            for (int i = 0; i < index; i++)
            {
                AddFirstArray[i] = NumbersArray[i];
            }
            AddFirstArray[index] = number;
            if (index < 0)
            {
                throw new Exception();
            }
            for (int j = index; j < Length; j++)
            {
                AddFirstArray[j+1] = NumbersArray[j];
            }
            NumbersArray = AddFirstArray;
        }
        public void Add(int number, int index)//проверка, нужно ли выделять память. поле класса count(контроль размера)как только count == length, выделяется память
        {          
            NumbersArray[index] = number;
            for (int j = index + 1; j < Length; j++)
            {
                NumbersArray[j] = NumbersArray[j - 1];
            }
            NumbersArray = NumbersArray;
        }
        public void Delete(int index)//если удалили,cont --
        {
          /*  for (int i = 0; i < index; i++)
            {
                FirstArray[i] = FirstArray[i];
            }*/
            for (int j = index ; j < Length-1; j++)
            {
                NumbersArray[j] = NumbersArray[j+1];
            }
            NumbersArray = NumbersArray;
        }

    }
}

