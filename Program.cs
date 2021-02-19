using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEST TRAIN");
            Person stewardka = new Person("Lenka", "Kozáková");
            BusinessWagon business = new BusinessWagon(6, stewardka);
            NightWagon spaci = new NightWagon(3, 6);
            Hopper nakladni = new Hopper(2500.65);
            Person ridic = new Person("Karel", "Novák");
            Engine motor = new Engine("diesel");
            Locomotive lokomotiva = new Locomotive(ridic, motor);
            List<IWagons> ListPrvnihoVlaku = new List<IWagons> { business, spaci, nakladni };
            Train prvniVlak = new Train(lokomotiva, ListPrvnihoVlaku);
            Hopper nakladni2 = new Hopper(1500);
            prvniVlak.ConnectWagon(nakladni2);            
            prvniVlak.ReserveChair(1, 5);
            prvniVlak.ListReservedChairs();
            Console.WriteLine("Kompletní Výpis\n");
            Console.WriteLine(prvniVlak.ToString());



            Console.WriteLine("PARNI LOKOMOTIVA");
            Engine motorParni = new Engine("parni lokomotiva");
            Locomotive lokomotiva2 = new Locomotive(ridic, motorParni);
            BusinessWagon business2 = new BusinessWagon(6, stewardka);
            BusinessWagon business3 = new BusinessWagon(6, stewardka);
            NightWagon spaci2 = new NightWagon(3, 6);
            Hopper nakladni10 = new Hopper(2500.65);
            Hopper nakladni11 = new Hopper(2500.65);
            List<IWagons> ListDruhehoVlaku = new List<IWagons> { business2, spaci2, nakladni10, business3, nakladni11 };
            Train druhyVlak = new Train(lokomotiva2, ListDruhehoVlaku);
            Console.WriteLine("Pridani vagonu");
            druhyVlak.ConnectWagon(nakladni10);
            druhyVlak.ReserveChair(1, 6);
            Console.WriteLine("Opakované zadání");
            druhyVlak.ReserveChair(1, 6);
            druhyVlak.ReserveChair(4, 6);
            druhyVlak.ListReservedChairs();
            Console.WriteLine("Kompletní Výpis\n");
            Console.WriteLine(druhyVlak.ToString());
        }
    }
}
