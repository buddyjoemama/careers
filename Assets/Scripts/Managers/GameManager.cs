using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//[ExecuteAlways]
public class GameManager : MonoBehaviour
{
    public EventManager EventManager;
    public CareersGameInfo CurrentGame { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnPause += EventManager_OnPause;
        EventManager.OnResume += EventManager_OnResume;
        EventManager.OnCreateGame += EventManager_OnCreateGame;
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
    }
}
