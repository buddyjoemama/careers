using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PlayerStatusControl : MonoBehaviour, IPointerClickHandler
{
    public Color PlayerColor;
    public Image PlayerIcon;
    public Transform SelectedIcon;
    public bool IsSelected;
    public Color SelectedColor;
    public CareersGamePlayer Player { get; set; }
    public PlayersManager PlayersManager;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        PlayersManager.OnPlayerSelected += PlayersManager_OnPlayerSelected;
        PlayersManager.OnAllPlayersSelected += PlayersManager_OnAllPlayersSelected;
        IsSelected = false;
    }

    protected virtual void PlayersManager_OnAllPlayersSelected()
    {
        IsSelected = false;
    }

    protected virtual void PlayersManager_OnPlayerSelected(CareersGamePlayer player)
    {
        IsSelected = player != null && player.Number == Player.Number && !IsSelected;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        PlayerIcon.color = PlayerColor;

        if (IsSelected)
            SelectedIcon.GetComponent<Image>().color = SelectedColor;
        else
            SelectedIcon.GetComponent<Image>().color = Color.clear;
    }

    public virtual void OnPointerClick(PointerEventData eventData)
    {
        PlayersManager.SelectPlayer(Player);
    }
}
