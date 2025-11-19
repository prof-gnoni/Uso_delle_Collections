using System;
using System.Collections.Generic; // FONDAMENTALE: Contiene il Dictionary

namespace Uso_dei_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ESERCITAZIONE 1: IL DICTIONARY ===");
            Console.WriteLine("Obiettivo: Associare manualmente una Chiave (Guid) a un Valore (Persona).\n");

            // 1. Creiamo alcune persone usando il costruttore "Nuovo"
            Persona p1 = new Persona("Mario", "Rossi", new DateTime(1980, 1, 1));
            Persona p2 = new Persona("Anna", "Verdi", new DateTime(1995, 5, 20));
            Persona p3 = new Persona("Luigi", "Bianchi", new DateTime(2000, 10, 10));

            // 2. Creiamo il Dictionary
            // <Guid, Persona> significa:
            // - Chiave (TKey): Guid (l'ID univoco)
            // - Valore (TValue): Persona (l'oggetto intero)

            Dictionary<Guid, Persona> rubrica = new Dictionary<Guid, Persona>();

            // 3. Inserimento (IL PUNTO CRITICO PER GLI STUDENTI)
            // Dobbiamo dire al Dictionary esplicitamente qual è la chiave.
            // NOTA: Stiamo "sprecando" fatica, perché p1.Id è già dentro p1!
            rubrica.Add(p1.Id, p1);
            rubrica.Add(p2.Id, p2);
            rubrica.Add(p3.Id, p3);

            Console.WriteLine($"Ho inserito {rubrica.Count} persone nella rubrica.");

            // 4. Ricerca Veloce (Lookup)
            // Immagina di avere solo un ID in mano (es. letto da un QR Code)
            Guid idDaCercare = p2.Id;

            Console.WriteLine($"\nCerco la persona con ID: {idDaCercare}...");

            // Il Dictionary trova l'elemento immediatamente, senza fare cicli!
            if (rubrica.ContainsKey(idDaCercare))
            {
                Persona trovata = rubrica[idDaCercare];
                Console.WriteLine("--> TROVATA!");
                Console.WriteLine(trovata.ToString());
            }
            else
            {
                Console.WriteLine("Persona non trovata.");
            }

            // 5. Ciclo su tutto il contenuto
            Console.WriteLine("\n--- Elenco Completo ---");
            // 'kvp' sta per KeyValuePair (Coppia Chiave-Valore)
            foreach (KeyValuePair<Guid, Persona> kvp in rubrica)
            {
                // kvp.Key   --> è il Guid
                // kvp.Value --> è l'oggetto Persona
                Console.WriteLine($"KEY: {kvp.Key.ToString().Substring(0, 8)}... -> VAL: {kvp.Value.Cognome} {kvp.Value.Nome}");
            }

            Console.WriteLine("\nPremi Invio per chiudere.");
            Console.ReadLine();
        }
    }
}