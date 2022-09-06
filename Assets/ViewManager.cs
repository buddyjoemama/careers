using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class ViewManager : MonoBehaviour, IEventSystemHandler
{
    public Slider slider;    
    public Player Player;
    public float ZoomOutBoardRadius;
    public Transform Board;

    private CinemachineVirtualCamera _camera;
    private CinemachineTargetGroup _cinemachineTargetGroup;
    private List<GameSquareCameraGroupAdjuster> _adjusterList;

    private float m_oldBoardRadius = 0;

    // Start is called before the first frame update
    void Start()
    {
        _camera = GetComponentInChildren<CinemachineVirtualCamera>();        
        _cinemachineTargetGroup = GetComponentInChildren<CinemachineTargetGroup>();
        _adjusterList = GetComponentsInChildren<GameSquareCameraGroupAdjuster>().ToList();
    }

    public void ZoomToCenter()
    {
        _adjusterList.ForEach(s => s.enabled = false);

        m_oldBoardRadius = _cinemachineTargetGroup.m_Targets[_cinemachineTargetGroup.FindMember(Board)].radius;

        _cinemachineTargetGroup.m_Targets[_cinemachineTargetGroup.FindMember(Board)].weight = 1;
        _cinemachineTargetGroup.m_Targets[_cinemachineTargetGroup.FindMember(Board)].radius = ZoomOutBoardRadius;

        _cinemachineTargetGroup.m_Targets[_cinemachineTargetGroup.FindMember(Player.transform)].weight = 0;
    }
}
