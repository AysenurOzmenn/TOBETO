internal class Program
{
    private static void Main(string[] args)
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih"};
        
        string[] students2 = new string[3];
        students[0] = "Engin";
        students[1] = "Derin";
        students[2] = "Salih";

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        string[,] regions=new string[5, 3] 
        {
            { "A","B","C"},
            { "D","E","F"},
            { "G","H","I"},
            { "J","K","L"},
            { "M","N","O"},
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("*****************");
        }

        Console.ReadLine();
    }
}