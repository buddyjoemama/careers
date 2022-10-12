using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void GameAsyncOperation();
    public event GameAsyncOperation OnAsyncOperationBegin;
    public event GameAsyncOperation OnAsyncOperationEnd;

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

    public void BeginAsyncOperation()
    {
        OnAsyncOperationBegin();
    }

    public void EndAsyncOperation()
    {
        OnAsyncOperationEnd();
    }
}
