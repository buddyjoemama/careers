using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGamePanel : MonoBehaviour
{
    public EventManager EventManager;
    public GameManager GameManager;

    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnOpenGame += EventManager_OnOpenGame;
    }

    private void EventManager_OnOpenGame(GameInfo gameInfo)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
