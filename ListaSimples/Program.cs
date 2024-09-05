using System.Collections;

//utilizando a lista simples 
// lista = é dinamica, tipo de array sem tamanho defindo. que se pode ir adicionando elementos a ele

ArrayList arrlist = new ArrayList();
arrlist.Add(1);
arrlist.Add("danoca");

//conjunto de elemento de uma só vez

arrlist.AddRange (new int []{1,2,3});
//metodo Add.() insere o valor ao final do vetor

arrlist.Insert (1, 546);
//metodo Insert possibilita  a inserção de um elemento em qualquer posição do vetor

//lendo valores da lista
object primeiro = arrlist[0]!;
int quarto  = (int)arrlist[3]!;

//percorrendo a lista com foreach
foreach(object obj in arrlist){
    Console.WriteLine( obj);
    }

//obtendo o tamanho total da lista
int  tamanho = arrlist.Count;
//obter a capacidade = quantos podem ser armazenados
int capacidade = arrlist.Capacity;

//percorrendo o modo classico
for (int i = 0; i < arrlist.Count; i++){
    Console.WriteLine ( $" | {arrlist[i]}");
}

//recusos importantes da lista:
//verificar se um valor é contido na lista
bool contemNome = arrlist.Contains ("polar");
if(!contemNome){
    Console.WriteLine ( "nome não encontrado");
}

//para saber o incide que contem o valor buscado
//neste caso se o valor exisitir na lista ele retorna o indice (int)
//caso o valor não exista na lista retorna  -1
int indice = arrlist.IndexOf ("polar");
if (indice>= 0){
    Console.WriteLine ( $"isto esta em [{indice}]");
}else
    Console.WriteLine ( "é, meu chapa, não tem não");

//é possivel remover  um elemento da lista
arrlist.Remove("danoca"); //pelo valor
arrlist.RemoveAt(4); //no indice
arrlist.RemoveRange(0,2);//primiero paramentro é  o indice e o segundo é a quantidade de elementos a serem removidos



