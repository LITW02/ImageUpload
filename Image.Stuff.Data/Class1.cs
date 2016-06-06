using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image.Stuff.Data
{
    public class Stuff
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public string ImageFileName { get; set; }
    }

    public class StuffManager
    {
        private string _connectionString;

        public StuffManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(string word, string imageFileName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Stuffs (Word, ImageFileName) VALUES " +
                                  "(@word, @fileName)";
                cmd.Parameters.AddWithValue("@word", word);
                cmd.Parameters.AddWithValue("@fileName", imageFileName);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Stuff> GetStuff()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM Stuffs";
                List<Stuff> stuff = new List<Stuff>();
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Stuff s = new Stuff();
                    s.Id = (int) reader["Id"];
                    s.Word = (string) reader["Word"];
                    s.ImageFileName = (string)reader["ImageFileName"];
                    stuff.Add(s);
                }

                return stuff;
            }
        } 

    }
}
