namespace Labb3G
{
    using Labb3G.MyGame;

    internal class Program
    {
        //Creates a new Game
        //Start it by calling startGame()
        internal static void Main(string[] args)
        {
            Games newGame = new Games();
            newGame.startGame();
        }
    }
}
