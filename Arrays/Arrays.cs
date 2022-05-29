using System;

namespace Arrays
{
    public class Arrays
    {
        public static void Start()
        {
            Console.Clear();

            int[] array1 = new int[]{1, 2, 3, 4, 5}; // foma de inicialização de um array
            int[] array = new int[5];
            
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.WriteLine($"Tamanho do Array: {array.Length}");
        }
    }
}