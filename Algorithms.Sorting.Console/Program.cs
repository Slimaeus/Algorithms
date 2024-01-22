using Algorithms.Sorting;

int min = 0;
int max = 7;

List<int> intList = Enumerable.Range(min, max).Select(x => Random.Shared.Next()).ToList();
List<double> doubleList = Enumerable.Range(min, max).Select(x => Random.Shared.NextDouble()).ToList();
List<float> floatList = Enumerable.Range(min, max).Select(x => (float)Random.Shared.NextDouble()).ToList();

Console.WriteLine("Quick Sort");
var quickList = QuickSort.SortFloat(floatList);
foreach (var i in quickList)
{
    Console.WriteLine(i);
}


Console.WriteLine("Merge Sort");
var mergeList = MergeSort.SortFloat(floatList);
foreach (var i in mergeList)
{
    Console.WriteLine(i);
}


Console.WriteLine("Insertion Sort");
var insertionList = InsertionSort.SortInt(intList);
foreach (var i in insertionList)
{
    Console.WriteLine(i);
}

Console.WriteLine("Bubble Sort");
var bubbleList = BubbleSort.SortDouble(doubleList);
foreach (var i in bubbleList)
{
    Console.WriteLine(i);
}

Console.WriteLine("Selection Sort");
var selectionList = SelectionSort.SortDouble(doubleList);
foreach (var i in selectionList)
{
    Console.WriteLine(i);
}