/*
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class Studente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Eta { get; set; }
    
    public int Voto { get; set; }
}

public class ScuolaContext : DbContext
{
    public DbSet<Studente> Studenti { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string connStr = "server=localhost;database=scuola;user=root;password=root;";

        options.UseMySql(connStr, ServerVersion.AutoDetect(connStr));
    }
}

class Program
{
    static void Main(string[] args)
    {
        using (var db = new ScuolaContext())
        {
            Console.WriteLine("Connessione riuscita");

            // ---------------------------
            // CREATE
            // ---------------------------

            var studente = new Studente
            {
                Nome = "Mario",
                Cognome = "Rossi",
                Eta = 21,
                Voto = 8
            };

            db.Studenti.Add(studente);
            db.SaveChanges();

            Console.WriteLine("Studente inserito");


            // ---------------------------
            // READ
            // ---------------------------

            var studenti = db.Studenti.ToList();

            Console.WriteLine("\nLista studenti:");

            foreach (var s in studenti)
            {
                Console.WriteLine($"{s.Id} {s.Nome} {s.Cognome} {s.Eta}");
            }

            
            var promossi = db.Studenti.Where(s => s.Voto >= 6).ToList();
            
            Console.WriteLine(" Voti >= 6");
            foreach (var p in promossi)
            {
                Console.WriteLine($"Promosso: {p.Nome} {p.Cognome} con voto {p.Voto}");
            } 

            // ---------------------------
            // UPDATE
            // ---------------------------

            var studenteUpdate = db.Studenti.FirstOrDefault(s => s.Id == 1);

            if (studenteUpdate != null)
            {
                studenteUpdate.Eta = 30;
                db.SaveChanges();

                Console.WriteLine("\nStudente aggiornato");
            }
            
            
            var over20 = db.Studenti.Where(s => s.Eta > 20).ToList();
            
            Console.WriteLine("Età > 20");
            foreach (var o in over20)
            {
                Console.WriteLine($"{o.Nome} {o.Cognome} - Età effettiva: {o.Eta}");
            }
            
            
            var studentiOrdinati = db.Studenti
                .OrderBy(s => s.Voto) 
                .ThenBy(s => s.Nome) 
                .ToList();

            Console.WriteLine("\n Lista Ordinata");

            foreach (var s in studentiOrdinati)
            {
                Console.WriteLine($"Voto: {s.Voto} | Nome: {s.Nome} {s.Cognome}");
            }
            
            if (db.Studenti.Any())
            {
                double mediaVoti = db.Studenti.Average(s => s.Voto);
                
                int votoMax = db.Studenti.Max(s => s.Voto);
                
                int votoMin = db.Studenti.Min(s => s.Voto);
                
                Console.WriteLine($"Voto Medio:   {mediaVoti:F2}"); 
                Console.WriteLine($"Voto Massimo: {votoMax}");
                Console.WriteLine($"Voto Minimo:  {votoMin}");
            }
            else
            {
                Console.WriteLine("\nNessuno studente presente");
            }


            // ---------------------------
            // DELETE
            // ---------------------------

            var studenteDelete = db.Studenti.FirstOrDefault(s => s.Id == 1);

            if (studenteDelete != null)
            {
                db.Studenti.Remove(studenteDelete);
                db.SaveChanges();

                Console.WriteLine("Studente eliminato");
            }
        }

        Console.WriteLine("\nOperazioni completate");
    }
}

*/
