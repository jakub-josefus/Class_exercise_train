using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrain
{
    class Train
    {
        Locomotive locomotive;
        List<IWagons> wagons;
        public Train() { }
        public Train(Locomotive locomotive)
        {
            this.locomotive = locomotive;
            this.wagons = new List<IWagons>();

        }
        public Train(Locomotive locomotive, List<IWagons> wagons)
        {
            this.locomotive = locomotive;
            this.wagons = wagons;
        }
        public void ConnectWagon(IWagons iwagons)
        {
            if (wagons.Count > 4)
            {
                Console.WriteLine($"Nelze přidat víc jak 5 vagonů");
            }
            else
            {
                wagons.Add(iwagons);
                Console.WriteLine($"Přidáno");
            }
        }
        public void DisconnectWagon(IWagons iwagons)
        {
            if (wagons.Contains(iwagons))
            {

                wagons.Remove(iwagons);
                Console.WriteLine("Odebráno");
            }
            else Console.WriteLine("Nelze najít požadovaný vagon");

        }
        public override string ToString()
        {
            string vypis = "Kompletní výpis vlaku:\n";
            vypis += $"Řidič je {locomotive.Driver.FirstName} {locomotive.Driver.LastName}\n";
            vypis += $"motor {locomotive.Engine.Type}\n";
            foreach (IWagons wag in wagons)
            {
                vypis += wag.ToString() + "\n";
            }
            return vypis;
        }

        public void ReserveChair(int cisloWagonu, int cisloSedadla)
        {
            if (cisloWagonu >= 0 && wagons.Count >= cisloWagonu)
            {
                Console.WriteLine("vagon existuje");
                if (wagons[cisloWagonu - 1] is PersonalWagon)
                {
                    Console.WriteLine("Lze rezervovat");

                    if (cisloSedadla > 0 && cisloSedadla < ((PersonalWagon)wagons[cisloWagonu - 1]).Chairs.Length)
                    {
                        Console.WriteLine("Lze vybrat sedadlo");
                        if (((PersonalWagon)wagons[cisloWagonu - 1]).Chairs[cisloSedadla].Reserved)
                        {
                            Console.WriteLine("sedadlo volné");
                            ((PersonalWagon)wagons[cisloWagonu - 1]).Chairs[cisloSedadla].Reserved = false;
                            Console.WriteLine("rezervováno");
                        }
                        else Console.WriteLine("sedadlo obsazeno");
                    }
                    else Console.WriteLine("spatne cislo sedadla");
                }
                else Console.WriteLine("špatný vagon");
            }
            else Console.WriteLine("Nelze najít vagon");
        }
        public void ListReservedChairs()
        {
            foreach (IWagons x in wagons)
            {
                if (x is PersonalWagon wagon)
                {
                    for (int i = 1; i < wagon.Chairs.Length; i++)
                    {
                        if (!wagon.Chairs[i].Reserved)
                        {
                            Console.WriteLine("číslo vagonu " + (wagons.IndexOf(x)+1) + " " + x.GetType().Name + " Sedadlo " + i + " Obsazeno");
                        }

                    }
                }
            }


        }
    }
}
