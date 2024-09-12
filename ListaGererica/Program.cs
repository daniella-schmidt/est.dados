using ListaGererica;

List <double> numbers = new List<double> ();
do{
    Console.WriteLine("informe um número: ");
    string? numberStr = Console.ReadLine ();
    //validando a entrada do usuario
    if (!double.TryParse(numberStr, out double number)){
        break;
    }
    numbers.Add(number);
    Console.WriteLine( $"a média dos valores é {numbers.Average()}");
}
while(true);

// -- Lista de pessoas
List <Person> people = new List <Person> ();
Person p1 = new Person();
p1.Name = "João";
p1.Age = 12;
p1.Country = CountryEnum.BR;
people.Add(p1);

p1.Name = "boboca";

people.Add(new Person(){
    Name= "Lee Jeno",
    Age = 24,
    Country = CountryEnum.KO
});

Person p3 = new Person(){
    Name= "mocotó",
    Age = 30,
    Country = CountryEnum.US
};
people.Add(p3);

//formas de percorrer lista generica
foreach(Person p in people){
    Console.WriteLine(p.Name);
}
//Modo for tradicional
for (int i =0; i<people.Count; i++){
    Console.WriteLine( $"nome: {people[i].Name}");
}