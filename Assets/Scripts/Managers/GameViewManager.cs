using Cinemachine;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;

public class GameViewManager : MonoBehaviour, IEventSystemHandler
{
    public CinemachineTargetGroup CinemachineTargetGroup;
    public PlayerMoveManager PlayerMoveManager;
    public PlayersManager PlayersManager;
    public Transform StartPosition;
    public Transform PlayerContainer;
    public Player CanonicalPlayer;

    private Dictionary<CareersGamePlayer, Player> _playerMembers
        = new Dictionary<CareersGamePlayer, Player>();

    private int _currentViewPlayer = 0;

    void Awake()
    {
        PlayersManager.OnPlayerLoaded += PlayersManager_OnPlayerLoaded;
        PlayersManager.OnPlayerJoined += PlayersManager_OnPlayerJoined;
        PlayersManager.OnPlayerSelected += PlayersManager_OnPlayerSelected;
        PlayersManager.OnAllPlayersSelected += PlayersManager_OnAllPlayersSelected;
    }

    private void PlayersManager_OnAllPlayersSelected()
    {
        ResetCameraToWeight(1);
    }

    private void ResetCameraToWeight(int weight)
    {
        foreach (var player in _playerMembers)
        {
            var member = CinemachineTargetGroup.FindMember(player.Value.transform);

            CinemachineTargetGroup.m_Targets[member].weight = weight;
        }
    }

    /// <summary>
    /// Zoom-in to the selected player.
    /// </summary>
    /// <param name="player"></param>
    private void PlayersManager_OnPlayerSelected(CareersGamePlayer player)
    {
        if (player != null)
        {
            var gameBoardPlayer = _playerMembers[player];
            var cameraMember = CinemachineTargetGroup.FindMember(gameBoardPlayer.transform);

            ResetCameraToWeight(0);
            CinemachineTargetGroup.m_Targets[cameraMember].weight = 6;
            _currentViewPlayer = cameraMember;
        }
    }

    private void PlayersManager_OnPlayerJoined(CareersGamePlayer player)
    {
        var newPlayer = InstantiatePlayer(player, 0);

        // Debug code
        var position = PlayerMoveManager[Random.Range(1, 40)];
        newPlayer.transform.position = position.transform.position;
    }

    private void PlayersManager_OnPlayerLoaded(CareersGamePlayer player)
    {
        var newPlayer = InstantiatePlayer(player, 6);

        // Camea should be focused on the current player (the player who created the game).
        _currentViewPlayer = CinemachineTargetGroup.FindMember(newPlayer.transform);
    }

    /// <summary>
    /// PlayerContainer is the transform located at Payday.
    /// </summary>
    /// <param name="player"></param>
    private Player InstantiatePlayer(CareersGamePlayer player, int weight)
    {
        var newPlayer = Instantiate(CanonicalPlayer, PlayerContainer);
        newPlayer.PlayersManager = PlayersManager;
        newPlayer.transform.position = StartPosition.transform.position;
        newPlayer.Color = PlayersManager.GetPlayerColor(player);
        newPlayer.SetPlayer(player);

        CinemachineTargetGroup.AddMember(newPlayer.transform, weight, 0);
        _playerMembers.Add(player, newPlayer);

        return newPlayer;
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
