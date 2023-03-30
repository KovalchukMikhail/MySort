namespace Sort
{
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                int temp = array[j];
                int i = j;
                while(i > 0 && array[i-1] > temp){
                    array[i] = array[i-1];
                    i--;
                }
                array[i] = temp;
            }
        }
    }
}