namespace Rpsu.Models;

public class Player {
    public long Id {get; set;}
    public long MatchCount {get; set;}
    public int Win {get; set;}
    public int Lose {get; set;}
    public double winrate {get; set;}
}