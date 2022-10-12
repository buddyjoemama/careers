using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void GameAsyncOperation();
    public event GameAsyncOperation OnAsyncOperationBegin;
    public event GameAsyncOperation OnAsyncOperationEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerformAsyncOperation(Action action)
    {
        try
        {
            OnAsyncOperationBegin();
            action();
        }
        finally
        {
            OnAsyncOperationEnd();
        }
    }
}
