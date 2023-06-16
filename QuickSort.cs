using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sort
{
    internal class QuickSort
    {
        private Random random;
        public QuickSort()
        { 
            random = new Random();
        }

        public void Sort(int[] array)
        {
            RunQuickSort(array, 0, array.Length - 1);
        }
        public void RunQuickSort(int[] array, int indexStart, int indexEnd)
        {
            if (indexStart >= indexEnd) return;
            int pivot = array[random.Next(indexStart, indexEnd + 1)];
            int i = indexStart;
            int j = indexEnd;
            while (i <= indexEnd && i <= j)
            {
                while(i <= indexEnd)
                {
                    if (array[i] >= pivot) break;
                    i++;
                }
                while (j >= indexStart && i <= j)
                {
                    if (array[j] <= pivot)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        i++;
                        j--;
                        break;
                    }
                    j--;
                }
            }
            RunQuickSort(array, indexStart, j);
            RunQuickSort(array, i, indexEnd);
        }
    }
}
