using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class King : Piece
    {
        public King(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var kingLocation = board.FindPiece(this);
            var possibleMovements = new List<Square>();

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    possibleMovements.Add(new Square(kingLocation.Row + i, kingLocation.Col + j));
                }
            }
            possibleMovements.Remove(kingLocation);
        return possibleMovements;
        }
    }
}