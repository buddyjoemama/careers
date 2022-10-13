using Newtonsoft.Json;
using System;

public class GameInfo
{
    [JsonProperty("_id")]
    public string Id { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int Points { get; set; }

    public string Edition { get; set; }

    public string[] Players { get; set; }

    public string JoinCode { get; set; }
}
