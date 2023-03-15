using System;

public class KodeBuah
{
    private static readonly System.Collections.Generic.Dictionary<string, string> Table = new System.Collections.Generic.Dictionary<string, string>() {
        { "Apel", "A00" },
        { "Aprikot", "B00" },
        { "Alpukat", "C00" },
        { "Pisang", "D00" },
        { "Paprika", "E00" },
        { "Blackberry", "F00" },
        { "Ceri", "G00" },
        { "Kelapa", "H00" },
        { "Jagung", "I00" },
        { "Kurma", "J00" },
        { "Durian", "K00" },
        { "Anggur", "L00" },
        { "Melon", "M00" },
        { "Semangka", "N00" },
    };
    
    public static string GetKodeBuah(string buah)
    {
        if (Table.ContainsKey(buah))
        {
            return Table[buah];
        }
        return "Kode Buah tidak ditemukan.";
    }
}

public class PosisiKarakterGame
{
    private State state;

    public PosisiKarakterGame()
    {
        state = State.Berdiri;
        Console.WriteLine("posisi standby");
    }
    public void Tengkurap()
    {
        state = State.Tengkurap;
        Console.WriteLine("posisi istirahat");
    }
    private enum State
    {
        Berdiri,
        Tengkurap
    }
}


class Program
{
    static void Main(string[] args)
    {
        string kodebuah = KodeBuah.GetKodeBuah("Apel");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Aprikot");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Alpukat");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Pisang");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Paprika");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Blackberry");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Ceri");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Kelapa");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Jagung");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Kurma");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Durian");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Anggur");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Melon");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Semangka");
        Console.WriteLine(kodebuah);
        kodebuah = KodeBuah.GetKodeBuah("Ga tau");
        Console.WriteLine(kodebuah);

        Console.WriteLine("==========================================");

        PosisiKarakterGame karakter = new PosisiKarakterGame();
        karakter.Tengkurap();
    }
}