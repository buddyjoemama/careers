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
    public SimpleErrorDialog SimpleErrorDialog;

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
        var s = JsonConvert.SerializeObject(new
        {
            name = "test"
        });

        using (UnityWebRequest request = 
            UnityWebRequest.Put(URLManager.CreateGame(PlayerPreferences.EmailAddress, PointsTextBox.text), s))
        {
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Accept", "application/json");

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
                EventManager.EndAsyncOperation();
                SimpleErrorDialog.ErrorMessage = "Error creating game. Please try again.";
                SimpleErrorDialog.gameObject.SetActive(true);
            }
        }
    }
}
