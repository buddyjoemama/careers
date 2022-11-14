using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollManager : MonoBehaviour
{
    public EventManager EventManager;

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

    public void Roll_OnClick()
    {

    }

    public void StartGame_OnClick()
    {

    }

    public void SetFormula_OnClick()
    {

    }
}
