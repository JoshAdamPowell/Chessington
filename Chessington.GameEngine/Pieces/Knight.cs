using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Knight : Piece
    {
        public Knight(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var knightLocation = board.FindPiece(this);
            var possibleMovements = new List<Square>();
            for (int i = -2; i < 3; i = i + 4)
            {
                possibleMovements.Add(new Square(knightLocation.Row + i, knightLocation.Col + 1));
                possibleMovements.Add(new Square(knightLocation.Row + i, knightLocation.Col - 1));
            }
            for (int i = -1; i <2 ; i = i + 2)
            {
                possibleMovements.Add(new Square(knightLocation.Row + i, knightLocation.Col + 2));
                possibleMovements.Add(new Square(knightLocation.Row - i, knightLocation.Col - 2));
            }


            return possibleMovements;
        }
    }
}