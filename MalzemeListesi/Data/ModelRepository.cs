using MalzemeListesi.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace MalzemeListesi.Data
{
    public class ModelRepository
    {
        public void Ekle(Model model)
        {
            using var con = Database.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Model (Ad, MarkaId, BirimId, AciklamaId)
                VALUES (@ad, @marka, @birim, @aciklama)";

            cmd.Parameters.AddWithValue("@ad", model.Ad);
            cmd.Parameters.AddWithValue("@marka", model.MarkaId);
            cmd.Parameters.AddWithValue("@birim", model.BirimId);
            cmd.Parameters.AddWithValue("@aciklama", model.AciklamaId);

            cmd.ExecuteNonQuery();
        }

        public List<Model> TumunuDetayliGetir()
        {
            var list = new List<Model>();

            using var con = Database.GetConnection();
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT
                    m.Id, m.Ad,
                    ma.Ad,
                    b.Ad,
                    a.Ad
                FROM Model m
                JOIN Marka ma ON ma.Id = m.MarkaId
                JOIN Birim b ON b.Id = m.BirimId
                JOIN Aciklama a ON a.Id = m.AciklamaId";

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new Model
                {
                    Id = r.GetInt32(0),
                    Ad = r.GetString(1),
                    MarkaAd = r.GetString(2),
                    BirimAd = r.GetString(3),
                    AciklamaAd = r.GetString(4)
                });
            }

            return list;
        }
    }
}
