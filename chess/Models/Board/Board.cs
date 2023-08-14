using chess.Models.Piece;
using File = chess.Models.Piece.File;

namespace chess.Models.Board
{
    public class Board
    {

        public Dictionary<Coordinates,Piece.Piece> Pieces = new Dictionary<Coordinates,Piece.Piece>();

        public Board()
        {
        }

        public void SetPiece(Coordinates coordinates, Piece.Piece piece)
        {
            Pieces.Add(coordinates, piece); 
        }

        public void SetDefaultPiecesPosition()
        {
            foreach (var files in Enum.GetValues(typeof(File)))
            {
                SetPiece(new Coordinates(2,((File)files)), new Pawn(Color.WHITE, new Coordinates(2, ((File)files))));
                SetPiece(new Coordinates(7,((File)files)), new Pawn(Color.BLACK, new Coordinates(7, ((File)files))));
            }
        }

    }
}
