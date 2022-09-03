using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using System.Linq;

public class PlayerMoveManager : MonoBehaviour
{
    private Player _player;
    private List<Hotspot> _hotspots;

    // Start is called before the first frame update
    void Start()
    {
        _player = this.GetComponentInChildren<Player>();
        Assert.IsNotNull(_player);

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

    int index = 0;
    // Update is called once per frame
    void Update()
    {
        var target = _hotspots[index].transform.position;

        _player.transform.position =
            Vector2.MoveTowards(_player.transform.position, target, 1 * Time.deltaTime);

        if (_hotspots[index].PlayerOnOccupation())
        {
            Debug.Log("Player on occupation: " + _hotspots[index].Occupation.Name);
        }

        if (_hotspots[index].IsOccupied)
        {
            _hotspots[index].SetOccupied(false);
            index += 1;
        }

        if (index == _hotspots.Count - 1)
            index = 0;
    }
}