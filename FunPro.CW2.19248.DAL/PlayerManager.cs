using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                    $"Player (Name, IsPvpEnabled, LastGameDate, SCore) " +
                    $"VALUES ({player.Name}, {player.IsPvpEnabled}, {player.LastGameDate}, {player.Score})";
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
        };
        public void Update(Player player);
        public void Delete(int id);
        public List<Player> GetAll();

        // TODO: Deleting player records, sort by name, filter by score
        // TODO: Import System.Data and System.Data.SQLite
        // TODO: Check input type!!!
    }
}
