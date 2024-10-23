using QuickSort;

Console.WriteLine("Testando o Quick Sort!");

int [] values = new int []{96,65,2,3,5,2,68,51};

QuickSort.QuickSort.Print<int>(values);
Console.WriteLine("Iniciando a ordenação");
QuickSort.QuickSort.Sort<int>(values, 0, values.Length - 1);
Console.WriteLine("Ordenação finalizada");
QuickSort.QuickSort.Print<int>(values);