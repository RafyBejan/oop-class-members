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
        private string _firstName = "John";
          private string _lastName = "Doe";
        private readonly string _cnp="1234"; // valoare implicita se poate modificain zona constructor(#1)
    

        private static int populationCount = 0;
        private static readonly int MaxLifespanYears = InitMaxLifespan();
     //   public const int Factor = 2; //const in alt const
     //   public const int  MaxLifespanYears= 60 * Factor + 10; //const sintaxa initializatoare
         public Person(string cnp) // acesta este un constructor 
        {     //readonly poate fi modificat in constructor(#2)
    
            _cnp = cnp; //underscol
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {     if(string.IsNullOrEmpty(value))
                {
                    _firstName = value;
                }
                else
                {
                    _firstName = string.Empty;
                }
                _firstName = value;
            }
        }
        public void PrintPerson()
        {
            
        }

        public static void PrintPopulationCount()
        {

        }
        public static int InitMaxLifespan()
        {
            Console.Write("Max Lifespan");
            return Convert.ToInt32(Console.ReadLine());
        }
                                                    //static nu tine de un obiect anume,se modifica lucreaza cu classa
                                                   // instanta nu se modifica se foloseste numele obiectului
    }
}
