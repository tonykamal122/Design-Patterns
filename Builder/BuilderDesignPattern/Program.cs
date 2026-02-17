namespace BuilderDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        //wrong way
        Person person = new Person()
        {
            Name = "Tony",
            Address = "12 street",
            Height = 100,
            Width = 500
        }; //kteer 
        //Build Design Pattern [Creatinal Design Pattern]
        IPersonBuilder personBuilder = new PersonBuilder();
        //fluent interface Design Pattern
        var person2 = personBuilder.SetAddress("12 street")
                                   .SetHeight(150)
                                   .SetName("Tony")
                                   .SetWidth(500)
                                   .Build();

        person2.Show();
        Console.WriteLine("\n--------------------------------\n");
        //we make it for Recipies [optional]
        PersonDirector dir = new PersonDirector();

        var person3 = dir.MakeDefaultPerson(personBuilder);
        person3.Show();

        //We make another builder if we change the behavoir of the builder
        //but if we change only the recipes we can make director only or use the builder direct

        //fixes
        /*
        Telescoping Constructors
        Object construction complexity
        Step-by-step building
        Enforcing build process
        */
    }
}
