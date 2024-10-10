using BubbleSort;

int [] inteiros = {0,6,45,18,115,13};
BubbleSort.BubbleSort.Print(inteiros);
BubbleSort.BubbleSort.Sort<int>(inteiros);
BubbleSort.BubbleSort.Print(inteiros);

Console.WriteLine("");
Console.WriteLine("Testar Char");
char[]chars=['l','r','c'];
BubbleSort.BubbleSort.Print(chars);
BubbleSort.BubbleSort.Sort(chars);
BubbleSort.BubbleSort.Print(chars);