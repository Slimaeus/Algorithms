namespace Algorithms.Sorting;

public static class SelectionSort
{
    public static List<int> SortInt(List<int> originalList)
    {
        List<int> list = [.. originalList];
        for (int i = 0; i < list.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j] < list[minIndex])
                {
                    minIndex = j;
                }
            }
            if (i != minIndex)
            {
                (list[minIndex], list[i]) = (list[i], list[minIndex]);
            }
        }
        return list;
    }

    public static List<double> SortDouble(List<double> originalList)
    {
        List<double> list = [.. originalList];
        for (int i = 0; i < list.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j] < list[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                (list[minIndex], list[i]) = (list[i], list[minIndex]);
            }
        }
        return list;
    }

    public static List<float> SortFloat(List<float> originalList)
    {
        List<float> list = [.. originalList];

        for (int i = 0; i < list.Count - 1; i++)
        {
            int minIndex = i;
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] < list[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                (list[minIndex], list[i]) = (list[i], list[minIndex]);
            }
        }

        return list;
    }
}

