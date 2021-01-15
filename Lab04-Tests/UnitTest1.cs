using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace Lab04_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestWinner()
        {

            Player player1 = new Player();
            player1.Name = "jack";
            player1.Marker = "X";

            Player player2 = new Player();
            player2.Name = "Jill";

            Game newgame = new Game(player1, player2);

            newgame.Board.GameBoard = new string[,]
            {
                {"X", "2", "1"},
                {"X", "5", "6"},
                {"X", "8", "9"},
            };
            
        Assert.True(newgame.CheckForWinner());
        }

        [Fact]
        public void CheckSwitch()
        {
            Player player1 = new Player();
            player1.Name = "jack";
            player1.Marker = "X";
            player1.IsTurn = true;

            Player player2 = new Player();
            player2.Name = "Jill";
            player2.IsTurn = false;

            Game newgame = new Game(player1, player2);
            newgame.SwitchPlayer();

            Assert.True(player2.IsTurn);
        }
        [Fact]
        public void TestCorrectIndex()
        {
            Player player1 = new Player();
            player1.Name = "jack";
            player1.Marker = "X";

            Player player2 = new Player();
            player2.Name = "Jill";

            Game newgame = new Game(player1, player2);
            Position position = new Position(0, 0);



            newgame.Board.GameBoard = new string[,]
            {
                {"X", "2", "1"},
                {"4", "5", "6"},
                {"7", "8", "9"},
            };
            Assert.True(Player.PositionForNumber(1).Row == position.Row && Player.PositionForNumber(1).Column == position.Column);
        }
        [Fact]
        public void PlayerNameIsValid()
        {
            Player player1 = new Player();
            player1.Name = "jack";
            string expected = "jack";

            Assert.Equal(player1.Name, expected);
        }
    }
}
