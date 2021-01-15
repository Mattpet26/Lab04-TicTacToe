using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
	public class Board
	{
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{
			for(int i = 0; i < 3; i++)
            {
				for(int j = 0; j < 3; j++)
                {
                    if (j < 2)
                    {
						Console.Write($"| {GameBoard[i, j]} |");
                    }
                    else
                    {
						Console.WriteLine($"| {GameBoard[i, j]} |");
					}

				}
            }

		}
	}
}
