using System;
using MySql.Data.MySqlClient;

namespace ConexionDB
{
    class Conexion
    {
        public static MySqlConnection ConexionDB()
        {
            string server = "Server=localhost;";
            string db = "Database=example;";
            string user = "User ID=root;";
            string password = "Password=123456;";
            string pooling = "Pooling=false";

            string DB_URI = $"{server}{db}{user}{password}{pooling}";

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(DB_URI);
                return conexionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
