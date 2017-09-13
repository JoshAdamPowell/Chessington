using System;
using System.Collections.Generic;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var pawnLocation = board.FindPiece(this);
            Console.WriteLine();
            var possibleLocations = new List<Square>();


            var movingForward = Player.Equals(Player.White) ? -1 : 1;

            possibleLocations.Add(new Square(pawnLocation.Row + (1 * movingForward), pawnLocation.Col));

            if (!HasMoved)
            {
                possibleLocations.Add(new Square(pawnLocation.Row + (2 * movingForward), pawnLocation.Col));
            }

            return possibleLocations;

        }
    }
}