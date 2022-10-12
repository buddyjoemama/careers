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
    }

    private void EventManager_OnResume()
    {
        
    }

    private void EventManager_OnPause()
    {
        
    }

    private void EventManager_OnAsyncOperationEnd()
    {
        _processingDialog.gameObject.SetActive(false);
    }

    private void EventManager_OnAsyncOperationBegin()
    {
        _processingDialog.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
