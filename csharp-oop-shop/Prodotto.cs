using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public string Nome {  get; set; } 
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }
        public int Codice { get; }

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
            Random numeroRandom = new Random();
            this.Codice = numeroRandom.Next(1, 100000000);
        }

        public double PrezzoEIva() {
            return Prezzo * (Iva + 100)/100;
        }

        public string NomeCompleto()
        {
            return Convert.ToString(this.Codice) + this.Nome;
        }

        public string CodiceConPadLeft()
        {
            return Convert.ToString(this.Codice).PadLeft(8, '0');
        }
    }
}
