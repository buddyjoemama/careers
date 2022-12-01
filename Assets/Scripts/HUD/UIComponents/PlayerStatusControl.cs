using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerStatusControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject NameControl;

    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        NameControl.SetActive(true);
    }

    public void OnMouseExit()
    {
        NameControl.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        NameControl.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        NameControl.SetActive(false);
    }
}
