namespace Assignment2.Models;

public class Favorites
{
    public int MatchID { get; set; }
    public string MatchLength { get; set; }

    public Favorites(int matchID, string matchLength)
    {
        MatchID = matchID;
        MatchLength = matchLength;
    }

}