int[,] number = new int[5,2];
int [,,] triNumbers = new int[5,4,3];

//podemos inicializar os valores do vetor no  momento da sua criação

int [,] iniNumbers = new int [,] {
    {9,5,-9},
    {4,72,-1},
    {9,33,-51},
    {67,5,-93},
    {6,98,-24}
};

//para acessar os valores contidos neste tipo de variável

int valor = iniNumbers[0,1]; // neste caso = 5

Console.WriteLine ($"iniNumber [0,1] == {valor}");

