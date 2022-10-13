using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class CreateGameDialog : MonoBehaviour
{
    public EventManager EventManager;
    public URLManager URLManager;
    public TMP_InputField PointsTextBox;

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
        EventManager.BeginAsyncOperation("Creating game...");
        StartCoroutine(CreateGameAsync());
    }

    public void Cancel_Click() 
    {
        this.gameObject.SetActive(false);
    }

    private IEnumerator CreateGameAsync()
    {
        using (UnityWebRequest request = UnityWebRequest.Post(URLManager.CreateGame("test123", PointsTextBox.text), ""))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                var response = JsonConvert.DeserializeObject<GameInfo>(request.downloadHandler.text);
                EventManager.OpenGame(response);
                EventManager.BeginAsyncOperation("Opening game...");
                this.gameObject.SetActive(false);
            }
            else
            {

            }
        }
    }
}
