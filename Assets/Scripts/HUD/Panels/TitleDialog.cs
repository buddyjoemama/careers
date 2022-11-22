using UnityEngine;

public class TitleDialog : MonoBehaviour
{
    public CreateGameDialog CreateGameDialog;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateGame_Click()
    {
        CreateGameDialog.gameObject.SetActive(true);       
    }

    public void ResumeGame_Click() 
    {
 
    }

    public void JoinGame_Click()
    {

    }
}
