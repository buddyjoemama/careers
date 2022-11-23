using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//[ExecuteAlways]
public class GameManager : MonoBehaviour
{
    public Player Player;
    public EventManager EventManager;

    private List<Player> _players = new List<Player>();
    public CareersGameInfo CurrentGame { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnPause += EventManager_OnPause;
        EventManager.OnResume += EventManager_OnResume;
        EventManager.OnCreateGame += EventManager_OnCreateGame;
        //Time.timeScale = 0;
        //var square = GetComponentsInChildren<GameBoardSquare>()
        //    .Where(s => s.PositionIndex == 1)
        //    .First();

        //Player p = GetComponentInChildren<Player>();
        //p.CurrentGameBoardSquare = square;
        //p.gameObject.transform.position = square.transform.position;

        //_players.Add(p);
    }

    private void EventManager_OnCreateGame(CareersGameInfo gameInfo)
    {
        this.CurrentGame = gameInfo;
    }

    private void EventManager_OnResume()
    {
        Time.timeScale = 1;
    }

    private void EventManager_OnPause()
    {
        Time.timeScale = 0;
    }


    // Update is called once per frame
    void Update()
    {

       // transform.position = Vector2.SmoothDamp(transform.position, mousePosition,
         //   ref currentVelocity, smoothTime, maxMoveSpeed);
    }
}
