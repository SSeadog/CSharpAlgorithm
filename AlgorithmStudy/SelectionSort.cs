namespace AlgorithmStudy
{
    public class SelectionSort
    {
        // 주어진 리스트 중에 최소값을 찾는다
        // 그 값을 맨 앞에 위치한 값과 교체한다(패스(pass))
        // 맨 처음 위치를 뺀 나머지 리스트를 같은 방법으로 교체한다
        public void Sort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
