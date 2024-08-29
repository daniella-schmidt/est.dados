using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02
{
    public class Person
    {
        private string _location = string.Empty;
        public string Name { get; set; }
        public int Age { get; set; }

        // metodo construtor
        public Person (string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
            Name = " ------ ";
        }

        // metodo para realocar a pessoa

        public void Realocate (string location)
        {
            if(!string.IsNullOrEmpty(location))
            {
                _location = location;
            }
        }

        public float GetDistance (string location)
        {
            return 0;
        }    
    }
}