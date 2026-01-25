using MalzemeListesi.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace MalzemeListesi.Data
{
    public class MarkaRepository
    {
        public void Ekle(string ad)
        {
            using var con = Database.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Marka (Ad) VALUES (@ad)";
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.ExecuteNonQuery();
        }

        public List<Marka> TumunuGetir()
        {
            var list = new List<Marka>();

            using var con = Database.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Id, Ad FROM Marka";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Marka
                {
                    Id = reader.GetInt32(0),
                    Ad = reader.GetString(1)
                });
            }

            return list;
        }

        public void Sil(int id)
        {
            using var con = Database.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Marka WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
