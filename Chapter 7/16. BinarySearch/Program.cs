int[] arr = { 2, 3, 4, 10, 40 };

BinarySearch(arr, 10);

static void BinarySearch(int[] arr, int target)
{
    Array.Sort(arr);
    int low = 0;
    int high = arr.Length - 1;

    while (low <= high)
    {
        int mid = low + ((high - low) / 2);

        if (arr[mid] < target)
            low = mid + 1;
        else if (arr[mid] > target)
            high = mid - 1;
        else if (arr[mid] == target)
        {
            Console.WriteLine($"Element is present at index {Array.IndexOf(arr, arr[mid])}");
            return;
        }
        else
        {
            Console.WriteLine("Element is not present in array");
            return;
        }
    }
}