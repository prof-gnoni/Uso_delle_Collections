using System;
// Non serve System.Collections.Generic qui, perché usiamo la nostra classe PersonaCollection

namespace Uso_delle_KeyedCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ESERCITAZIONE 2: KEYED COLLECTION ===");
            Console.WriteLine("Obiettivo: Usare una collezione che estrae la chiave automaticamente.\n");

            Persona p1 = new Persona("Mario", "Rossi", new DateTime(1980, 1, 1));
            Persona p2 = new Persona("Anna", "Verdi", new DateTime(1995, 5, 20));

            // 1. Creiamo la NOSTRA collezione intelligente
            PersonaCollection persone = new PersonaCollection();

            // 2. Inserimento (MOLTO PIÙ PULITO)
            // Guarda la differenza: non devo specificare l'ID!
            // La collezione chiama "GetKeyForItem" e se lo prende da sola.
            persone.Add(p1);
            persone.Add(p2);

            Console.WriteLine($"Ho inserito {persone.Count} persone.");

            // 3. Ricerca per Chiave (Come il Dictionary)
            // Funziona esattamente come prima
            Guid idDiAnna = p2.Id;
            if (persone.Contains(idDiAnna))
            {
                Console.WriteLine("\nRecupero Anna tramite ID:");
                Console.WriteLine(persone[idDiAnna].ToString());
            }

            // 4. Ricerca per Indice (BONUS!)
            // Il Dictionary NON può farlo. La KeyedCollection sì.
            // Possiamo dire "Dammi la prima persona inserita".
            Console.WriteLine("\nRecupero la PRIMA persona inserita (Indice 0):");
            Console.WriteLine(persone[0].ToString());

            Console.WriteLine("\nPremi Invio per chiudere.");
            Console.ReadLine();

            foreach (var persona in persone)
            {
                Console.WriteLine(persona.ToString());

            }
        }
    }
}