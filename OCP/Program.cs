namespace OCP;

// Open/Closed Principle (OCP)
// "Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification."
//emta a3mel kda? law fe aktar men implemention
class Program
{

    static void Main(string[] args)
    {
        //Polymorphism -> abstraction and implemention
        //ya3ni ba3mel no3 general lehom b2a ka interface dah by3malo implement we dah bymalo badal ma3mel class kbeer
        IShape shape = new Circle();
        /*
        When we use it? law kol mara badef feature gdeda lazm afta7 class we a3adel feh so we
        make a general interface
        */
    }
}
