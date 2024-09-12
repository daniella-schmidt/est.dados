using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaGererica
{
    public enum CountryEnum{
        BR, US, JP, KO, IT, AR
    }
    public class Person
    {
        public string ? Name {get; set;}
        public int Age {get; set;}
        public CountryEnum Country {get; set;}
    }
}