using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Player : MonoBehaviour
{
    public GameBoardSquare CurrentGameBoardSquare;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Find the squares we are on...could potentially be on > 1
        var foundSquare = Physics2D.BoxCastAll(this.transform.position,
            new Vector2(this.transform.localScale.x, this.transform.localScale.y),
            0,
            transform.forward)
            .First()
            .collider
            .gameObject
            .GetComponent<GameBoardSquare>();

        if(!CurrentGameBoardSquare.CompareTag(foundSquare.tag))
        {
            CurrentGameBoardSquare = foundSquare;
            Debug.Log("Updated to " + foundSquare.tag);
        }
    }
}
