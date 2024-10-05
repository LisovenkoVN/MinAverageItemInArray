namespace MinAverageItemInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Min, Avrg;
            int[] NewArray = { 1, 2, 3, 50, 99 };

            Avrg = (int)NewArray.Average();
            Min = NewArray[0];
            foreach (int item in NewArray)
            {
                if (item < Min) Min = item;
            }

            var str = string.Join(" ", NewArray);
            Console.Write($"Массив: {str}");
            Console.WriteLine("\n");
            Console.WriteLine($"Минимальное: {Min.ToString()}, Среднее: {Avrg.ToString()}");
        }
    }
}
