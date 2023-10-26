internal class Program
{
    private static void Main(string[] args)
    {
        //Intro();
        string sentence = "My name is Ayşenur ÖZMEN";

        var result = sentence.Length;
        var result2 = sentence.Clone();
        sentence = "My name is Hasan ÖZMEN";

        bool result3 = sentence.EndsWith("N");
        bool result4 = sentence.StartsWith("My name");

        var result5 = sentence.IndexOf("name");
        var result6 = sentence.IndexOf("");
        var result7 = sentence.LastIndexOf("");
        var result8 = sentence.Insert(0, "Hello "); //0.karakterden itibaren hello ekle
        var result9 = sentence.Substring(3,4);  //Metni parçalamak için kull.(3.krkterden itibaren 4 al.)
        var result10 = sentence.ToLower(); //tüm karakterleri küçüğe çevirir.
        var result11 = sentence.ToUpper(); //tüm karakterleri büyüğe çevirir.
        var result12 = sentence.Replace(" ", "-"); //metin içindeki belli karakterleri çevirmek için kull..
        var result13 = sentence.Remove(2,4); //metinde belli bir indexten sonrasını atmak için kull.
        Console.WriteLine(result13);
    }

    private static void Intro()
    {
        string city = "Ankara";
        Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        string city2 = "İstanbul";
        /*string result = city + city2;
        Console.WriteLine(result);*/
        Console.WriteLine(String.Format("{0} {1}", city, city2));
    }
}