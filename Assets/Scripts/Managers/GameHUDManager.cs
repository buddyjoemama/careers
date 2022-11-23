using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHUDManager : MonoBehaviour
{
    public EventManager EventManager;
    public MainGamePanel MainGamePanel;
    public ProcessingDialog ProcessingDialog;
    public TitleDialog TitleDialog;
    public FormulaDialog FormulaDialog;
    public PlayerProfilePanel ProfilePanel;
    public GameObject PausePanel;

    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnAsyncOperationBegin += EventManager_OnAsyncOperationBegin;
        EventManager.OnAsyncOperationEnd += EventManager_OnAsyncOperationEnd;
        EventManager.OnPause += EventManager_OnPause;
        EventManager.OnResume += EventManager_OnResume;
        EventManager.OnCreateGame += EventManager_OnOpenGame;
        EventManager.OnUserCreated += EventManager_OnUserCreated;

        if (PlayerPreferences.Initialized)
        {
            TitleDialog.gameObject.SetActive(true);
        }
        else
        {
            ProfilePanel.gameObject.SetActive(true);
        }
    }

    private void EventManager_OnUserCreated(CareersGamePlayer player)
    {
        ProfilePanel.gameObject.SetActive(false);
        TitleDialog.gameObject.SetActive(true);
    }

    private void EventManager_OnOpenGame(CareersGameInfo gameInfo)
    {
        MainGamePanel.gameObject.SetActive(true);
        TitleDialog.gameObject.SetActive(false);
    }

    private void EventManager_OnResume()
    {
        
    }

    private void EventManager_OnPause()
    {
        
    }

    private void EventManager_OnAsyncOperationEnd()
    {
        ProcessingDialog.gameObject.SetActive(false);
    }

    private void EventManager_OnAsyncOperationBegin(string message)
    {
        ProcessingDialog.gameObject.SetActive(true);
        ProcessingDialog.Text = message;
    }

    // Update is called once per frame
    void Update()
    {
        if(!PlayerPreferences.Initialized)
        {
            ProfilePanel.gameObject.SetActive(true);
        }
    }
}
