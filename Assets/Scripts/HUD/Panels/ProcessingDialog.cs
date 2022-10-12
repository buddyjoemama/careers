using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ProcessingDialog : MonoBehaviour
{
    public Transform ProcessingImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        ProcessingImage.transform.Rotate(0, 0, -2);
    }
}
