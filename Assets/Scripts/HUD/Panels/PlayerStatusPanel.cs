using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatusPanel : MonoBehaviour
{
    public EventManager EventManager;
    public TMP_Text Hearts;
    public TMP_Text Stars;
    public TMP_Text Money;

    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnCreateGame += EventManager_OnCreateGame;
    }

    private void EventManager_OnCreateGame(CareersGameInfo gameInfo)
    {
        Hearts.text = Stars.text = "0";
        Money.text = gameInfo.CareersGameParameters.StartingCash.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
