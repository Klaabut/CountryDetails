using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class CountryDetails
    {
        public string Name { get; set; }
        public string Cioc { get; set; }
        public string Domain { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }
        public string Population { get; set; }
        

        public List<CountryDetails> Languages { get; set; }
    }
    class Language
    {
        public string Name { get; set; }
    }
}
