using System;

namespace AlgorithmsAnalysis
{
    public class TimSort : IResercheable
    {
        public const int RUN = 32;

        // This function sorts array from left index to
        // to right index which is of size at most RUN

        // Функция сортирует массив слева направо,
        // размер которого не превышает RUN
        public static void insertionSort(int[] array,
            int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int temp = array[i];
                int j = i - 1;
                while (j >= left && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = temp;
            }
        }

        // merge function merges the sorted runs

        // Функция объединяет отсортированные прогоны
        public static void merge(int[] array, int l, int m, int r)
        {
            // original array is broken in two parts
            // left and right array

            // Разделяем массив на 2 части
            int len1 = m - l + 1, len2 = r - m;
            int[] left = new int[len1];
            int[] right = new int[len2];
            for (int x = 0; x < len1; x++)
                left[x] = array[l + x];
            for (int x = 0; x < len2; x++)
                right[x] = array[m + 1 + x];

            int i = 0;
            int j = 0;
            int k = l;

            // After comparing, we merge those two array
            // in larger sub array

            // После сравнения объединяем их больший подмассив
            while (i < len1 && j < len2)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }

                k++;
            }

            // Copy remaining elements
            // of left, if any

            // Копируем оставшиеся элементы
            // левой части
            while (i < len1)
            {
                array[k] = left[i];
                k++;
                i++;
            }

            // Copy remaining element
            // of right, if any

            // Копируем оставшиеся элементы
            // правой части
            while (j < len2)
            {
                array[k] = right[j];
                k++;
                j++;
            }
        }

        // Iterative Timsort function to sort the
        // array[0...n-1] (similar to merge sort)

        //Итеративная функция Timsort для сортировки
        //массива[0...n-1] (аналогично сортировке слиянием)
        public static void timSort(int[] array, int n)
        {
            // Sort individual subarrays of size RUN

            // Сортировка подмассивов размера RUN
            for (int i = 0; i < n; i += RUN)
                insertionSort(array, i, Math.Min((i + RUN - 1), (n - 1)));

            // Start merging from size RUN (or 32).  Слияние элементов начинается с размера RUN (или 32)
            // It will merge                         потом до 64, 128, 256 и т.д.
            // to form size 64, then
            // 128, 256 and so on ....
            for (int size = RUN;
                 size < n;
                 size = 2 * size)
            {
                // Pick starting point of               Выбираем начальную точку 
                // left sub array. We                   левого подмассива.
                // are going to merge                   Далее объединяем массивы
                // arr[left..left+size-1]               [left, left+size-1] и массивы
                // and arr[left+size, left+2*size-1]    [left+size, left+2*size-1]
                // After every merge, we increase       После каждого слияния мы увеличиваем
                // left by 2*size                       left на 2*size
                for (int left = 0;
                     left < n;
                     left += 2 * size)
                {
                    // Find ending point of left sub array      Находим крайнюю точку левого подмассива
                    // mid+1 is starting point of               mid+1 будет начальной точкой
                    // right sub array                          правого подмассива
                    int mid = left + size - 1;
                    int right = Math.Min((left +
                        2 * size - 1), (n - 1));

                    // Merge sub array arr[left, mid] &      Объединяем подмассивы:
                    // arr[mid+1, right]                     [left, mid] и [mid+1, right]
                    if (mid < right)
                        merge(array, left, mid, right);
                }
            }
        }

        public override void Run(int[] array, int value)
        {
            int n = array.Length;
            timSort(array, n);
        }
        public TimSort(int size, string name) : base(size, name)
        {
        }
    }
}