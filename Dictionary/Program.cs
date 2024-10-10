//diferente da tabela HASH, o dictionary nos permite especificar o tipo de dado que será utilizado nos pares
// Key --> Value
// isso nos fornece uma estrutura fortemente tipada
using Dictionary;

Dictionary<string, string> dictionaty = new Dictionary<string, string>(){
  {"Chave1", "Valor1"},
  {"Chave2", "Valor2"},
  {"Chave3", "Valor3"}
};

// obter o valor do dictionary
string val = dictionaty["Chave1"];
try{
    val = dictionaty["Chave4"];
}catch(Exception ex){
    Console.WriteLine("erro ao obter valor");
    Console.WriteLine (ex.Message);
}

//verificando se a chave existe antes de acessar
// para evitar erros e prejuizos na aplicação
if (dictionaty.ContainsKey("Chave2")){
    Console.WriteLine($"Chave2 existe: {dictionaty ["Chave2"]}");
}

dictionaty.TryGetValue("Chave5", out string? valor);
if (valor is not null){
    Console.WriteLine($"Chave5 existe: {valor}");
}

//podemos adicionar da mesma forma pela chaver inexistente 
dictionaty["Chave0"]= "Valor0";

//percorrer
foreach (KeyValuePair <string, string> kvp in dictionaty){
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");

}

//utilizando tipos abstratos de dados com o Dictionary

Dictionary<int, Person> dicPerson= new Dictionary <int, Person>();

dicPerson.Add(
    1, new Person(){
        Id=0,
        Name="nini",
        BirthDate = new DateTime(2000, 1, 30)
    }
);

dicPerson.Add(
    2, new Person(){
        Id=1,
        Name="jojo",
        BirthDate = new DateTime(1980, 7, 14)
    }
);

foreach (KeyValuePair<int, Person> kvp in dicPerson);{
    Console.WriteLine($"{kvp.Key}, Name: {kvp.Value.Name}, BirthDate: {kvp.Value.BirthDate}, Id: {kvp.Value.Id}");
}
