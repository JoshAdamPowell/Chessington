using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

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
            var newSquare = new Square();
            if (this.Player.Equals(Player.White))
            {
                newSquare.Row = pawnLocation.Row - 1;
                newSquare.Col = pawnLocation.Col;
            }
            if (this.Player.Equals(Player.Black))
            {
                newSquare.Row = pawnLocation.Row + 1;
                newSquare.Col = pawnLocation.Col;
            }
            possibleLocations.Add(newSquare);

            return possibleLocations;

        }
    }
}