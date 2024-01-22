namespace Algorithms.Sorting;

public static class BubbleSort
{
    public static List<int> SortInt(List<int> originalList)
    {
        List<int> list = [.. originalList];
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
        return list;
    }

    public static List<double> SortDouble(List<double> originalList)
    {
        List<double> list = [.. originalList];
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
        return list;
    }

    public static List<float> SortFloat(List<float> originalList)
    {
        List<float> list = [.. originalList];
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (list[j] > list[j + 1])
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }
        return list;
    }
}

