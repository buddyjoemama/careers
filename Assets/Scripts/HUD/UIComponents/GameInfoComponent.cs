using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameInfoComponent : MonoBehaviour
{
    public TMP_Text DateText;
    public TMP_Text PointsText;
    public TMP_Text PlayersText;
    public TMP_Text JoinCodeText;

    public int Points
    {
        set
        {
            this.PointsText.text = $"Points: {value.ToString()}";
        }
    }

    public string JoinCode
    {
        set
        {
            this.JoinCodeText.text = $"Join Code: {value}";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
