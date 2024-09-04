/* Escreva um algoritmo que armazene em dois vetores separados os primeiros 100 números pares e ímpares.
No final, imprima a sequência armazenada em cada um deles. */

using System;

class Vetor{
    static void Main(){
        int[] pair = new int [100];
        int[] odd = new int [100];
        int indexpair = 0;
        int indexodd = 0;

        for (int i = 1; i <= 200; i++){
            if (i % 2 == 0){
                pair[indexpair] = i;
                indexpair++;
            }
            else{
                odd[indexodd] = i; 
                indexodd++;
            }
        }
        Console.WriteLine("Pair numbers: ");
        foreach (int number in pair)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine("\nOdd Numbers: "); 
        foreach (int number in odd)
        {
            Console.Write(number + " ");
        }
    }
}
