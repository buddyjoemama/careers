using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hotspot : MonoBehaviour
{
    // Start is called before the first frame update
    public Player Player { get; private set; }
    public bool IsOccupied { get; private set; }
    public int PositionIndex { get; set; }
    public Occupation Occupation => this.GetComponentInParent<Occupation>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Player = collision.gameObject.GetComponent<Player>();
        IsOccupied = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Player>() != null)
        {
            Player = null;
            IsOccupied = false;
        }
    }

    internal void SetOccupied(bool value)
    {
        IsOccupied = value;
    }

    public bool PlayerOnOccupation()
    {
        return this.GetComponentInParent<Occupation>() != null;
    }
}
