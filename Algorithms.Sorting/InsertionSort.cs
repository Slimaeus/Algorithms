namespace Algorithms.Sorting;

public static class InsertionSort
{
    public static List<int> SortInt(List<int> originalList)
    {
        List<int> list = [.. originalList];

        for (int i = 1; i < list.Count; i++)
        {
            int key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }

        return list;
    }

    public static List<double> SortDouble(List<double> originalList)
    {
        List<double> list = [.. originalList];

        for (int i = 1; i < list.Count; i++)
        {
            double key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }

        return list;
    }

    public static List<float> SortFloat(List<float> originalList)
    {
        List<float> list = [.. originalList];

        for (int i = 1; i < list.Count; i++)
        {
            float key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }

        return list;
    }
}

