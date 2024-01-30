int[] list = [0, 1, 3, 3, 4, 6, 2, 6, 7, 8, 6, 1, 3];

foreach (var item in FindTheMostAppearances(list))
{
    Console.WriteLine(item);
}

static int[] FindTheMostAppearances(int[] list)
{
    int[] result = new int[list.Length];

    Dictionary<int, int> appearanceDictionary = [];
    int maxAppearance = 0;
    foreach (int i in list)
    {
        if (!appearanceDictionary.TryAdd(i, 1))
        {
            appearanceDictionary[i] += 1;
            if (appearanceDictionary[i] > maxAppearance)
            {
                maxAppearance = appearanceDictionary[i];
            }
        }
    }

    return appearanceDictionary.Where(x => x.Value == maxAppearance).Select(x => x.Key).ToArray();
}