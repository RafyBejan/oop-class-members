namespace class_oop
{
    internal class Program
    {
        static void Main(string[] args)
        { int noOfPersons = ReadNumber("Number of persons=", 3);
            Person[] arrayOfPersons = new Person[noOfPersons];
            for(int i=0;i<noOfPersons;i++)
            {
                Console.WriteLine($"Reading person at index {i}");
                Console.Write("FirstName=");
                string firstName = Console.ReadLine();

                Console.Write("LastName=");
                string lastName = Console.ReadLine();

                Console.Write("CNP=");
                string cnp = Console.ReadLine();

                Person p = new Person(cnp);
                p.FirstName = firstName;
                p.LastName = lastName;

                arrayOfPersons[i] = p;
            }
            for(int i=0;i<arrayOfPersons.Length;i++)
            {
                //  arrayOfPersons[i].PrintPerson();
                Person p = arrayOfPersons[i];
                Console.WriteLine(p.FirstName + " " + p.LastName + " - CNP:" + p.Cnp);

            }
         //   int maxlifespan = Person.MaxLifespanYears;
          //  Person p = new Person("2344");
          //  p.FirstName = "Florin";

           // Console.WriteLine(Person.PopulationCount);
          //  Console.WriteLine(p.FirstName);
          //  Console.WriteLine(p.LastName);
          //  Console.WriteLine(p.Cnp);
          //  Person.PopulationCount = 1; 
            // p.CNP="2344";
                                              // static se pune Person nu p.
            
        }
    }
}