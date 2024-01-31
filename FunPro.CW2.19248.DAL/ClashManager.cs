using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW2._19248.DAL
{
    internal class ClashManager
    {
        public void Create(Clash clash)
        {
            using var conn = new SQLiteConnection();
            try
            {
                var sql = $"INSERT INTO " +
                    $"Clash (Player1, Player2, Date, Outcome) " +
                    $"VALUES ({clash.Player1}, " +
                    $"{clash.Player2}, " +
                    $"{DateTime.Now}, " +
                    $"{clash.Outcome})";
                using var command = new SQLiteCommand(sql, conn);
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        public List<Clash> GetAll()
        {
            using var conn = new SQLiteConnection();
            var result = new List<Clash>();
            try
            {
                var sql = $"SELECT Player1, Player2, Date, Outcome FROM Clash";
                using var command = new SQLiteCommand(sql, conn);
                conn.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var clash = new Clash
                    {
                        Player1 = (int)reader.GetValue(0),
                        Player2 = (int)reader.GetValue(1),
                        Date = Convert.ToDateTime(reader.GetValue(2)),
                        Outcome = (int)reader.GetValue(3)
                    };
                    result.Add(clash);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return result;
        }
    }
}
