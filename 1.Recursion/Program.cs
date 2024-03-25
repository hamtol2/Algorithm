using System;

public class Program
{
    public enum Result
    {
        Success, Fail
    }

    // 팩토리얼을 구하는 재귀 함수.
    static int Factorial(int number)
    {
        // 팩토리얼의 정의에 따라 0인 경우는 1을 반환.
        if (number == 0)
        {
            return 1;
        }

        // 팩토리얼 재귀 호출.
        return number * Factorial(number - 1);
    }

    // 이진 탐색 재귀 함수.
    // array: 데이터 컨테이너 (탐색을 하려는 값이 들어있는 배열 또는 리스트).
    // array는 정렬이 되어 있어야 함.
    // searchTarget: 탐색하려는 목표 값.
    // low: 하위 범위를 나타내는 수.
    // high: 상위 범위를 나타내는 수.
    static int BinarySearch(int[] array, int searchTarget, int low, int high, ref int count)
    {
        // 실패.
        if (low > high)
        {
            // 오류 코드 반환.
            return -1;
        }

        // 중간 값.
        int mid = (low + high) / 2;

        // 성공.
        if (array[mid] == searchTarget)
        {
            return mid;
        }

        // 오른쪽 반만 다시 탐색.
        if (array[mid] < searchTarget)
        {
            count++;
            return BinarySearch(array, searchTarget, mid + 1, high, ref count);
        }

        count++;
        // 왼쪽 반만 탐색.
        return BinarySearch(array, searchTarget, low, mid - 1, ref count);
    }

    // args -> arguments (인자들, 요소들).
    static void Main(string[] args)
    {
        #region 팩토리얼 예제 코드.
        //// 구하기.
        //int testNumber = 5;
        //int result = Factorial(testNumber);

        //Console.WriteLine($"{testNumber}의 팩토리얼 결과는: {result}");

        //// 종료 대기.
        //Console.ReadKey();
        #endregion

        #region 이진 탐색 예제 코드
        // 이진 탐색.
        int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        int target = 56;

        // 몇번 만에 검색했는지 ref로 받아서 계산하는 기능 추가해보기.
        int count = 1;
        int result = BinarySearch(arr, target, 0, arr.Length - 1, ref count);
        if (result != -1)
        {
            Console.WriteLine($"{target} found at index {result} with the try count {count}");
        }

        else
        {
            Console.WriteLine($"{target} not found with the try count {count}");
        }

        Console.ReadKey();
        #endregion
    }
}