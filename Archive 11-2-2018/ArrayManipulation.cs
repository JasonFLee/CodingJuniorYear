using System;

namespace ArrayManipulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int seed = 1234;
            Random rand = new Random(seed);

            //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
            }





            //the following can be used to test your implementations. uncomment each line as you go to test.
            //note: you don't have to do each line sequentially. for example, implementing the findmin and findmax methods
            //will be very useful for your findrange method. hint... hint...

            Console.WriteLine("unsorted: ");
            PrintArray(array);
            Console.WriteLine("bubble sorted: ");
            PrintArray(BubbleSort(array));
            Console.WriteLine("selection sorted: ");
            PrintArray(SelectionSort(array));
            Console.WriteLine("mean: " + FindMean(array));
            Console.WriteLine("median: " + FindMedian(BubbleSort(array)));
            Console.WriteLine("range: " + FindRange(array));
            Console.WriteLine("mode: " + FindMode(array));
            Console.WriteLine("max: " + FindMax(array));
            Console.WriteLine("min: " + FindMin(array));

            Console.ReadLine();
        }

        /// <summary>
        /// prints the array in | x | y | z | a | b | c | format
        /// </summary>
        /// <param name="array">the array to be printed</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("| " + array[i] + " ");
            }
            Console.WriteLine("|");
        }

        /// <summary>
        /// Implements a bubble sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] BubbleSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);

            int n = mutatedArray.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < n; i++)
                {
                    if (mutatedArray[i - 1] > mutatedArray[i])
                    {
                        int temp = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[i - 1];
                        mutatedArray[i - 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);


            return mutatedArray;
        }

        /// <summary>
        /// Implements a selection sort algorithm to sort the array
        /// </summary>
        /// <param name="array">The array to sort</param>
        /// <returns>The sorted array</returns>
        public static int[] SelectionSort(int[] array)
        {
            int[] mutatedArray = new int[array.Length];
            array.CopyTo(mutatedArray, 0);

            int n = mutatedArray.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mutatedArray[i] < mutatedArray[j])
                    {
                        int temp = mutatedArray[i];
                        mutatedArray[i] = mutatedArray[j];
                        mutatedArray[j] = temp;
                    }
                }
            }
            return mutatedArray;
        }
        /// <summary>
        /// Finds the mean (average) of the array
        /// </summary>
        /// <param name="array">The array</param>+
        /// <returns>The mean</returns>
        public static float FindMean(int[] array)
        {

            float num = 0;
            for (int l = 0; l < array.Length; l++)
            {
                num += array[l];
            }
            num = num / array.Length;

            return num;
        }

        /// <summary>
        /// Finds the median (middle element of sorted array) of the array
        /// In the case that the array is an even length, average the two middle elements
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The median</returns>
        public static float FindMedian(int[] array)
        {
            BubbleSort(array);

            float median = 0;

            if (array.Length % 2 == 0)
            {

                float median1 = array[(array.Length / 2) - 1];

                float median2 = array[array.Length / 2];

                median = (median2 + median1) / 2;
            }
            else
            {
                median = array[array.Length / 2];
            }
          
            return median;
        }

        /// <summary>
        /// Finds the range (highest value - lowest value) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The range</returns>
        public static int FindRange(int[] array)
        {
            int range = FindMax(array) - FindMin(array);

            return range;
        }

        /// <summary>
        /// Finds the mode (most common occuring element) of the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The mode</returns>
        public static int FindMode(int[] array)
        {
            int[] frequencyArray = new int[10];
            for (int u = 0; u < array.Length; u++)
            {
                frequencyArray[u] = countmatches(array[u], array);

            }
            int maxIndex = FindMaxIndex(frequencyArray);


            return array[maxIndex];
        }
        public static int countmatches(int u, int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == u)
                {
                    count++;


                }
            }

            return count;

        }

        /// <summary>
        /// Finds the maximum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The maximum value</returns>
        public static int FindMax(int[] array)
        {

            int max = 0;
            for (int u = 0; u < array.Length; u++)
            {
                if (array[u] > max)
                {
                    max = array[u];
                }
            }
            return max;
        }
        public static int FindMaxIndex(int[] array)
        {
            int index = 0;
            int max = 0;
            for (int u = 0; u < array.Length; u++)
            {
                if (array[u] > max)
                {
                }
                max = array[u];
                index = u;
            }
            return index;
        }

        /// <summary>
        /// Finds the minimum value inside the array
        /// </summary>
        /// <param name="array">The array</param>
        /// <returns>The minimum value</returns>
        public static int FindMin(int[] array)
        {

            int min = 99999;
            for (int u = 0; u < array.Length; u++)
            {
                if (array[u] < min)
                {
                }
                min = array[u];
            }
            return min;
        }
    }
}
