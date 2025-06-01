namespace farklıHarfler;
/*Method kullanarak yapın.
2 kelimeyi sırayla sorup farklı harfleri yazdırın. harfleri tek satırda virgülle ayırın
örnek:
girilen 1. kelime orhan, 2. kelime ayhan
sonuç: o, r, a, y

string sunumundaki methodlar işinize yarayacaktır*/
class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("1. Kelime 2. Kelimeden Kısa veya eşit olmalı");
        Console.Write("1. Kelimeyi gir : ");
        var inputFirst=Console.ReadLine();
        Console.Write("2. Kelimeyi gir : ");
        var inputSecond=Console.ReadLine();
        List<char> varListesiProgram = Helper.KelimeAyir(inputFirst, inputSecond);
        foreach (var list in varListesiProgram)
        {
            Console.Write(list + ",");
        }

    }
}