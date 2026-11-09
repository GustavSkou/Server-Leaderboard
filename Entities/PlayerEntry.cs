namespace Entities;

class PlayerEntry : IComparable<PlayerEntry>
{
    public PlayerEntry(string name, int score)
    {
        Name = name;
        Score = score; 
    }

    public string Name { get; }
    public int Score { get; }

    public int CompareTo(PlayerEntry other)
    {
        if (other == null) return 1;

        if (this.Score > other.Score)
            return 1;

        if (this.Score < other.Score)
            return -1;

        if (this.Name.CompareTo(other.Name) >= 0)
            return 1;

        return -1;
    }
}