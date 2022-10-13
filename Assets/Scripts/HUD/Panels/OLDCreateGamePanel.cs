using Newtonsoft.Json;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class OLDCreateGamePanel : MonoBehaviour
{
    private ContentSizeFitter _scrollGames;
    public URLManager URLManager;
    public GameInfoComponent GameInfoPrefab;
    //public GamePointsPanel GamePointsPanel;

    // Start is called before the first frame update
    void Start()
    {
        _scrollGames = GetComponentInChildren<ContentSizeFitter>();
      //  GamePointsPanel.OnOKClick += GamePointsPanel_OnOKClick;
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
       // GamePointsPanel.gameObject.SetActive(true);
    }

    public IEnumerator CreateGameAsync(string points)
    {
        using (UnityWebRequest request = UnityWebRequest.Post(URLManager.CreateGame("test123", points), ""))
        {
            yield return request.SendWebRequest();

            if(request.result == UnityWebRequest.Result.Success)
            {
                var response = JsonConvert.DeserializeObject<GameInfo>(request.downloadHandler.text);
                
                var info = Instantiate(GameInfoPrefab, _scrollGames.transform);
                info.Points = response.Points;
                info.JoinCode = response.JoinCode;
            }
            else
            {
                
            }
        }
    }
}
