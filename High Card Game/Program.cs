using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //get number of players
            Console.WriteLine("How many players?");
            int numPlayers;
            bool result = Int32.TryParse(Console.ReadLine(), out numPlayers);

            //set up game
            List<Card> deck = new List<Card>();
            deck = Dealer.MakeDeck();
            List<Player> allPlayers = Dealer.MakePlayers(numPlayers);
            string command = "d";
            int dealNum = 0;

            //begin game
            do
            {
                playGame(deck, allPlayers, dealNum);

                Console.WriteLine("To deal again, enter \"d\".");
                command = Console.ReadLine().ToLower();
                dealNum++;
            } 
            while (command == "d");

            //determine overall winner
            determineWinner(allPlayers);
            Console.ReadLine();
        }

        /// <summary>
        /// deals cards and determines winner of hand
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="allPlayers"></param>
        /// <param name="dealNum"></param>
        private static void playGame(List<Card> deck, List<Player> allPlayers, int dealNum)
        {
            
            //deal hands
            foreach (var Player in allPlayers)
            {
                Card cardToDeal = Dealer.Deal(deck);
                Player.Hand.Add(cardToDeal);
                Console.WriteLine(Player.Name + " : " + Player.Hand[dealNum].CardName);
                Console.ReadLine();
            }

            //Score the hands
            Player handWinner = allPlayers[0];
            foreach (var Player in allPlayers)
            {
                Player.Points = Player.Hand[dealNum].Rank;
                if (Player.Hand[dealNum].Rank > handWinner.Hand[dealNum].Rank)
                {
                    Player.Points++;
                    handWinner = Player;
                }
            }
            Console.WriteLine("The winner is... " + handWinner.Name);
        }

        /// <summary>
        /// determine overall winner of all hands
        /// </summary>
        /// <param name="allPlayers"></param>
        private static void determineWinner(List<Player> allPlayers)
        {
            
            Player gameWinner = allPlayers[0];
            foreach (var Player in allPlayers)
            {
                if (Player.Points > gameWinner.Points)
                {
                    gameWinner = Player;
                }
            }

            Console.WriteLine("Congrats, " + gameWinner.Name + ". You win!");
            Console.WriteLine();
        }
    }
}
