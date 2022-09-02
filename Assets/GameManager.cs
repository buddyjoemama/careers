using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//[ExecuteAlways]
public class GameManager : MonoBehaviour
{
    public Player Player;
    private List<Player> _players = new List<Player>();

    // Start is called before the first frame update
    void Start()
    {
        //var square = GetComponentsInChildren<GameBoardSquare>()
        //    .Where(s => s.PositionIndex == 1)
        //    .First();

        //Player p = GetComponentInChildren<Player>();
        //p.CurrentGameBoardSquare = square;
        //p.gameObject.transform.position = square.transform.position;

        //_players.Add(p);
    }

    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    Vector2 currentVelocity;

    // Update is called once per frame
    void Update()
    {
        int index = 0;

       // transform.position = Vector2.SmoothDamp(transform.position, mousePosition,
         //   ref currentVelocity, smoothTime, maxMoveSpeed);
    }
}
