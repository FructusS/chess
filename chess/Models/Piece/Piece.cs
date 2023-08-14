namespace chess.Models.Piece
{
    public abstract class Piece
    {
        public  Color Color { get; set; }
        public Coordinates Coordinates { get; set; }

    }
}
