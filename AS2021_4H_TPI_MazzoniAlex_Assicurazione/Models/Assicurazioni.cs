using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AS2021_4H_TPI_MazzoniAlex_Assicurazione.Models
{
    class Assicurazioni
    {
        List<Polizza> davide = new List<Polizza>();

        public Assicurazioni() { }
        public void InserisciPolizza(string n, string c, DateTime d, string t)
        {
            davide.Add(new Polizza(n, c, d, t));
            Console.WriteLine("Polizza Aggiunta di {0} {1}\n", c, n);
        }

        public string ListaPolizze()
        {
            Console.WriteLine("Lista Strumenti:\n");

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < davide.Count; i++)
                sb.AppendLine(davide[i].ToString());

            return sb.ToString();
        }

        public void SalvataggioDati()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\t\tLISTA STRUMENTI\t{DateTime.Today:dd/MM/yyyy}");
            for (int i = 0; i < davide.Count; i++)
                sb.AppendLine(davide[i].ToString());

            File.AppendAllText("ListaStrumenti.txt", sb.ToString());
        }

    }
}
