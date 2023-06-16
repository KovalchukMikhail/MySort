namespace Sort
{
    public class HeapSort
    {
        public void Sort(int[] array)
        {
            int currentIndex = array.Length / 2 - 1;
            int firstChildIndex = 2 * currentIndex + 1;
            int secondChildIndex = 2 * currentIndex + 2;
            int lastIndex = array.Length - 1;
            while (lastIndex > 0)
            {
                int indexOfMaxNum = 2 * currentIndex + 1;
                while (currentIndex >= 0)
                {
                    firstChildIndex = 2 * currentIndex + 1;
                    secondChildIndex = 2 * currentIndex + 2;
                    indexOfMaxNum = GetIndexMaxValue(array, currentIndex, firstChildIndex, secondChildIndex, lastIndex);
                    changeValue(array, currentIndex, indexOfMaxNum);
                    currentIndex--;
                }
                changeValue(array, 0, lastIndex);
                lastIndex--;
                currentIndex = lastIndex / 2;
            }
        }

        public void changeValue(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
        public int GetIndexMaxValue(int[] array, int currentIndex, int firstChildIndex, int secondChildIndex, int lastIndex)
        {
            int indexOfMaxNum = currentIndex;
            if (lastIndex >= firstChildIndex)
            {
                if (array[indexOfMaxNum] < array[firstChildIndex]) indexOfMaxNum = firstChildIndex;
            }
            if (lastIndex >= secondChildIndex)
            {
                if (array[indexOfMaxNum] < array[secondChildIndex]) indexOfMaxNum = secondChildIndex;
            }
            return indexOfMaxNum;
        }
    }
}
