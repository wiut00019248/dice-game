using FunPro.CW2._19248.DAL;

namespace FunPro.CW2._19248
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var player1 = new Player(
                    "shohruh",
                    true,
                    new DateTime(1995, 1, 1),
                    2
                );
            var player2 = new Player(
                    "abdumalik",
                    true,
                    new DateTime(2004, 1, 1),
                    1
                );
            var clash = new Clash(
                    player1.Id,
                    player2.Id,
                    new DateTime(2023, 1, 1),
                    0
                );
            MessageBox.Show(
                    $"{player1.Name} vs {player2.Name}: {clash.Outcome}"
                );
        }
    }
}