namespace class_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxlifespan = Person.MaxLifespanYears;
            Person p = new Person("2344");
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.CNP);
            Person.PopulationCount = 1; 
            // p.CNP="2344";
                                              // static se pune Person nu p.
            
        }
    }
}