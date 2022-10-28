using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour
{
    public Transform MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldRotate)
        {
            MainCamera.Rotate(transform.forward.normalized * 30 * Time.deltaTime * -1);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        shouldRotate = true;
    }

    bool shouldRotate = false;
}
