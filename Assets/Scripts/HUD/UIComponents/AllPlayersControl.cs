using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[ExecuteInEditMode]
public class AllPlayersControl : PlayerStatusControl
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();   
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        //base.OnPointerClick(eventData);
        PlayersManager.SelectAllPlayers();
    }

    protected override void PlayersManager_OnPlayerSelected(CareersGamePlayer player)
    {
        IsSelected = player == null;
    }
}
