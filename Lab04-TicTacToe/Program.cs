using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe
{
    class Program
    {
        static Classes.Player[] playerArray = new Classes.Player[2];
        static void Main(string[] args)
        {
            CreatePlayers();
            StartGame();
        }
        static void StartGame()
        {
            Classes.Game newGame = new Classes.Game(playerArray[0], playerArray[1]);
            newGame.Play();

            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 

        }
        static void CreatePlayers()
        {
            //========================================================== Creates players
            Classes.Player playerOne = new Classes.Player();
            Classes.Player playerTwo = new Classes.Player();


            Console.WriteLine("Enter a player name");
            string input = Console.ReadLine();
            playerOne.Name = input;
            playerOne.IsTurn = true;
            playerOne.Marker = "X";

            Console.WriteLine("Enter another player name");
            string input2 = Console.ReadLine();
            playerTwo.Name = input2;
            playerTwo.IsTurn = false;
            playerTwo.Marker = "0";

            Classes.Game currentGame= new Classes.Game(playerOne, playerTwo);

            playerArray[0] = playerOne;
            playerArray[1] = playerTwo;

            Console.WriteLine($"Your players are: {playerOne.Name}, {playerTwo.Name}");

        }
    }
}
