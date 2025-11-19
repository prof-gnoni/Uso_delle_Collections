using System;
// Aggiungi questo using per l'attributo [JsonConstructor]
using System.Text.Json.Serialization;

namespace Uso_dei_Dictionary
{
    public class Persona
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }

        // (La tua proprietà 'Eta' e 'ToString' rimangono invariate...)
        public int Eta
        {
            get
            {
                int eta = DateTime.Now.Year - DataNascita.Year;
                if (DateTime.Now.DayOfYear < DataNascita.DayOfYear)
                {
                    eta--;
                }
                return eta;
            }
        }
        public override string ToString()
        {
            string dataFormattata = DataNascita.ToString("dd/MM/yyyy");
            return $"{Cognome}, {Nome} (Nato il: {dataFormattata}, Età: {Eta})";
        }

        // ---
        // 1. COSTRUTTORE PER *NUOVE* PERSONE
        // (Usato dal pulsante 'btnAggiungi')
        // ---
        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            Id = Guid.NewGuid(); // Crea un ID completamente nuovo
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
        }

        // ---
        // 2. NUOVO COSTRUTTORE PER *CARICARE* PERSONE
        // (Usato dal Caricamento JSON e dal nuovo Caricamento CSV)
        // ---
        [JsonConstructor] // Questo dice al deserializzatore JSON di usare questo
        public Persona(Guid id, string nome, string cognome, DateTime dataNascita)
        {
            Id = id; // Preserva l'ID originale letto dal file
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
        }
    }
}