namespace ISP;
// Interface Segregation Principle (ISP):
//"cLents should not be force to depend on interfaces they do not use,
//Ya3ni eh b2a? law hwa msh hysta3mel el haga el fel interface ba3malha interface lwa7dha 
class Program
{
    //wrong
    // public interface IWorker // lazm n2asm dah
    // {
    //     void Work();
    //     void Eat();
    // }
    // public class HumanWorker : IWorker
    // {
    //     public void Work() { }
    //     public void Eat() { }
    // }
    // public class RobotWorker : IWorker
    // {
    //     public void Work() { }
    //     public void Eat()
    //     {
    //         throw new NotImplementedException(); // ❌ مش بياكل
    //     }
    // }
    //true (✅)
    public interface IWorkable
    {
        void Work();
    }
    public interface IEatable
    {
        void Eat();
    }
    public class HumanWorker : IWorkable, IEatable
    {
        public void Work() { }
        public void Eat() { }
    }
    public class RobotWorker : IWorkable
    {
        public void Work() { }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
//SRP VS ISP
//interface mafhosh methods zyada
//SRP Single Responsipilty to change