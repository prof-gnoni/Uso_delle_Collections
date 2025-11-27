using System.Collections.ObjectModel; // FONDAMENTALE: Contiene KeyedCollection

namespace Uso_delle_KeyedCollection
{
    // Definiamo la nostra collezione "PersonaCollection".
    // <Guid, Persona> significa: la chiave estratta sarà un Guid, l'oggetto è Persona.
    public class PersonaCollection : KeyedCollection<Guid, Persona>
    {
        // Questo è il metodo magico.
        // Quando aggiungiamo una persona, la collezione esegue questo metodo
        // per sapere quale proprietà usare come chiave.
        protected override Guid GetKeyForItem(Persona item)
        {
            return item.Id; // "Ehi collezione, la chiave è questa qui!"
        }
    }
}