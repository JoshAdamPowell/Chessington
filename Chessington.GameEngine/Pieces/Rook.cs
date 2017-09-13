using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Rook : Piece
    {
        public Rook(Player player)
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {
            var rookLocation = board.FindPiece(this);
            var possibleLocations = new List<Square>();

            for (var i = rookLocation.Row - 1; i >= 0; i--)
            {
                var potentialLocation = new Square(i, rookLocation.Col);
                possibleLocations.Add(potentialLocation);
                if (board.IsOccupied(potentialLocation))
                {
                    break;
                }
            }
            for (var i = rookLocation.Row + 1; i < 8; i++)
            {
                var potentialLocation = new Square(i, rookLocation.Col);
                possibleLocations.Add(potentialLocation);
                if (board.IsOccupied(potentialLocation))
                {
                    break;
                }
            }
            for (var i = rookLocation.Col - 1; i >= 0 ; i--)
            {
                var potentialLocation = new Square(rookLocation.Row, i);
                possibleLocations.Add(potentialLocation);
                if (board.IsOccupied(potentialLocation))
                {
                    break;
                }
            }
            for (var i = rookLocation.Col + 1; i < 8; i++)
            {
                var potentialLocation = new Square(rookLocation.Row, i);
                possibleLocations.Add(potentialLocation);
                if (board.IsOccupied(potentialLocation))
                {
                    break;
                }
            }

            



            /*
            for (var i = 0; i <= 8; i++)
            {
                possibleLocations.Add(new Square(rookLocation.Row, i));
                possibleLocations.Add(new Square(i, rookLocation.Col));
            }
            */
            return possibleLocations;
        }
    }
}