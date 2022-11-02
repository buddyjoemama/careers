using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

[ExecuteAlways]
public class PlayerInfo : MonoBehaviour
{
    public string PlayerName;
    public int Stars;
    public int Hearts;
    public int Money;
    public Color Color;

    private TMP_Text _playerName;
    private TMP_Text _stars;
    private TMP_Text _money;
    private TMP_Text _hearts;

    // Start is called before the first frame update
    void Start()
    {
        _playerName = GetComponentsInChildren<TMP_Text>()
            .Where(s => s.gameObject.name == "NameText")
            .SingleOrDefault();

        _stars = GetComponentsInChildren<TMP_Text>()
            .Where(s => s.gameObject.name == "StarsText")
            .SingleOrDefault();

        _hearts = GetComponentsInChildren<TMP_Text>()
            .Where(s => s.gameObject.name == "HeartsText")
            .SingleOrDefault();

        _money = GetComponentsInChildren<TMP_Text>()
            .Where(s => s.gameObject.name == "MoneyText")
            .SingleOrDefault();
    }

    // Update is called once per frame
    void Update()
    {
        _playerName.text = PlayerName;
        _stars.text = Stars.ToString();
        _money.text = Money.ToString();
        _hearts.text = Hearts.ToString();
    }
}
