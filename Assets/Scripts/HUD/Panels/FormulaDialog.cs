using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FormulaDialog : MonoBehaviour
{
    public GameManager GameManager;
    public TMP_InputField Hearts;
    public TMP_InputField Stars;
    public TMP_InputField Money;
    public TMP_Text PointsLabel;

    // Start is called before the first frame update
    void Start()
    {
        PointsLabel.text = $"Must add up to: {GameManager.CurrentGame.Points}";
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveFormula_OnClick()
    {
        GameManager.Player.SetFormula(Hearts.text, Stars.text, Money.text);
        this.gameObject.SetActive(false);
    }
}
