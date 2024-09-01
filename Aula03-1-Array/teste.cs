using System;

class Vetor{
    static void Main(){
        int[] pair = new int [100];
        int[] odd = new int [100];
        
        int indexpair = 0;
        int indexodd = 0;

        for (int i =1; i <= 200; i++){
            if (i % 2 == 0){
                pair[indexpair] = i;
                indexpair++;
            }
            else{
                odd[indexodd]=1;
                indexodd++;
            }
        }
        Console.WriteLine("pair numbers: ");
        foreach (int number in pair)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\n\Odd Numbers: ")
        foreach (int number in odd)
        {
            Console.Write(number + " ");
        }
    }
}