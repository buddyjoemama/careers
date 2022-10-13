using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHUDManager : MonoBehaviour
{
    public EventManager EventManager;

    private ProcessingDialog _processingDialog;
    private TitleDialog _titleDialog;

    // Start is called before the first frame update
    void Start()
    {
        _processingDialog = GetComponentInChildren<ProcessingDialog>(true);
        _titleDialog = GetComponentInChildren<TitleDialog>(true);

        EventManager.OnAsyncOperationBegin += EventManager_OnAsyncOperationBegin;
        EventManager.OnAsyncOperationEnd += EventManager_OnAsyncOperationEnd;
        EventManager.OnPause += EventManager_OnPause;
        EventManager.OnResume += EventManager_OnResume;
        EventManager.OnOpenGame += EventManager_OnOpenGame;
    }

    private void EventManager_OnOpenGame(GameInfo gameInfo)
    {
        this.gameObject.SetActive(false);
    }

    private void EventManager_OnResume()
    {
        
    }

    private void EventManager_OnPause()
    {
        
    }

    private void EventManager_OnAsyncOperationEnd(string message)
    {
        _processingDialog.gameObject.SetActive(false);
        _processingDialog.Text = message;
    }

    private void EventManager_OnAsyncOperationBegin(string message)
    {
        _processingDialog.gameObject.SetActive(true);
        _processingDialog.Text = message;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
