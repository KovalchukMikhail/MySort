
namespace Sort
{
    public class Program
    {
        public static void Main()
        {
            ArrayCreator creator = new ArrayCreator();
            int[] array = creator.CreateArrayInt();
            Array.ForEach(array, i => Console.Write($"{i} "));
            Console.WriteLine();
            //InsertionSort sorter = new InsertionSort();
            //HeapSort sorter = new HeapSort();
            QuickSort sorter = new QuickSort();
            sorter.Sort(array);
            Array.ForEach(array, i => Console.Write($"{i} "));
            Array.Sort(array);
        }
    }

    public abstract class Foo
    {
        public void Hello() => Console.Write("f");
    }
}