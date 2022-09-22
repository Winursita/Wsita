using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    class Mobil
    {
        public string merk;
        public string tipe;
        public Ban ban;


        public Mobil(string merk, string tipe, Ban ban)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.ban = ban;
        }
        public virtual void NyalakanMesin()
        {
            Console.WriteLine($"Mesin mobil {merk} bertipe {tipe} menyala");
        }
        public virtual void MatikanMesin()
        {
            Console.WriteLine($"Mesin mobil {merk} bertipe {tipe} mati");
        }
    }



    /// Toyota

    class Toyota : Mobil
    {
        public Toyota(string merk, string tipe, Ban ban) : base ("Toyota", tipe, ban)
        {

        }
    }
    class Agya : Toyota
    {
        public Agya(string merk, string tipe, Ban ban) : base(merk, "Agya", ban)
        {

        }
    }
    class Avanza : Toyota
    {
        public Avanza(string merk, string tipe, Ban ban) : base(merk, "Avanza", ban)
        {

        }
        public void NyalakanLampu()
        {
            Console.WriteLine($"Lampu mobil {merk} bertipe {tipe} menyala");
        }
    }
    class Innova : Toyota
    {
        public Innova(string merk, string tipe, Ban ban) : base(merk, "Innova", ban)
        {

        }
    }



    /// Daihatsu

    class Daihatsu : Mobil
    {
        public Daihatsu(string merk, string tipe, Ban ban) : base ("Daihatsu", tipe, ban)
        {

        }
    }
    class Ayla : Daihatsu
    {
        public Ayla(string merk, string tipe, Ban ban) : base(merk, "Ayla", ban)
        {

        }
    }
    class Xenia : Daihatsu
    {
        public Xenia(string merk, string tipe, Ban ban) : base(merk, "Xenia", ban)
        {

        }
    }



    /// Honda

    class Honda : Mobil
    {
        public Honda(string merk, string tipe, Ban ban) : base("Honda", tipe, ban)
        {

        }
    }
    class Brio : Honda
    {
        public Brio(string merk, string tipe, Ban ban) : base(merk, "Brio", ban)
        {

        }
    }
    class Civic : Honda 
    {
        public Civic(string merk, string tipe, Ban ban) : base(merk, "Civic", ban)
        {
            
        }
        public void VtecKickedIn() {
            Console.WriteLine("Ngeeeng Wooosh!!!");
        }
    }



    /// Ban

    class Ban
    {
        public string merk;
        public Ban(string merk)
        {
            this.merk = merk;
        }
    }
    class Michelin : Ban
    {
        public Michelin(string merk) : base("Michelin")
        {

        }
    }
    class Bridgestone : Ban
    {
        public Bridgestone(string merk) : base("Bridgestone")
        {

        }
    }



    ///

    internal class Program
    {
        public static void Main(string[] args)
        {
            Ban ban1 = new Ban("Ban Michelin");
            Ban ban2 = new Ban("Ban Bridgestone");

            // No 1
            Console.WriteLine("No 1");
            Mobil mobil1 = new Agya("Toyota", "Agya", ban1);
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();
            
            // No 2
            Console.WriteLine("\nNo 2");
            Mobil mobil2 = new Avanza("Toyota", "Avanza", ban2);
            ((Avanza)mobil2).NyalakanLampu();

            // No 3
            Console.WriteLine("\nNo 3");
            Console.WriteLine("Merk ban mobil1 : " + mobil1.ban.merk);
            
            // No 4
            Console.WriteLine("\nNo 4");
            Mobil civic1 = new Civic("Honda", "Civic", ban2);
            ((Civic)civic1).VtecKickedIn();
            
            // No 5
            Console.WriteLine("\nNo 5");
            Honda honda1 = civic1;
            ((Civic)honda1).VtecKickedIn();
        }
    }
}