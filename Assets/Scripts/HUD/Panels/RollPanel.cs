using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollPanel : MonoBehaviour
{
    public EventManager EventManager;
    public FormulaDialog FormulaDialog;
    public GameManager GameManager;

    // Start is called before the first frame update
    void Start()
    {
        FormulaDialog.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Roll_OnClick()
    {

    }

    public void StartGame_OnClick()
    {

    }

    public void SetFormula_OnClick()
    {
        FormulaDialog.gameObject.SetActive(true);
    }
}
