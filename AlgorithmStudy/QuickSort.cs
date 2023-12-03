namespace AlgorithmStudy
{
    public class QuickSort
    {
        // 2(p) 3 4 1
        // 1. 피벗을 하나 선택
        // 2. 피벗 기준으로 피벗보다 작은 건 왼쪽으로, 큰건 오른쪽으로 옮긴다
        // 2-1. 왼쪽, 오른쪽 인덱스를 뽑고 조건에 맞지 않는 요소를 발견할 때까지 찾아가서
        // 3. 피벗을 제외한 왼쪽 부분과 오른쪽 부분에 대해 2번을 수행한다
        // 4. 더이상 분할이 불가능할 때까지 반복
        public void Sort(ref int[] arr, int start, int end)
        {
            if (end - start < 1)
                return;

            int pivot = arr[start];
            int left = start + 1;
            int right = arr.Length - 1;

            while (left < right)
            {
                while (left < end && arr[left] < pivot) left++;
                while (left > start && arr[right] > pivot) right--;

                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
            }

            arr[start] = arr[right];
            arr[right] = pivot;

            Sort(ref arr, start, right - 1);
            Sort(ref arr, right + 1, end);
        }
    }
}
