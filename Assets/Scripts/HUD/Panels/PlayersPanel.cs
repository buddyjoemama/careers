using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersPanel : MonoBehaviour
{
    public PlayersManager PlayersManager;
    //public PlayerStatusControl CanonicalPlayerControl;

    private VerticalLayoutGroup _players;

    // Start is called before the first frame update
    void Start()
    {
        _players = GetComponentInChildren<VerticalLayoutGroup>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
