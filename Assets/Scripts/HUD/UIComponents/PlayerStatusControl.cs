using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteInEditMode]
public class PlayerStatusControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject NameControl;
    public Color PlayerColor;
    public Image PlayerIcon;

    public CareersGamePlayer Player { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }
     
    // Update is called once per frame
    void Update()
    {
        PlayerIcon.color = PlayerColor;
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
        //NameControl.GetComponent<RectTransform>().localPosition = new Vector3(-175, eventData.position.y);
        NameControl.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        NameControl.SetActive(false);
    }
}
