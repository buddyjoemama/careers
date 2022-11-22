using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void BeginGameAsyncOperation(string message);
    public delegate void EndGameAsyncOperation();

    public event BeginGameAsyncOperation OnAsyncOperationBegin;
    public event EndGameAsyncOperation OnAsyncOperationEnd;

    public delegate void CreateGameOperation(CareersGameInfo gameInfo);
    public event CreateGameOperation OnCreateGame;

    public delegate void GamePause();
    public event GamePause OnPause;
    public event GamePause OnResume;

    private bool _isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            _isPaused = !_isPaused;

            if(_isPaused)
                OnPause();
            else
                OnResume();
        }
    }

    public void BeginAsyncOperation(string message = null)
    {
        OnAsyncOperationBegin(message);
    }

    public void EndAsyncOperation()
    {
        OnAsyncOperationEnd();
    }

    public void CreateGame(CareersGameInfo gameInfo)
    {
        if(OnCreateGame != null)
           OnCreateGame(gameInfo);
    }
}
