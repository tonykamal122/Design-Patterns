namespace LSP;
// Liskov Substitution Principle (LSP):
// "Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program."
//ya3ni eh b2a? ya3ni [Subtypes must be substitutable for their base types.] 
//ex -: Base obj = new Derived(); => kman el derived msh el mafroud yab2a 3aks el parent bta3o
//ya3ni law fe method maslan htaksar el base a3malha interface lwa7dha
//[ya3ni el parent lazm yab2a 3ando el hagat el moshtakra bean kol types ❇️]
/*
❌
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying...");
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException(); //hna wrong leah? changed the parent behavior
    }
}
✅
public class Bird{}

public interface IFlyingBird => interface for it
{
    void Fly();
}

public class Eagle : Bird, IFlyingBird
{
    public void Fly()
    {
        Console.WriteLine("Flying...");
    }
}

public class Ostrich : Bird
{
}

*/
class Program
{
    static void Main(string[] args)
    {
        IShape Shape = new Square() { Side = 5 };
        Console.WriteLine(Shape.CalcArea());
    }
}
