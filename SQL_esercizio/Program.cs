using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string connStr = "server=localhost;database=cd_musicali;user=root;password=root;";

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            Console.WriteLine("1 Inserisci cd");
            Console.WriteLine("2 Visualizza cd");
            Console.WriteLine("3 Modifica cd");
            Console.WriteLine("4 Elimina cd");

            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.Write("Titolo: ");
                    string titolo = Console.ReadLine();

                    Console.Write("Cantante: ");
                    string cantante = Console.ReadLine();

                    Console.Write("Data Uscita: ");
                    int data_uscita = int.Parse(Console.ReadLine());

                    string insert = "INSERT INTO cd (titolo,cantante,data_uscita) VALUES (@titolo,@cantante,@data_uscita)";
                    MySqlCommand cmdInsert = new MySqlCommand(insert, conn);

                    cmdInsert.Parameters.AddWithValue("@titolo", titolo);
                    cmdInsert.Parameters.AddWithValue("@cantante", cantante);
                    cmdInsert.Parameters.AddWithValue("@data_uscita", data_uscita);

                    cmdInsert.ExecuteNonQuery();

                    Console.WriteLine("cd inserito");
                    break;

                case 2:

                    string select = "SELECT * FROM cd";
                    MySqlCommand cmdSelect = new MySqlCommand(select, conn);

                    using (MySqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        Console.WriteLine("\nLista cd");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                reader["id"] + " " +
                                reader["titolo"] + " " +
                                reader["cantante"] + " " +
                                reader["data_uscita"]
                            );
                        }
                    }

                    break;

                case 3:

                    Console.Write("ID cd: ");
                    int idUpdate = int.Parse(Console.ReadLine());

                    Console.Write("Nuova data: ");
                    int nuovaData = int.Parse(Console.ReadLine());

                    string update = "UPDATE cd SET data_uscita=@data_uscita WHERE id=@id";
                    MySqlCommand cmdUpdate = new MySqlCommand(update, conn);

                    cmdUpdate.Parameters.AddWithValue("@data_uscita", nuovaData);
                    cmdUpdate.Parameters.AddWithValue("@id", idUpdate);

                    cmdUpdate.ExecuteNonQuery();

                    Console.WriteLine("Cd aggiornato");

                    break;

                case 4:

                    Console.Write("ID cd da eliminare: ");
                    int idDelete = int.Parse(Console.ReadLine());

                    string delete = "DELETE FROM cd WHERE id=@id";
                    MySqlCommand cmdDelete = new MySqlCommand(delete, conn);

                    cmdDelete.Parameters.AddWithValue("@id", idDelete);

                    cmdDelete.ExecuteNonQuery();

                    Console.WriteLine("Cd eliminato");

                    break;

                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        }
    }
}
