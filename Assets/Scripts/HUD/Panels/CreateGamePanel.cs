using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class CreateGamePanel : MonoBehaviour
{
    private ContentSizeFitter _scrollGames;
    public URLManager URLManager;
    public GameInfoComponent GameInfoPrefab;
    public GamePointsPanel GamePointsPanel;

    // Start is called before the first frame update
    void Start()
    {
        _scrollGames = GetComponentInChildren<ContentSizeFitter>();
        GamePointsPanel.OnOKClick += GamePointsPanel_OnOKClick;
    }

    private void GamePointsPanel_OnOKClick(string points)
    {
        StartCoroutine(CreateGameAsync(points));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateGame()
    {
        GamePointsPanel.gameObject.SetActive(true);
    }

    public IEnumerator CreateGameAsync(string points)
    {
        using (UnityWebRequest request = UnityWebRequest.Post(URLManager.CreateGame("test123", points), ""))
        {
            yield return request.SendWebRequest();

            if(request.result == UnityWebRequest.Result.Success)
            {
                var response = JsonConvert.DeserializeObject<CreateGameResponse>(request.downloadHandler.text);
                
                var info = Instantiate(GameInfoPrefab, _scrollGames.transform);
                info.Points = response.Points;
            }
            else
            {
                
            }
        }
    }
}

public class CreateGameResponse
{
    [JsonProperty("_id")]
    public string Id { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int Points { get; set; }

    public string Edition { get; set; }

    public string[] Players { get; set; }
}
