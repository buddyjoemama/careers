using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfilePanel : MonoBehaviour
{
    public TMP_InputField Name;
    public TMP_InputField Email;
    public TMP_InputField Initials;
    public Button OkButton;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
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
    }

    public void OnCancel_Click()
    {
        this.gameObject.SetActive(false);
    }
}
