namespace DSAPlayground.Arrays;

public static class ArrayExamples
{
    public static void RunAll()
    {
        Console.WriteLine("--- Array Examples ---");

        int[] arr = [64, 34, 25, 12, 22, 11, 90, 5];
        Console.WriteLine("Original: " + string.Join(", ", arr));

        arr = BubbleSort(arr);
        Console.WriteLine("Sorted: " + string.Join(", ", arr));
    }

    public static int FindLowest(int[] arr)
    {
        int lowest = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < lowest)
                lowest = arr[i];
        }

        return lowest;
    }

    // https://www.w3schools.com/dsa/dsa_algo_bubblesort.php
    public static int[] BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
        }

        return arr;
    }

    public static int[] BubbleSortImproved(int[] arr)
    {
        bool swapped = false;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    swapped = true;
                }
            }

            if (swapped)
                break;
        }

        return arr;
    }

    // https://www.w3schools.com/dsa/dsa_algo_selectionsort.php
    public static int[] SelectionSortImproved(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }

            (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
        }

        return arr;
    }

    // https://www.w3schools.com/dsa/dsa_algo_insertionsort.php
    public static int[] InsertionSortImproved(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int insertIndex = i;
            int currentValue = arr[i];

            for (int j = i - 1; j >= 0; j--)
            {
                if (arr[j] > currentValue)
                {
                    arr[j + 1] = arr[j];
                    insertIndex = j;
                }
                else
                    break;
            }

            arr[insertIndex] = currentValue;
        }

        return arr;
    }
}