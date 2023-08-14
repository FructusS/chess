namespace chess.Models.Piece
{
    public class Coordinates
    {
        public virtual File File { get; set; }
        public virtual int Rank { get; set; }

        public Coordinates(int rank, File file)
        {
            Rank = rank;
            File = file;
        }
    }
}
