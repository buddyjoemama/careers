using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoard : MonoBehaviour
{
    public Transform MainCamera;
    public float Step = .75f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(Rotate());
    }

    private IEnumerator Rotate()
    {
        float step = 0;

        do
        {
            MainCamera.transform.Rotate(0, 0, -Step);
            yield return new WaitForEndOfFrame();

            step += Step;
        }
        while (step < 90);
    }
}
