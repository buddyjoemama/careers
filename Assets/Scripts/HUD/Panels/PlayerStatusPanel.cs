using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatusPanel : MonoBehaviour
{
    public EventManager EventManager;
    public TMP_Text Hearts;
    public TMP_Text Stars;
    public TMP_Text Money;
    public TMP_Text FormulaHearts;
    public TMP_Text FormulaStars;
    public TMP_Text FormulaMoney;

    private void Awake()
    {
        EventManager.OnCreateGame += EventManager_OnCreateGame;
        EventManager.OnUpdateFormula += EventManager_OnUpdateFormula;
    }

    private void EventManager_OnUpdateFormula(CareersGamePlayerFormula formula)
    {
        FormulaHearts.text = $"/{formula.Hearts}";
        FormulaMoney.text = string.Format("/{0:n0}", (formula.Money * 1000));
        FormulaStars.text = $"/{formula.Stars}";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void EventManager_OnCreateGame(CareersGameInfo gameInfo)
    {
        Hearts.text = Stars.text = "0";
        Money.text = gameInfo.CareersGameParameters.StartingCash.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
