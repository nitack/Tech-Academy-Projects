using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Ryan", "Alex", "Chris" };
            //game.ListPlayers();
            //Console.ReadLine();
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";
            game += player;
            game -= player;

            Deck deck = new Deck();
            deck.Shuffle();

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
