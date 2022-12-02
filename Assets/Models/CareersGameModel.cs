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
    [JsonProperty("gameId")]
    public String GameId { get; set; }

    [JsonProperty("number_of_players")]
    public int NumberOfPlayers { get; set; }

    [JsonProperty("current_player_number")]
    public int CurrentPlayer { get; set; }

    [JsonProperty("players")]
    public List<CareersGamePlayer> Players { get; set; }

    [JsonProperty("total_points")]
    public int TotalPoints { get; set; }
}

public class CareersGamePlayer
{
    [JsonProperty("name")]
    public String Name { get; set; }

    [JsonProperty("number")]
    public int Number { get; set; }

    [JsonProperty("initials")]
    public String Initials { get; set; }

    [JsonProperty("email")]
    public String Email { get; set; }

    [JsonProperty("_id")]
    public String Id { get; set; }

    [JsonProperty("game_complete")]
    public bool GameComplete { get; set; }

    [JsonProperty("successFormula")]
    public CareersGamePlayerFormula SuccessFormula { get; set; }
}

public class CareersGamePlayerFormula
{
    public CareersGamePlayerFormula(int hearts, int stars, int money)
    {
        Money = money;
        Hearts = hearts;
        Stars = stars;
    }

    [JsonProperty("money")]
    public int Money { get; set; }

    [JsonProperty("stars")]
    public int Stars { get; set; }

    [JsonProperty("hearts")]
    public int Hearts { get; set; }
}
