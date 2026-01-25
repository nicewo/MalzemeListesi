using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace MalzemeListesi.Data
{
    public static class DatabaseService
    {
        private static string DbPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MalzemeListesi.db");

        private static string ConnectionString =>
            $"Data Source={DbPath}";

        public static void Initialize()
        {
            if (File.Exists(DbPath))
                return;

            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE Marka (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Ad TEXT NOT NULL UNIQUE
                );

                CREATE TABLE Birim (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Ad TEXT NOT NULL UNIQUE
                );

                CREATE TABLE Aciklama (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Ad TEXT NOT NULL
                );

                CREATE TABLE Model (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Ad TEXT NOT NULL,
                    MarkaId INTEGER NOT NULL,
                    BirimId INTEGER NOT NULL,
                    AciklamaId INTEGER NOT NULL,
                    FOREIGN KEY (MarkaId) REFERENCES Marka(Id),
                    FOREIGN KEY (BirimId) REFERENCES Birim(Id),
                    FOREIGN KEY (AciklamaId) REFERENCES Aciklama(Id)
                );
            ";

            command.ExecuteNonQuery();
        }
    }
}
