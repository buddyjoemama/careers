using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PlayersManager : MonoBehaviour
{
    public delegate void PlayerJoined(CareersGamePlayer player);
    public event PlayerJoined OnPlayerJoined;

    public delegate void PlayerLoaded(CareersGamePlayer player);
    public event PlayerLoaded OnPlayerLoaded;

    public delegate void PlayerSelected(CareersGamePlayer player);
    public event PlayerSelected OnPlayerSelected;

    public EventManager EventManager;
    public URLManager UrlManager;

    private List<CareersGamePlayer> _players = new List<CareersGamePlayer>();
    private Color[] _playerColors = new[] { Color.red, Color.black,
        Color.magenta, Color.grey, Color.green,
        Color.cyan, Color.blue };

    private void Awake()
    {
    }

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
        OnPlayerLoaded(Me);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JoinPlayer(CareersGamePlayer player)
    {
        _players.Add(player);
        OnPlayerJoined(player);
    }

    public void SelectPlayer(CareersGamePlayer player)
    {
        OnPlayerSelected(player);
    }

    public CareersGamePlayer Me =>
        _players.SingleOrDefault(s => s.Id == PlayerPreferences.PlayerId);

    public int PlayerCount => _players.Count();


    public Color GetPlayerColor(CareersGamePlayer player)
    {
        return _playerColors[player.Number];
    }
}
