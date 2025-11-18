# 🚀 Esercitazioni C#: Dictionary vs KeyedCollection

Questo repository contiene due esercitazioni pratiche in C# progettate per comprendere la gestione delle collezioni di oggetti identificati da una chiave univoca (**Guid**).

L'obiettivo è confrontare l'approccio "classico" (`Dictionary`) con l'approccio "evoluto" (`KeyedCollection`) utilizzando una classe `Persona` realistica.

## 👤 Il Modello Dati: La Classe `Persona`

Tutti gli esempi utilizzano la stessa classe `Persona`, strutturata come segue:

* **`Id` (Guid):** Chiave univoca generata automaticamente alla creazione.
* **`Nome` & `Cognome`:** Dati anagrafici.
* **`DataNascita`:** Utilizzata per calcolare l'età.
* **`Eta`:** Proprietà di sola lettura calcolata dinamicamente in base alla data odierna.

```csharp
// Esempio di utilizzo
var p = new Persona("Mario", "Rossi", new DateTime(1980, 1, 1));
// L'ID viene generato automaticamente (es. "a1b2c3d4-...")
