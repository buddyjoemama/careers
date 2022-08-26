using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameBoardSquare : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("something");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("something");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("something");
    }
}
