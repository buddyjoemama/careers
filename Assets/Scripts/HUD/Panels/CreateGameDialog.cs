using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGameDialog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OK_Click() 
    {
        this.gameObject.SetActive(false);
    }

    public void Cancel_Click() 
    {
        this.gameObject.SetActive(false);
    }
}
