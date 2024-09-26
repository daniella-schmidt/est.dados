// ex.: AGENDA TELEFONICA

using System.Collections;
using System.Collections.Generic;

Hashtable phoneBook = new Hashtable(){
    //{ "chave", "valor" },
    {"John", "123456"},
    {"kelly", "123469"},
    {"maria", "097574"}
};

// é possivel adicionar elemnetos de diversas formas
// pelo proprio indice chave inexistente

phoneBook["carol"]= "4365477";

//  ou pelo metodo Add()
phoneBook.Add("sla", "3579356");

// entretanto a tabela hash verifica se  a chave já existe antes de adicionar 
// se a chave já existe, o valor é atualizado com uma Exception

try{
    phoneBook.Add ("kelly","123469");
}catch(Exception ex){
    // o erro é lançado quando a chave já existe
    Console.WriteLine($"erro ao tentar incluir valor já existente");
    Console.WriteLine(ex.Message);
}

//percorrendo a agenda
Console.WriteLine("Agenda Telefonica");
if (phoneBook.Count==0){
    Console.WriteLine("agenda vazia");
}else{
    foreach( DictionaryEntry entry in phoneBook){
        Console.WriteLine($"{entry.Key}:{entry.Value}");
    }
}

