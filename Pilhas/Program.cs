//basicamento as pilhas trabalham com uma estrutura LIFO (Last in Firt Out)
// 3 metodos importantes: PUSH() -> Insere um elemento no topo da pilha
//                        POP() -> Remove o elemento do topo da pilha
//                        PEEK() -> Retorna o elemento do topo da pilha, sem remove-lo

//Invertendo
Stack<char> caracteres = new Stack<char>();
foreach (char c in "ovo"){ //começa de trás para frente, começo s e termina J
    caracteres.Push(c);
    }

//Desispilhando
string invertido = string.Empty;
while(caracteres.Count>0){
    invertido += caracteres.Pop();
    }
Console.WriteLine(invertido);

string original = "ovo";
if(invertido == original){
        Console.WriteLine("é um palindrono");
    }else{
        Console.WriteLine("não é um palindromo");
    }