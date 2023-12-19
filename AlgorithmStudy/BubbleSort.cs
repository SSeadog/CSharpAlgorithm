using System;

namespace AlgorithmStudy
{
    public class BubbleSort
    {
        // 1. 배열의 두 수를 선택한 뒤 만약 그 두 수가 정렬되었다면 놔두고 아니라면 두 수를 바꾸는 방식
        // 2. 배열의 처음부터 끝까지 반복

        // [3][4][2][1]
        public void Sort(ref int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
