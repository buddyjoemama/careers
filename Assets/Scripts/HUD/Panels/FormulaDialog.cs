using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FormulaDialog : MonoBehaviour
{
    public GameManager GameManager;
    public EventManager EventManager;
    public TMP_InputField Hearts;
    public TMP_InputField Stars;
    public TMP_InputField Money;
    public TMP_Text PointsLabel;
    public TMP_Text TotalLabel;
    public Button OkButton;

    private int _total = 0;

    // Start is called before the first frame update
    void Start()
    {
        //PointsLabel.text = $"Must add up to: {GameManager.CurrentGame.CareersGameState.TotalPoints}";
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveFormula_OnClick()
    {
       // GameManager.Player.SetFormula(Hearts.text, Stars.text, Money.text);
        this.gameObject.SetActive(false);
        EventManager.AddUpdateFormula(
            new CareersGamePlayerFormula(int.Parse(Hearts.text),
                int.Parse(Stars.text),
                int.Parse(Money.text)));
    }

    public void FormulaUpdate_OnChange()
    {
        UpdateTotal();

        OkButton.interactable =
            GameManager.CurrentGame.CareersGameState.TotalPoints == _total;
    }

    private void UpdateTotal()
    {
        _total = 0;

        if(int.TryParse(Hearts.text, out int hearts))
        {
            _total += hearts;
        }

        if(int.TryParse(Stars.text, out int starts))
        {
            _total += starts;
        }

        if(int.TryParse(Money.text, out int money))
        {
            _total += money;
        }

        TotalLabel.text = $"Total: {_total}";
    }
}
