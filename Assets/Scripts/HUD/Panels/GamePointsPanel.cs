using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePointsPanel : MonoBehaviour
{
    public delegate void OkClickCallback(string points);
    public event OkClickCallback OnOKClick;

    public TMP_InputField InputPoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BtnOK_Click()
    {
        this.gameObject.SetActive(false);
        OnOKClick(InputPoints.text);
    }
}
