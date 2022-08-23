using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.EventSystems;

public class ViewManager : MonoBehaviour, IEventSystemHandler
{
    private CinemachineVirtualCamera _camera;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponentInChildren<CinemachineVirtualCamera>();
        
    }

    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    Vector2 currentVelocity;
    // Update is called once per frame
    void Update()
    {
        if(rotate && _camera.m_Lens.Dutch < 90)
        {
            _camera.m_Lens.Dutch = Mathf.Lerp(_camera.m_Lens.Dutch, 90, Time.deltaTime);
        }
        else
        {
            Debug.Log("done");
        }
    }

    void OnSubmit(BaseEventData eventData)
    {

    }

    public void OnClick()
    {
        rotate = true;
    }

    bool rotate = false;
}
