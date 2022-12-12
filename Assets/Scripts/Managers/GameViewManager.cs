using Cinemachine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameViewManager : MonoBehaviour, IEventSystemHandler
{
    public CinemachineTargetGroup CinemachineTargetGroup;
    public PlayerMoveManager PlayerMoveManager;
    public PlayersManager PlayersManager;
    public Transform StartPosition;
    public Transform PlayerContainer;
    public Player CanonicalPlayer;

    private Dictionary<Player, Transform> _playerMembers
        = new Dictionary<Player, Transform>();

    void Awake()
    {
        PlayersManager.OnPlayerLoaded += PlayersManager_OnPlayerLoaded;
        PlayersManager.OnPlayerJoined += PlayersManager_OnPlayerJoined;
    }

    private void PlayersManager_OnPlayerJoined(CareersGamePlayer player)
    {
        InstantiatePlayer(player);
    }

    private void PlayersManager_OnPlayerLoaded(CareersGamePlayer player)
    {
        InstantiatePlayer(player);
    }

    /// <summary>
    /// PlayerContainer is the transform located at Payday.
    /// </summary>
    /// <param name="player"></param>
    private void InstantiatePlayer(CareersGamePlayer player)
    {
        var newPlayer = Instantiate(CanonicalPlayer, PlayerContainer);
        newPlayer.PlayersManager = PlayersManager;
        newPlayer.transform.position = StartPosition.transform.position;
        newPlayer.Color = PlayersManager.GetPlayerColor(player);
        newPlayer.SetPlayer(player);

        CinemachineTargetGroup.AddMember(newPlayer.transform, 6, 0);
        _playerMembers.Add(newPlayer, newPlayer.transform);
    }

    //public Slider slider;    
    //public Player Player;
    //public float ZoomOutBoardRadius;
    //public Transform Board;

    //private CinemachineVirtualCamera _camera;
    //private CinemachineTargetGroup _cinemachineTargetGroup;
    //private List<GameSquareCameraGroupAdjuster> _adjusterList;

    //private float m_oldBoardRadius = 0;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    _camera = GetComponentInChildren<CinemachineVirtualCamera>();        
    //    _cinemachineTargetGroup = GetComponentInChildren<CinemachineTargetGroup>();
    //    _adjusterList = GetComponentsInChildren<GameSquareCameraGroupAdjuster>().ToList();
    //}

    //public void ZoomToCenter()
    //{
    //    _adjusterList.ForEach(s => s.enabled = false);

    //    m_oldBoardRadius = _cinemachineTargetGroup.m_Targets[_cinemachineTargetGroup.FindMember(Board)].radius;

    //    _cinemachineTargetGroup.m_Targets[_cinemachineTargetGroup.FindMember(Board)].weight = 1;
    //    _cinemachineTargetGroup.m_Targets[_cinemachineTargetGroup.FindMember(Board)].radius = ZoomOutBoardRadius;

    //    _cinemachineTargetGroup.m_Targets[_cinemachineTargetGroup.FindMember(Player.transform)].weight = 0;
    //}
}
