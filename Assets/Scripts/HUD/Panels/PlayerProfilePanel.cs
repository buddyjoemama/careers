using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerProfilePanel : MonoBehaviour
{
    public TMP_InputField Name;
    public TMP_InputField Email;
    public TMP_InputField Initials;
    public Button OkButton;
    public Button CancelButton;
    public EventManager EventManager;
    public URLManager URLManager;
    public GameObject DisabledPanel;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        CancelButton.interactable = PlayerPreferences.Initialized;
    }

    public void TextField_OnChange()
    {
        OkButton.interactable =
            !string.IsNullOrEmpty(Name.text) &&
            !string.IsNullOrEmpty(Email.text) &&
            !string.IsNullOrEmpty(Initials.text);
    }

    public void OnOk_Click()
    {
        PlayerPreferences.EmailAddress = Email.text;
        PlayerPreferences.Name = Name.text;
        PlayerPreferences.Initials = Initials.text;

        StartCoroutine(CreateUserAsync());
    }

    private IEnumerator CreateUserAsync()
    {
        var player = new CareersGamePlayer
        {
            Email = Email.text,
            Initials = Initials.text,
            Name = Name.text
        };

        DisabledPanel.SetActive(true);
        EventManager.BeginAsyncOperation("Creating user...");

        string json = JsonConvert.SerializeObject(player);

        using (UnityWebRequest request =
            UnityWebRequest.Put(URLManager.CreateUser(), json))
        {
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Accept", "application/json");

            yield return request.SendWebRequest();

            EventManager.EndAsyncOperation();
            DisabledPanel.SetActive(false);

            if(request.result == UnityWebRequest.Result.Success)
            {
                var user = JsonConvert
                    .DeserializeObject<CareersGamePlayer>(request.downloadHandler.text);

                PlayerPreferences.PlayerId = user.Id;
                PlayerPreferences.Save();

                EventManager.CreateUser(user);
            }
            else
            {

            }
        }
    }

    public void OnCancel_Click()
    {
        this.gameObject.SetActive(false);
    }
}
