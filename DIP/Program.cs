namespace DIP;
// Dependency Inversion Principle (DIP):

// "High-level modules should not depend on low-level modules. Both should depend on abstractions."
//Ya3ni eh b2a? ya3ni delwa2ty ana 3andy haga ba tdepend 3ala haga tany tmam?
//el mafroud b2a sa3at momken a8ayar el haga el gwaha deh fe ay wa2t fa a3mel eh b2a?
//a3mel interface 
// ==========================================
// ❌ WRONG EXAMPLE (Violates DIP)
// ==========================================

public class MySqlDatabase
{
    public void Save()
    {
        Console.WriteLine("Saved to MySQL Database");
    }
}
public class OrderServiceWrong
{
    // ❌ High-Level depends directly on Low-Level
    private MySqlDatabase _database = new MySqlDatabase();

    public void CreateOrder()
    {
        _database.Save();
    }
}
// ==========================================
// ✅ CORRECT EXAMPLE (Applies DIP)
// ==========================================
// 1️⃣ Abstraction
public interface IDatabase
{
    void Save();
}
// 2️⃣ Low-Level Module depends on abstraction
public class MySqlDatabaseCorrect : IDatabase
{
    public void Save()
    {
        Console.WriteLine("Saved to MySQL Database");
    }
}
public class MongoDatabase : IDatabase
{
    public void Save()
    {
        Console.WriteLine("Saved to MongoDB Database");
    }
}
// 3️⃣ High-Level depends on abstraction
public class OrderServiceCorrect
{
    private readonly IDatabase _database;
    public OrderServiceCorrect(IDatabase database)
    {
        _database = database;
    }
    public void CreateOrder()
    {
        _database.Save();
    }
}
// ==========================================
// 🚀 MAIN
// ==========================================
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----- WRONG VERSION -----");
        var wrongService = new OrderServiceWrong();
        wrongService.CreateOrder();

        Console.WriteLine();

        Console.WriteLine("----- CORRECT VERSION -----");

        // You can switch implementation easily
        IDatabase database = new MySqlDatabaseCorrect();
        // IDatabase database = new MongoDatabase();

        var correctService = new OrderServiceCorrect(database);
        correctService.CreateOrder();
    }
}
