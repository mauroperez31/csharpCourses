internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        string name = "Mauro ";
        var lastName = "Pérez"; //Va implicito
        Console.WriteLine($"Hello {name} {lastName}");
        Console.WriteLine("Hello a la antigua: " + name + " " + lastName);

        int myNumber = 100;
        int otherNumber = -500;
        float myFloatNumber = 3.14f;
        double myDoubleNumber = 3.1416; // Para moneda
        byte myLittleNumber = 255; // Valores entre 0 a 255;
        bool myBoolean = false;
        char myChar = 'M';

        const int myIntConst = 500;  // Este no puede ser modificada en tiempo de ejecución.
        name = "Mauro Alberto"; // Esto es posible porque name no es una constante, sino una variable.

        bool? myBoolNull = null;
        int? myIntNull = null;
        string? myStringNull = null;
 
        Console.WriteLine($"Hello {name} {lastName}");
        Console.WriteLine($"My number is {myNumber} with OtherNumber {otherNumber}");
        Console.WriteLine($"My number whith decimal is {myFloatNumber} with OtherNumber {myDoubleNumber}");
        Console.WriteLine("My little number is " + myLittleNumber + "My const int: "+myIntConst);
        Console.WriteLine($"My bool is: {myBoolean} and my Char is: {myChar}");
        Console.WriteLine($"My nulls bool: {myBoolNull}, int: {myIntNull}, string: {myStringNull}");
    }
}