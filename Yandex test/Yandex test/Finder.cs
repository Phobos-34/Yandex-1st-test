using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yandex_test
{
    static public class Finder
    {
        public static Tuple<int, int> FindTwoSmallestSum(int[] array)
        {
            if (array.Length < 2)
                throw new ArgumentException("Массив должен содержать как минимум два элемента"); //Проверка на размер массива

            int min1 = int.MaxValue;
            int min2 = int.MaxValue;

            foreach (int num in array)
            {
                if (num < min1)
                {
                    min2 = min1;
                    min1 = num; //Если текущий элемент меньше min1, он становится новым min1, а старое значение min1 становится min2
                }
                else if (num < min2)
                {
                    min2 = num; //Иначе, если он меньше min2, обновляется только min2
                }
            }

            return Tuple.Create(min1, min2);
        }
    }
}