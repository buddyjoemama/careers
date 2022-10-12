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
        //_processingImage = GetComponentInChildren<Image>();
        //CareersAsyncEvent.AddListener(s =>
        //{
        //    this.gameObject.SetActive(s);
        //});  
    }

    float angle = 0;
    void Update()
    {
        ProcessingImage.transform.Rotate(0, 0, angle);
        angle -= (Time.deltaTime * 200) % 360;
    }
}
