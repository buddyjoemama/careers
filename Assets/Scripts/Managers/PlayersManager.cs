using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayersManager : MonoBehaviour
{
    public delegate void PlayerJoined(CareersGamePlayer player);
    public event PlayerJoined OnPlayerJoined;
    
    public EventManager EventManager;
    public URLManager UrlManager;

    private List<CareersGamePlayer> _players = new List<CareersGamePlayer>();

    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnCreateGame += EventManager_OnCreateGame;

        StartCoroutine(CheckForPlayers());
    }

    private IEnumerator CheckForPlayers()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
        }
    }

    private void EventManager_OnCreateGame(CareersGameInfo gameInfo)
    {
        _players.AddRange(gameInfo.CareersGameState.Players);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public CareersGamePlayer Me =>
        _players.Single(s => s.Id == PlayerPreferences.PlayerId);
}
