namespace BF1ClientAPI.Models;

public class ServerData
{
    public string Name { get; set; }
    public long GameId { get; set; }
    public float Time { get; set; }
    public string GameTime { get; set; }

    public string GameMode { get; set; }
    public string GameMode2 { get; set; }
    public string MapName { get; set; }
    public string MapName2 { get; set; }
    public string MapImage { get; set; }

    public Team Team1 { get; set; }
    public Team Team2 { get; set; }

    public ServerData()
    {
        Team1 = new();
        Team2 = new();
    }
}

public class Team
{
    public string Name { get; set; }
    public string Image { get; set; }

    public int MaxScore { get; set; }

    public int AllScore { get; set; }
    public int ScoreKill { get; set; }
    public int ScoreFlag { get; set; }
}