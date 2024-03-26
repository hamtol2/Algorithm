using System;

public class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void BubbleSort(int[] array)
    {
        // 버블 정렬.
        for (int ix = 0; ix < array.Length - 1; ++ix)
        {
            for (int jx = 0; jx < array.Length - 1 - ix; ++jx)
            {
                // 두 개씩 비교.
                if (array[jx] > array[jx + 1] == true)
                {
                    // 교환(Swap).
                    //int temp = array[jx];
                    //array[jx] = array[jx + 1];
                    //array[jx + 1] = temp;
                    Swap(ref array[jx], ref array[jx + 1]);
                }
            }
        }
    }

    static void Main(string[] args)
    {
        // 자료 집한.
        int[] array = { 5, 2, 8, 4, 1 };

        // 출력.
        Console.WriteLine($"정렬 전 배열: {string.Join(", ", array)}");

        BubbleSort(array);

        Console.WriteLine($"정렬 후 배열: {string.Join(", ", array)}");

        Console.ReadKey();
    }
}