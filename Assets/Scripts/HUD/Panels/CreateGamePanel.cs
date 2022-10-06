using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateGamePanel : MonoBehaviour
{
    private ContentSizeFitter _scrollGames;

    // Start is called before the first frame update
    void Start()
    {
        _scrollGames = GetComponentInChildren<ContentSizeFitter>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
