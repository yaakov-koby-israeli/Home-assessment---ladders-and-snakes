using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ladders_and_snakes_game.Core;
using Ladders_and_snakes_game.GameLogic;
using Ladders_and_snakes_game.Players;

namespace Ladders_and_snakes_game.Game_Logic
{
    internal class GameManager
    {
        private readonly int maxSnakesNumber = 12;
        private readonly int maxLaddersNumber = 12;

        // TODO HOW CAN BE MORE GENERIC ?
        private readonly int playesAmount = 2;

        private readonly Board _gameBoard;

        private readonly List<IPlayer> _playersList = new List<IPlayer>();

        private Dice DiceOne { get; } = new Dice();

        private Dice DiceTow { get; } = new Dice();

        public GameManager(Board board)
        {
            _gameBoard = board;
        }

        public void AddPlayer(IPlayer player) 
        {
            _playersList.Add(player);
        }

        public void ResetGame()
        {

        }

    }
}
