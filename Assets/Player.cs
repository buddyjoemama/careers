using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var t = Physics2D.BoxCastAll(this.transform.position, 
            new Vector2(this.transform.localScale.x, this.transform.localScale.y),
            0,
            transform.forward);

        if(t.Length > 0)
        {
            var s = t[0].collider.gameObject.GetComponentInChildren<GameBoardSquare>();

            if(s != null)
            {

            }
        }
    }
}
