namespace Sort
{
    public class ArrayCreator
    {
        public int[] CreateArrayInt(int size = 10, int min = 0, int max = 100)
        {
            int[] array = new int[size];
            Random random = new Random();
            for(int i = 0; i < size; i++){
                array[i] = random.Next(min, max + 1);
            }
            return array;
        }
    }
}