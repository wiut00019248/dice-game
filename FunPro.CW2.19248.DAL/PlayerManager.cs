using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FunPro.CW2._19248.DAL
{
    internal class PlayerManager
    {
        public void Create(Player player)
        {
            using var conn = new SQLiteConnection();
            try
            {
                var sql = $"INSERT INTO " +
                    $"Player (Name, IsPvpEnabled, LastGameDate, Score) " +
                    $"VALUES ('{player.Name}', " +
                    $"{Convert.ToInt64(player.IsPvpEnabled)}, " +
                    $"{Convert.ToInt64(player.LastGameDate)}, " +
                    $"{Convert.ToInt64(player.Score)})";
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
        public void Update(Player player)
        {
            using var conn = new SQLiteConnection();
            try
            {
                var sql = $"UPDATE player SET " +
                    $"Name = '{player.Name}', " +
                    $"IsPvpEnabled = {Convert.ToInt64(player.IsPvpEnabled)}" +
                    $"WHERE Id = {player.Id}";
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
        public void Delete(int id)
        {
            using var conn = new SQLiteConnection();
            try
            {
                var sql = $"DELETE FROM Player WHERE Id = {id}";
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
        public List<Player> GetAll()
        {
            using var conn = new SQLiteConnection();
            var result = new List<Player>();
            try
            {
                var sql = $"SELECT Name, IsPvpEnabled, LastGameDate, Score FROM Player";
                using var command = new SQLiteCommand(sql, conn);
                conn.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var pl = new Player
                    {
                        Name = (string)reader.GetValue(0),
                        IsPvpEnabled = (bool)reader.GetValue(1),
                        LastGameDate = Convert.ToDateTime(reader.GetValue(2)),
                        Score = (int)reader.GetValue(3)
                    };
                    result.Add(pl);
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

        public List<Player> GetByScore(int score)
        {
            using var conn = new SQLiteConnection();
            var result = new List<Player>();
            try
            {
                var sql = $"SELECT Name, IsPvpEnabled, LastGameDate " +
                    $"FROM Player WHERE Score = {score}";
                using var command = new SQLiteCommand(sql, conn);
                conn.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var pl = new Player
                    {
                        Name = Convert.ToString(reader.GetValue(0)),
                        IsPvpEnabled = Convert.ToBoolean(reader.GetValue(1)),
                        LastGameDate = Convert.ToDateTime(reader.GetValue(2)),
                    };
                    result.Add(pl);
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
