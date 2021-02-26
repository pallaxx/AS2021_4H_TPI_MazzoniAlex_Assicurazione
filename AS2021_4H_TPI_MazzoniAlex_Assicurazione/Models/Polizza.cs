using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_4H_TPI_MazzoniAlex_Assicurazione.Models
{
    class Polizza
    {
        string _nome;
        public string Nome { get => _nome; set => _nome = value; }

        string _cognome;
        public string Cognome { get => _cognome; set => _cognome = value; }

        DateTime _dataScadenza;
        public DateTime DataScadenza { get => _dataScadenza; set => _dataScadenza = value; }

        string _tipoAssicurazione;
        public string TipoAssicurazione { get => _tipoAssicurazione; set => _tipoAssicurazione = value; }

        public Polizza(string n, string c, DateTime d, string t)
        {
            _nome = n;
            _cognome = c;
            _dataScadenza = d;
            _tipoAssicurazione = t;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome:\t\t{_nome}");
            sb.AppendLine($"Cognome:\t{_cognome}");
            sb.AppendLine($"Data di Scadenza:{_dataScadenza:dd/MM/yyyy}");
            sb.AppendLine($"Tipo di Assicurazione:{_tipoAssicurazione}");

            return sb.ToString();
        }
    }
}
