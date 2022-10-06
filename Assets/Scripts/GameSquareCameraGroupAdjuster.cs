using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// At the end of the roll (after the player moves to the appropriate square)
/// adjust the camera target group to take into account optional viewing data.
/// 
/// For instance, a player lands on an occupation entrance square and the virtual camera
/// doesnt have the entire occupation squares visible. This action will adjust the weights of 
/// the target group to take those extra squares into account.
/// </summary>
public class GameSquareCameraGroupAdjuster : MonoBehaviour
{
    // Start is called before the first frame update
    public CinemachineTargetGroup TargetGroup;

    public Transform Target;
    public float TargetWeight;

    private float _oldWeight;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (enabled)
        {
            _oldWeight = TargetGroup.m_Targets[TargetGroup.FindMember(Target)].weight;
            TargetGroup.m_Targets[TargetGroup.FindMember(Target)].weight = TargetWeight;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(enabled)
            TargetGroup.m_Targets[TargetGroup.FindMember(Target)].weight = _oldWeight;
    }
}
