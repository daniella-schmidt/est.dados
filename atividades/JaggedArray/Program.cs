//é conhecido como vetor dos vetores

int [][] numbers = new int [5][]; //[][] indica que é um vetor de vetor, 4 posições contendo vetores de tamanho indefinido

numbers [0] = new int []{1,2,3};
numbers [1] = new int []{4,3,2,1,0};
numbers [2] = new int []{1,2,5};
numbers [3] = new int []{67};
numbers [4] = null!;

//para obter valor de jaggedarray 
int [] valor = numbers [0][2]; //valor de valor é 3, veja o numbers0
Console.WriteLine(valor);

numbers [1][2] = 0;
Console.WriteLine(  numbers [1][2] );
