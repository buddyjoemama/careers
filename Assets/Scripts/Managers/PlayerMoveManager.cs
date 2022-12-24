using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using System.Linq;
using System;

public class PlayerMoveManager : MonoBehaviour
{
    public GameViewManager GameViewManager;
    private List<Hotspot> _hotspots;

    // Start is called before the first frame update
    void Start()
    {
        _hotspots = GameObject.FindGameObjectsWithTag("Hotspot")
            .Select((s, i) =>
            {
                var hotspot = s.gameObject.GetComponent<Hotspot>();
                hotspot.PositionIndex = i;

                return hotspot;
            })
            .ToList();

        Assert.IsNotNull(_hotspots);
    }

    public Hotspot this[int key]
    {
        get
        {
            return _hotspots[key];
        }
    }

    int index = 0;
    // Update is called once per frame
    void Update()
    {
        //return;
        //var target = _hotspots[index].transform.position;

        //_player.transform.position =
        //    Vector2.MoveTowards(_player.transform.position, target, 1 * Time.deltaTime);

        //if (_hotspots[index].PlayerOnOccupation())
        //{
        //    Debug.Log("Player on occupation: " + _hotspots[index].Occupation.Name);
        //}

        //if (_hotspots[index].IsOccupied)
        //{
        //    _hotspots[index].SetOccupied(false);
        //    index += 1;
        //}

        //if (index == _hotspots.Count - 1)
        //    index = 0;
    }

    internal void Move(CareersGamePlayer me)
    {
        var player = GameViewManager.GetPlayer(me);

        if (isMoving)
            return;

        lock (this)
        {
            if (!isMoving)
            {
                isMoving = true;
                StartCoroutine(MovePlayer(player));
            }
        }
    }

    private bool isMoving = false;

    private IEnumerator MovePlayer(Player player)
    {
        var hotspot = _hotspots[++index];
        var target = hotspot.transform.position;

        index = index % (_hotspots.Count - 1);

        while (!hotspot.IsOccupiedBy(player))
        {
            player.transform.position =
                Vector2.MoveTowards(player.transform.position, target, Time.deltaTime);

            yield return new WaitForEndOfFrame();
        }

        isMoving = false;
    }
}
