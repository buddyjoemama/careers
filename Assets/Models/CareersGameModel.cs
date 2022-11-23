using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class CareersGameInfo
{
    [JsonProperty("_id")]
    public string Id { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Edition { get; set; }

    public string JoinCode { get; set; }

    [JsonProperty("gameParameters")]
    public CareersGameParameters CareersGameParameters { get; set; }

    [JsonProperty("gameState")]
    public CareersGameState CareersGameState { get; set; }
}

public class CareersGameParameters
{
    [JsonProperty("starting_salary")]
    public int StartingSalary { get; set; }

    [JsonProperty("starting_cash")]
    public int StartingCash { get; set; }
}

public class CareersGameState
{
    public String GameId { get; set; }

    [JsonProperty("players")]
    public List<CareersGamePlayer> Players { get; set; }

    [JsonProperty("total_points")]
    public int TotalPoints { get; set; }
}

public class CareersGamePlayer
{
    public String Name { get; set; }

    public int Number { get; set; }

    public String Initials { get; set; }
}

public class CareersGamePlayerFormula
{
    public int Money { get; set; }

    public int Stars { get; set; }

    public int Hearts { get; set; }
}
