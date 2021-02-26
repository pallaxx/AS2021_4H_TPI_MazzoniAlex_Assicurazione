using System;
using AS2021_4H_TPI_MazzoniAlex_Assicurazione.Models;

namespace AS2021_4H_TPI_MazzoniAlex_Assicurazione
{
    class Program
    {
        static void Main(string[] args)
        {
            Assicurazioni Polizze = new Assicurazioni();
            Polizze.InserisciPolizza("Alex", "Mazzoni", Convert.ToDateTime("01/10/1999"), "RCA");
            Polizze.InserisciPolizza("Mattia", "Bertozzi", Convert.ToDateTime("12/25/2010"), "VITA");

            Console.WriteLine("------------------- Stampa di tutta la lista -------------------");
            try
            {
                Console.WriteLine(Polizze.ListaPolizze());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Polizze.SalvataggioDati();
        }
    }
}
