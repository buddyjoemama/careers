using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ProcessingDialog : MonoBehaviour
{
    public Transform ProcessingImage;
    private TMP_Text _processingText;
    private string _text = "Processing...";

    // Start is called before the first frame update
    void Start()
    {
        _processingText = GetComponentInChildren<TMP_Text>();
    }

    void Update()
    {
        ProcessingImage.transform.Rotate(0, 0, -2);
        _processingText.text = _text;
    }

    public string Text
    {
        set
        {
            _text = value;
        }
    }
}
