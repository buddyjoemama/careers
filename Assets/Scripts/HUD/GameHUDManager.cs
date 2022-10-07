using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHUDManager : MonoBehaviour
{
    private CreateGamePanel _createGamePanel;
    // Start is called before the first frame update
    void Start()
    {
        _createGamePanel = GetComponentInChildren<CreateGamePanel>();
        _createGamePanel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
