using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace class_oop
{
    internal class Person
    {
      
         // valoare implicita se poate modificain zona constructor(#1)
    

        private static int populationCount = 0;
        private static readonly int MaxLifespanYears = InitMaxLifespan();
     //   public const int Factor = 2; //const in alt const
     //   public const int  MaxLifespanYears= 60 * Factor + 10; //const sintaxa initializatoare
         public Person(string cnp) // acesta este un constructor 
        {     //readonly poate fi modificat in constructor(#2)
    
            Cnp = cnp; //underscol
            Person.PopulationCount++;//de fiecare data cand se creaza un cnp creste populatia
        }
        public string FirstName { get; set; } = " ";


        public string LastName { get; set; } = " ";
      
        public string Cnp
        {
            get;
        }
        public static int PopulationCount { get; private set; } = 0;
      
            
               
            
        
        public void PrintPerson()
        {
            Console.WriteLine($"{FirstName} {LastName} - CNP: {Cnp}");
        }

        public static void PrintPopulationCount()
        {

        }
        public static int InitMaxLifespan()
        {
            return 125;
            Console.Write("Max Lifespan");
            return Convert.ToInt32(Console.ReadLine());
        }
                                                    //static nu tine de un obiect anume,se modifica lucreaza cu classa
                                                   // instanta nu se modifica se foloseste numele obiectului
    }
}
