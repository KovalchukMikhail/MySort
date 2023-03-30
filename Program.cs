
namespace Sort{
    public class Program{
        public static void Main(){
            ArrayCreator creator = new ArrayCreator();
            int [] array = creator.CreateArrayInt();
            array.ToList().ForEach(n => Console.Write($"{n} "));
            Console.WriteLine();
            // InsertionSort sorter = new InsertionSort();
            HeapSort sorter = new HeapSort();
            sorter.Sort(array);
            array.ToList().ForEach(n => Console.Write($"{n} "));
        }
    }
}