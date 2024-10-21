using SelectionSort;

Console.WriteLine("Numbers:");
    int [] values = { 156, 90, 62, 1520, 85, 0, 895};
    SelectionSort.SelectionSort.Print(values);

Console.WriteLine();

Console.WriteLine("In ordem:");
    SelectionSort.SelectionSort.Sort<int>(values);
    SelectionSort.SelectionSort.Print(values);

Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Names:");
    string[] chars = {"Storm", "Nightcrawler", "Gambit", "Magneto"};
    SelectionSort.SelectionSort.Print(chars);

Console.WriteLine();

Console.WriteLine("In order:");
    SelectionSort.SelectionSort.Sort(chars);
    SelectionSort.SelectionSort.Print(chars);
    
Console.WriteLine();
