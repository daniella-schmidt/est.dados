int [,] num = new int [10,10];

for (int i = 0; i < num.GetLength(0); i++)
{
 for (int j = 0; j < num.GetLength(1); j++)
 {
 num[i, j] = (i + 1) * (j + 1);
 }
}

for (int i = 0; i < num.GetLength(0); i++)
{
 for (int j = 0; j < num.GetLength(1); j++)
 {
 Console.Write("{0,4}", num[i, j]);
 }
 Console.WriteLine();
}
