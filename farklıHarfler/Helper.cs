namespace farklıHarfler;

public class Helper
{   //ahmet ve mehmet
    public static List<char> KelimeAyir(string inputFirst, string inputSecond)
    {
        List<char> harfListesi = inputFirst.ToList();
        List<char> harfListesiForSecond = inputSecond.ToList();
        List<char> varListesi = new List<char>();
        List<char> varMı = new List<char>();
        List<char> son = new List<char>();
        for (int i = 0; i < harfListesi.Count; i++)
        {
            for (int j = 0; j < harfListesiForSecond.Count; j++)
            {
                if (harfListesi[i] == harfListesiForSecond[j])
                {
                    varListesi.Add(harfListesi[i]);
                }
            }
        }
        varListesi = varListesi.Distinct().ToList();  
        varMı.AddRange(harfListesi);
        varMı.AddRange(harfListesiForSecond);
        son=varMı.Distinct().ToList();
        son=son.Except(varListesi).ToList();
       
        return son; 

    }
}