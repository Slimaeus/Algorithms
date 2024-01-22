namespace Algorithms.Sorting;

public static class QuickSort
{
    public static List<int> SortInt(List<int> originalList)
    {
        List<int> list = [.. originalList];

        QuickSortInt(list, 0, list.Count - 1);

        return list;
    }

    private static void QuickSortInt(List<int> list, int left, int right)
    {
        if (left < right)
        {
            int p = PartitionInt2(list, left, right);

            QuickSortInt(list, left, p - 1);
            QuickSortInt(list, p + 1, right);
        }
    }

    private static int PartitionInt(List<int> list, int left, int right)
    {
        int pivot = list[right];
        int i = left;

        for (int j = left; j < right; j++)
        {
            if (list[j] < pivot)
            {
                (list[i], list[j]) = (list[j], list[i]);
                i++;
            }
        }

        (list[i], list[right]) = (list[right], list[i]);

        return i;
    }

    private static int PartitionInt2(List<int> list, int left, int right)
    {
        int pivot = list[left];
        int i = left - 1;
        int j = right + 1;


        while (true)
        {
            do
            {
                i++;
            } while (list[i] < pivot);
            do
            {
                j--;
            } while (list[j] > pivot);

            if (i < j)
            {
                (list[i], list[j]) = (list[j], list[i]);
            }
            else
            {
                return j;
            }
        }
    }

    public static List<double> SortDouble(List<double> originalList)
    {
        List<double> list = [.. originalList];

        QuickSortDouble(list, 0, list.Count - 1);

        return list;
    }

    private static void QuickSortDouble(List<double> list, int left, int right)
    {
        if (left < right)
        {
            int p = PartitionDouble(list, left, right);

            QuickSortDouble(list, left, p - 1);
            QuickSortDouble(list, p + 1, right);
        }
    }

    private static int PartitionDouble(List<double> list, int left, int right)
    {
        double pivot = list[right];
        int i = left;

        for (int j = left; j < right; j++)
        {
            if (list[j] < pivot)
            {
                (list[j], list[i]) = (list[i], list[j]);
                i++;
            }
        }

        (list[i], list[right]) = (list[right], list[i]);

        return i;
    }

    private static int PartitionDouble2(List<double> list, int left, int right)
    {
        double pivot = list[left];

        int i = left - 1;
        int j = right + 1;

        while (true)
        {
            do
            {
                i++;
            } while (list[i] < pivot);
            do
            {
                j--;
            } while (list[j] > pivot);

            if (i < j)
            {
                (list[i], list[j]) = (list[j], list[i]);
            }
            else
            {
                return j;
            }
        }
    }

    public static List<float> SortFloat(List<float> originalList)
    {
        List<float> list = [.. originalList];

        QuickSortFloat(list, 0, list.Count - 1);

        return list;
    }

    private static void QuickSortFloat(List<float> list, int left, int right)
    {
        if (left < right)
        {
            // Get the pivot index
            int p = PartitionFloatHoare(list, left, right);

            // Sort left and right side
            QuickSortFloat(list, left, p - 1);
            QuickSortFloat(list, p + 1, right);
        }
    }

    private static int PartitionFloatLomuto(List<float> list, int left, int right)
    {
        // Declare the pivot (value of the last element)
        float pivot = list[right];
        int i = left;

        for (int j = left; j < right; j++)
        {
            if (list[j] < pivot)
            {
                // Swap the value if the element smaller than the pivot
                (list[j], list[i]) = (list[i], list[j]);
                i++;
            }
        }

        // Swap the last element to the correct position
        (list[i], list[right]) = (list[right], list[i]);

        return i;
    }

    private static int PartitionFloatHoare(List<float> list, int left, int right)
    {
        float pivot = list[left];

        int i = left;
        int j = right;

        while (true)
        {
            while (list[i] < pivot)
            {
                i++;
            }
            while (list[j] > pivot)
            {
                j--;
            }

            if (i < j)
            {
                (list[i], list[j]) = (list[j], list[i]);
            }
            else
            {
                return j;
            }
        }
    }
}

