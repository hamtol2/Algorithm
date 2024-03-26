using System;

public class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // 삽입 정렬 함수.
    static void InsertionSort(int[] array)
    {
        // 배열 순회.
        for (int ix = 1; ix < array.Length; ++ix)
        {
            // 일단 앞의 순서와 비교해 정렬이 된 상태면 건너뜀.
            if (array[ix - 1] <= array[ix] == true)
            {
                continue;
            }

            // 정렬.

            // 비교를 위해 현재 값 뽑기(저장).
            int keyValue = array[ix];
            for (int jx = ix; jx > 0; --jx)
            {
                // 왼쪽 값이 크면 값 바꾸기.
                if (array[jx - 1] > keyValue)
                {
                    // 값 교환.
                    array[jx] = array[jx - 1];
                    array[jx - 1] = keyValue;
                }

                // 이 작업을 정렬되지 않을 때까지만 반복.
                else
                {
                    break;
                }
            }
        }
    }

    static void Main(string[] args)
    {
        // 자료 집합
        int[] array = { 8, 5, 2, 7, 3, 1, 4, 6 };

        // 정렬 전 배열 호출.
        Console.WriteLine($"삽입 정렬 전 배열: {string.Join(", ", array)}");

        // 정렬.
        InsertionSort(array);

        // 정렬 후 배열 호출.
        Console.WriteLine($"삽입 정렬 후 배열: {string.Join(", ", array)}");

        Console.ReadKey();
    }
}