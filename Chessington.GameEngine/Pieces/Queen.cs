using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Queen : Piece
    {
        public Queen(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var queenLocation = board.FindPiece(this);
            var lateralMovements = new List<Square>();
            for (var i = 0; i <= 8; i++)
            {
                lateralMovements.Add(new Square(queenLocation.Row, i));
                lateralMovements.Add(new Square(i, queenLocation.Col));
            }
            var validLateralMovements = lateralMovements.Where(x => x.Row < 8 && x.Row >= 0).Where(x => x.Col < 8 && x.Row >= 0)
                .Select(x => x).ToList();
            var diagonalMovements = new List<Square>();
            for (var i = 1; i <= 8; i++)
            {
                diagonalMovements.Add(new Square(queenLocation.Row + i, queenLocation.Col + i));
                diagonalMovements.Add(new Square(queenLocation.Row + i, queenLocation.Col - i));
                diagonalMovements.Add(new Square(queenLocation.Row - i, queenLocation.Col + i));
                diagonalMovements.Add(new Square(queenLocation.Row - i, queenLocation.Col - i));

            }
            var validDiagnonalMovements = diagonalMovements.Where(x => x.Row < 8 && x.Row >= 0).Where(x => x.Col < 8 && x.Row >= 0)
                .Select(x => x).ToList();

            var possibleMovements = validLateralMovements.Union(validDiagnonalMovements).ToList();
            possibleMovements.Remove(queenLocation);

            return possibleMovements;
        }
    }
}