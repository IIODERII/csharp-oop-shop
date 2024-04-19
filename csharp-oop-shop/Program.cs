using System.Security.Cryptography.X509Certificates;

namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Prodotto[] prodotti =
            {
                new Prodotto("Maglietta", "E' una bella maglietta bianca", 12.5, 22),
                new Prodotto("Pantaloni", "Sono dei bei pantaloni blu", 35.70, 10),
                new Prodotto("Camicia", "E' una bella camicia verde", 100, 22),
                new Prodotto("Cappello", "E' un bel cappello nero", 5.50, 4),
                new Prodotto("Cravatta", "E' una bella cravatta rossa", 14.60, 22),
            };

            for(int i = 0; i < prodotti.Length; i++)
            {
                Console.WriteLine($"{i+1}.");
                Console.WriteLine($"Nome Prodotto: {prodotti[i].Nome}");
                Console.WriteLine($"Descrizione Prodotto: {prodotti[i].Descrizione}");
                Console.WriteLine($"Prezzo senza IVA: EUR {string.Format("{0:C}", prodotti[i].Prezzo)}");
                Console.WriteLine($"IVA prodotto: {prodotti[i].Iva}%");
                Console.WriteLine($"Prezzo con IVA: EUR {string.Format("{0:C}", prodotti[i].PrezzoEIva())}");
                Console.WriteLine($"Codice Prodotto: {prodotti[i].CodiceConPadLeft()}");
                Console.WriteLine($"Nome completo del prodotto: {prodotti[i].NomeCompleto()}");
                Console.WriteLine("\n");
            }
        }
    }
}
