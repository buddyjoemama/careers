using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Player : MonoBehaviour
{
    public EventManager EventManager;

    public void Awake()
    {
            
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
