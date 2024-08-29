using System.Reflection.Metadata.Ecma335;
using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1 = new Person("danoca", 12);
Console.WriteLine(person1.Name);

Person person2 = new Person();
person2.Name = "Vladinho das cocodas";
person2.Age = 21;
Console.WriteLine(person2.Name);

Person person3 = new Person ()
            { 
                Name = "Doidinho de bairro", 
                Age = 55 
            };
            Console.WriteLine(person3.Name);
