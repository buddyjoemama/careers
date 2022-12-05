using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayersPanel : MonoBehaviour
{
    public PlayersManager PlayersManager;
    public PlayerStatusControl CanonicalPlayerControl;
    public EventManager EventManager;

    private VerticalLayoutGroup _players;

    private void Awake()
    {
        PlayersManager.OnPlayerJoined += PlayersManager_OnPlayerJoined;
        PlayersManager.OnPlayerLoaded += PlayersManager_OnPlayerLoaded;
    }

    private void PlayersManager_OnPlayerLoaded(CareersGamePlayer player)
    {
        // Add the current user.
        var control = Instantiate(CanonicalPlayerControl, _players.transform);
        control.gameObject.SetActive(true);
        control.Player = player;
    }

    /// <summary>
    /// Called when a player joins the game.
    /// </summary>
    /// <param name="player">The player who joined the game.</param>
    private void PlayersManager_OnPlayerJoined(CareersGamePlayer player)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        _players = GetComponentInChildren<VerticalLayoutGroup>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
