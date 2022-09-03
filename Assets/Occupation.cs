using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Occupation : MonoBehaviour
{
    public string Name;
    public int Id;
    public bool HasShortcut = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<OccupationSquare> OccupationSquares => this.GetComponentsInChildren<OccupationSquare>().ToList();
}
