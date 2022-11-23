using TMPro;
using UnityEngine;

public class FormulaDialog : MonoBehaviour
{
    public GameManager GameManager;
    public TMP_InputField Hearts;
    public TMP_InputField Stars;
    public TMP_InputField Money;
    public TMP_Text PointsLabel;
    public TMP_Text TotalLabel;

    // Start is called before the first frame update
    void Start()
    {
        PointsLabel.text = $"Must add up to: {GameManager.CurrentGame.CareersGameState.TotalPoints}";
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

    public void FormulaUpdate_OnChange()
    {
        UpdateTotal();
    }

    private void UpdateTotal()
    {
        int total = 0;

        if(int.TryParse(Hearts.text, out int hearts))
        {
            total += hearts;
        }

        if(int.TryParse(Stars.text, out int starts))
        {
            total += starts;
        }

        if(int.TryParse(Money.text, out int money))
        {
            total += money;
        }

        TotalLabel.text = $"Total: {total}";
    }
}
