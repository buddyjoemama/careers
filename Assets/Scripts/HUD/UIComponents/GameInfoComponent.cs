using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameInfoComponent : MonoBehaviour
{
    public TMP_Text DateText;
    public TMP_Text PointsText;
    public TMP_Text PlayersText;

    public int Points
    {
        set
        {
            this.PointsText.text = $"Points: {value.ToString()}";
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
