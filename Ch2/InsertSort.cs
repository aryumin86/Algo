using System;
namespace Ch2
{
    /// <summary>
    /// Сортировка вставкой. Взято из псевдокода.
    /// </summary>
    public static class InsertSort
    {
        public static int[] Sort(int[] arr){
            
            int key;
            int i;

            for (int j = 1; j < arr.Length; j++){
                key = arr[j];
                //Вставка arr[j] в отсортированную последовательность. 
                i = j - 1;
                while(i > -1 && arr[i] > key){
                    arr[i + 1] = arr[i];
                    i--;
                }
                arr[i + 1] = key;
            }

            return arr;
        }

        /// <summary>
        /// Сортировка вставкой по убыванию. Упражнение 2.1.2.
        /// </summary>
        /// <returns>The desc.</returns>
        /// <param name="arr">Arr.</param>
        public static int[] SortDesc(int[] arr){
			int key;
			int i;

            for (int j = 1; j < arr.Length; j++){
                key = arr[j];
                i = j - 1;
                while(i > -1 && arr[i] < key){
                    arr[i + 1] = arr[i];
                    i--;
                }
                arr[i + 1] = key;
            }

            return arr;
        }
    }


}
