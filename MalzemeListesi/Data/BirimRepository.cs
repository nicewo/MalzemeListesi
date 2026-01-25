using MalzemeListesi.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace MalzemeListesi.Data
{
    public class BirimRepository
    {
        public void Ekle(string ad)
        {
            using var con = Database.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Birim (Ad) VALUES (@ad)";
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.ExecuteNonQuery();
        }

        public List<Birim> TumunuGetir()
        {
            var list = new List<Birim>();

            using var con = Database.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Id, Ad FROM Birim";

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Birim
                {
                    Id = reader.GetInt32(0),
                    Ad = reader.GetString(1)
                });
            }

            return list;
        }
    }
}
