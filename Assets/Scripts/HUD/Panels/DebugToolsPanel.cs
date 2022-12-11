using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugToolsPanel : MonoBehaviour
{
    public PlayersManager PlayersManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JoinPlayer()
    {
        CareersGamePlayer player = new CareersGamePlayer();
        player.Number = PlayersManager.PlayerCount;

        PlayersManager.JoinPlayer(player);
    }
}
