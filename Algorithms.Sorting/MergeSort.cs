namespace Algorithms.Sorting;

public static class MergeSort
{
    public static List<int> SortInt(List<int> originalList)
    {
        List<int> list = [.. originalList];

        SortInt(list, 0, list.Count - 1);

        return list;
    }

    private static void SortInt(List<int> list, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            SortInt(list, left, mid);
            SortInt(list, mid + 1, right);

            MergeInt(list, left, mid, right);
        }
    }

    private static void MergeInt(List<int> list, int left, int mid, int right)
    {
        int leftLength = mid - left + 1;
        int rightLength = right - mid;

        (List<int> leftList, List<int> rightList) = ([], []);

        (int i, int j) = (0, 0);

        for (; i < leftLength; i++)
        {
            leftList.Add(list[left + i]);
        }
        for (; j < rightLength; j++)
        {
            rightList.Add(list[mid + 1 + j]);
        }

        (i, j) = (0, 0);

        int k = left;

        while (i < leftLength && j < rightLength)
        {
            if (leftList[i] <= rightList[j])
            {
                list[k] = leftList[i];
                i++;
            }
            else
            {
                list[k] = rightList[j];
                j++;
            }
            k++;
        }

        while (i < leftLength)
        {
            list[k] = leftList[i];
            k++;
            i++;
        }

        while (k != list.Count && j < rightLength)
        {
            list[k] = rightList[j];
            k++;
            j++;
        }
    }

    public static List<double> SortDouble(List<double> originalList)
    {
        List<double> list = [.. originalList];

        SortDouble(list, 0, list.Count - 1);

        return list;
    }

    private static void SortDouble(List<double> list, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            SortDouble(list, left, mid);
            SortDouble(list, mid + 1, right);

            MergeDouble(list, left, mid, right);
        }
    }

    private static void MergeDouble(List<double> list, int left, int mid, int right)
    {
        int leftLength = mid - left + 1;
        int rightLength = right - mid;

        List<double> leftList = [];
        List<double> rightList = [];

        int i = 0, j = 0;

        for (; i < leftLength; i++)
        {
            leftList.Add(list[left + i]);
        }
        for (; j < rightLength; j++)
        {
            rightList.Add(list[mid + 1 + j]);
        }

        (i, j) = (0, 0);
        int k = left;

        while (i < leftLength && j < rightLength)
        {
            if (leftList[i] <= rightList[j])
            {
                list[k] = leftList[i];
                i++;
            }
            else
            {
                list[k] = rightList[j];
                j++;
            }
            k++;
        }

        while (i < leftLength)
        {
            list[k] = leftList[i];
            i++;
            k++;
        }

        while (j < rightLength)
        {
            list[k] = rightList[j];
            j++;
            k++;
        }
    }

    public static List<float> SortFloat(List<float> originalList)
    {
        List<float> list = [.. originalList];

        SortFloat(list, 0, list.Count - 1);

        return list;
    }

    private static void SortFloat(List<float> list, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            SortFloat(list, left, mid);
            SortFloat(list, mid + 1, right);

            MergeFloat(list, left, mid, right);
        }
    }

    private static void MergeFloat(List<float> list, int left, int mid, int right)
    {
        // Calc the lengths of left and right
        int leftLength = mid - left + 1;
        int rightLength = right - mid;

        // Init left list and right list
        (float[] leftList, float[] rightList) = (new float[leftLength], new float[rightLength]);
        int i = 0, j = 0;
        // Copy the left list
        for (; i < leftLength; i++)
        {
            leftList[i] = list[left + i];
        }

        // Copy the right list
        for (; j < rightLength; j++)
        {
            rightList[j] = list[mid + 1 + j];
        }

        // Init the k for merged list
        // Init the i for left list
        // Init the j for right list

        i = 0;
        j = 0;
        int k = left;

        while (i < leftLength && j < rightLength)
        {
            if (leftList[i] <= rightList[j])
            {
                list[k] = leftList[i];
                i++;
            }
            else
            {
                list[k] = rightList[j];
                j++;
            }
            k++;
        }

        // Copy the remaining elements

        while (i < leftLength)
        {
            list[k] = leftList[i];
            i++;
            k++;
        }

        while (j < rightLength)
        {
            list[k] = rightList[j];
            j++;
            k++;
        }
    }
}

