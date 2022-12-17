using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[ExecuteInEditMode]
public class AllPlayersControl : PlayerStatusControl
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        //base.OnPointerClick(eventData);
        PlayersManager.SelectAllPlayers();
    }

    protected override void PlayersManager_OnPlayerSelected(CareersGamePlayer player)
    {
        IsSelected = player == null;
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
