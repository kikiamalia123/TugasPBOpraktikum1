using System.Runtime;
using System.Runtime.CompilerServices;



namespace TugasPBOpraktikum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vga Vga1 = new Vga("Vga Nvidia,dan Processor Core i5");
            Vga Vga2 = new Vga("Vga AMD, dan Processor Ryzen");

            Laptop laptop2 = new IdeaPad("LENOVO", "IdeaPad", Vga2);
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            ((IdeaPad)laptop2).NyalakanLampu();
            Console.WriteLine(laptop2.Vga.merk);
            Console.WriteLine();

            Laptop laptop1 = new VivoBook("ASSUS", "VivoBook", Vga1);
            laptop1.LaptopDinyalakan();
            laptop1.LaptopDimatikan();
            Console.WriteLine(laptop1.Vga.merk);
            Console.WriteLine();

            Laptop predator = new Predator("SAMSUNG", "Predator", Vga2);
            predator.LaptopDinyalakan();
            predator.LaptopDimatikan();
            ((Predator)predator).Ngoding();
            Console.WriteLine();

        }
    }
}

class Vga
{
    public string merk;
    public Vga(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : Vga
{
    public Nvidia(string merk) : base(merk)
    {
        merk = "ASSUS";
    }
}

class AMD : Vga
{
    public AMD(string merk) : base(merk)
    {
        merk = "LENOVO";
    }
}
class Laptop
{
    public string Merk;
    public string Tipe;
    public Vga Vga;

    public Laptop(string merk, string tipe, Vga Vga)
    {
        this.Merk = merk;
        this.Tipe = tipe;
        this.Vga = Vga;
    }

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.Merk}  {this.Tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.Merk}  {this.Tipe} mati");
    }
}

class IdeaPad : ASSUS
{
    public IdeaPad(string merk, string tipe, Vga Vga) : base("ASSUS", tipe, Vga)
    {
    }

    public void NyalakanLampu()
    {
        Console.WriteLine($"Laptop {this.Merk}  {this.Tipe} menyala");
    }
}

class VivoBook : ASSUS
{
    public VivoBook(string merk, string tipe, Vga Vga) : base(merk, "VivoBook", Vga)
    {
    }

}

class Assus : Laptop
{
    public Assus(string merk, string tipe, Vga Vga) : base(merk, "Assus", Vga)
    {
    }

}

class ASSUS : Laptop
{
    public ASSUS(string merk, string tipe, Vga Vga) : base("ASSUS", tipe, Vga)
    {
    }

}

class Infinix : Laptop
{
    public Infinix(string merk, string tipe, Vga Vga) : base(merk, "Infinix", Vga)
    {
    }

}

class HP : Laptop
{
    public HP(string merk, string tipe, Vga Vga) : base(merk, "HP", Vga)
    {
    }

}

class MSI : Laptop
{
    public MSI(string merk, string tipe, Vga Vga) : base("MSI", tipe, Vga)
    {
    }

}

class Xiaomi : Laptop
{
    public Xiaomi(string merk, string tipe, Vga Vga) : base(merk, "Xiaomi", Vga)
    {
    }

}

class Predator : Laptop
{
    public Predator(string merk, string tipe, Vga Vga) : base(merk, "Predator", Vga)
    {
    }

    public void Ngoding()
    {
        Console.WriteLine($"Ctak Ctak Ctak, error lagi!!");
    }

}
class AVITA : Laptop
{
    public AVITA(string merk, string tipe, Vga Vga) : base("AVITA", tipe, Vga)
    {
    }

}