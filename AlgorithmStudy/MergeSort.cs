using System.Collections.Generic;

namespace AlgorithmStudy
{
    public class MergeSort
    {
        public void Sort(ref int[] arr, int startIdx, int endIdx)
        {
            int mid = (startIdx + endIdx) / 2;

            if (startIdx < mid)
                Sort(ref arr, startIdx, mid);
            if (endIdx > mid + 1)
                Sort(ref arr, mid + 1, endIdx);

            Merge(ref arr, startIdx, mid, endIdx);
        }

        private void Merge(ref int[] arr, int startIdx, int midIdx, int endIdx)
        {
            if (endIdx - startIdx < 1)
                return;

            int lIdx = startIdx;
            int rIdx = midIdx + 1;

            List<int> newArr = new List<int>();
            while (lIdx <= midIdx && rIdx <= endIdx)
            {
                if (arr[lIdx] > arr[rIdx])
                {
                    newArr.Add(arr[rIdx]);
                    rIdx++;
                }
                else
                {
                    newArr.Add(arr[lIdx]);
                    lIdx++;
                }
            }

            if (lIdx <= midIdx)
            {
                while (lIdx <= midIdx)
                {
                    newArr.Add(arr[lIdx]);
                    lIdx++;
                }
            }
            else if (rIdx <= endIdx)
            {
                while (rIdx <= endIdx)
                {
                    newArr.Add(arr[rIdx]);
                    rIdx++;
                }
            }

            for (int i = 0; i < newArr.Count; i++)
                arr[startIdx + i] = newArr[i];
        }
    }
}
