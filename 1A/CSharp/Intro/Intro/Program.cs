internal class Program
{
    //***Bu projede başlangıç ve veri tipleri örnekleri yapıldı.***
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        double number5 = 10.4;
        decimal number6 = 10;
        char character = 'a';
        string city = "Ankara";
        bool   condition = false;
        byte   number4 = 16;                     //8bit
        short  number3 = 32767;                  //16bit
        int    number1 = 2147483647;             //32bit
        long   number2 = -9223372036854775807;   //64bit
        var number7 = 10;
        //number7 = 'A';
        Console.WriteLine("Number1 is {0}", number1);
        Console.WriteLine("Number2 is {0}", number2);
        Console.WriteLine("Number3 is {0}", number3);
        Console.WriteLine("Number4 is {0}", number4);
        Console.WriteLine("Number5 is {0}", number5);
        Console.WriteLine("Number6 is {0}", number6);
        Console.WriteLine("Character is {0}", character);
        Console.WriteLine((int)Days.Friday);
        Console.ReadLine();
    }
}
enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}