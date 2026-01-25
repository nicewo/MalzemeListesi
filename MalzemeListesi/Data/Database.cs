using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace MalzemeListesi.Data
{
    public static class Database
    {
        private static readonly string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MalzemeListesi.db");

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection($"Data Source={DbPath}");
        }
    }
}
