using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.EventSystems;

[ExecuteInEditMode]
public class Player : MonoBehaviour, IPointerClickHandler
{
    public EventManager EventManager;
    public Color Color;
    public PlayersManager PlayersManager;
    public CareersGamePlayer CareersGamePlayer { set; get; }
    public bool IsSelected = false;
    public SpriteRenderer SelectedSprite;
    public SpriteRenderer PlayerSprite;

    public void SetPlayer(CareersGamePlayer player)
    {
        CareersGamePlayer = player;
    }

    public void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayersManager != null)
        {
            PlayersManager.OnPlayerSelected += PlayersManager_OnPlayerSelected;
        }
    }

    private void PlayersManager_OnPlayerSelected(CareersGamePlayer player)
    {
        IsSelected = player.Number == CareersGamePlayer.Number && !IsSelected;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerSprite.color = Color;
        SelectedSprite.gameObject.SetActive(IsSelected);
        //// Find the squares we are on...could potentially be on > 1
        //var foundSquares = Physics2D.BoxCastAll(this.transform.position,
        //    new Vector2(this.transform.localScale.x, this.transform.localScale.y),
        //    0,
        //    transform.forward);

        //foreach(var square in foundSquares)
        //{
        //    square.collider.gameObject.GetComponent<IGameSquare>().Activate();
        //}

        //    //.Single()
        //    //.collider
        //    //.gameObject
        //    //.GetComponent<IGamerSquare>();

        ////if(!CurrentGameBoardSquare.CompareTag(foundSquare.tag))
        ////{
        ////    CurrentGameBoardSquare = foundSquare;
        ////    Debug.Log("Updated to " + foundSquare.tag);
        ////}
    }

    public bool IsPlayer(CareersGamePlayer player)
    {
        return CareersGamePlayer.Id == player.Id;
    }

    public bool IsMe()
    {
        return CareersGamePlayer.Id == PlayersManager.Me.Id;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayersManager.SelectPlayer(CareersGamePlayer);
    }
}
