using System;

public class Program
{
    // 두 값을 교환하는 함수.
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // 선택 정렬.
    static void SelectionSort(int[] array)
    {
        // 루프를 순회하면서 현재 비교하는 리스트에서
        // 최소값(또는 최대값)을 가장자리로 정렬 시키는 과정.
        for (int ix = 0; ix < array.Length - 1; ++ix)
        {
            // 최소값 비교를 위해 초기값 설정.
            int minIndex = ix;
            for (int jx = ix + 1; jx < array.Length; ++jx)
            {
                // 값 비교.
                if (array[jx] < array[minIndex] == true)
                {
                    minIndex = jx;
                }
            }

            // 최소값을 현재 리스트의 가장 왼쪽에 설정.
            Swap(ref array[ix], ref array[minIndex]);
        }
    }

    static void Main(string[] args)
    {
        // 자료 집합.
        int[] array = { 64, 25, 12, 22, 11 };

        Console.WriteLine($"선택 정렬 전 배열: {string.Join(", ", array)}");

        SelectionSort(array);

        Console.WriteLine($"선택 정렬 후 배열: {string.Join(", ", array)}");

        Console.ReadKey();
    }
}