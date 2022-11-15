using UnityEngine;

public class TitleDialog : MonoBehaviour
{
    public CreateGameDialog CreateGameDialog;
    public EventManager EventManager;

    // Start is called before the first frame update
    void Start()
    {
        EventManager.OnCreateGame += EventManager_OnCreateGame;
    }

    private void EventManager_OnCreateGame(GameInfo gameInfo)
    {
        this.gameObject.SetActive(false);
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
