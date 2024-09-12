using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livros
{
     public enum Editor
     {
        Darkside, Intrinsseca, HarperCollins, Record
    }
    public class Books
    {
        public string ? Name {get; set;}
        public int numberpage {get; set;}
        public string?  Author {get; set;}
        public Editor? Editor {get; set;}

    }
}
