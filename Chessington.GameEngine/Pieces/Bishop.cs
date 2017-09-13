using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Chessington.GameEngine.Pieces
{
    public class Bishop : Piece
    {
        public Bishop(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var bishopLocation = board.FindPiece(this);
            var possibleLocations = new List<Square>();

            for (var i = 1; i <= 8; i++)
            {
                possibleLocations.Add(new Square(bishopLocation.Row + i, bishopLocation.Col + i));
                possibleLocations.Add(new Square(bishopLocation.Row + i, bishopLocation.Col - i));
                possibleLocations.Add(new Square(bishopLocation.Row - i, bishopLocation.Col + i));
                possibleLocations.Add(new Square(bishopLocation.Row - i, bishopLocation.Col - i));

            }
            var newResult = possibleLocations.Where(x => x.Row < 8 && x.Row >= 0).Where(x => x.Col < 8 && x.Row >= 0)
                .Select(x => x).ToList();


            return newResult;
        }
    }
}