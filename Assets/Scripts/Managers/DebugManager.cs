using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

public class DebugManager : MonoBehaviour
{
    public PlayersManager PlayersManager;
    public URLManager URLManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EditorGUI.BeginChangeCheck();
        EditorGUI.EndChangeCheck(); 
    }

    public void ClearPreferences()
    {
        PlayerPrefs.DeleteAll();
    }

    public void JoinPlayer()
    {
        CareersGamePlayer player = new CareersGamePlayer();
        player.Number = PlayersManager.PlayerCount;

        PlayersManager.JoinPlayer(player);
    }

    public void UpdatePlayerId(string id)
    {
        PlayerPreferences.PlayerId = id;
    }

    public void CreatePlayer()
    {
        StartCoroutine(CreatePlayerInternal());
    }

    private IEnumerator CreatePlayerInternal()
    {
        var player = new CareersGamePlayer
        {
            Email = "testuser@test.com",//"Email.text,
            Initials = "tu",
            Name = "test user"
        };

        string json = JsonConvert.SerializeObject(player);

        using (UnityWebRequest request =
            UnityWebRequest.Put(URLManager.CreateUser(), json))
        {
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Accept", "application/json");

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                var user = JsonConvert
                    .DeserializeObject<CareersGamePlayer>(request.downloadHandler.text);

                PlayerPreferences.PlayerId = user.Id;
                PlayerPreferences.Name = user.Name;
                PlayerPreferences.EmailAddress = user.Email;
                PlayerPreferences.Save();
            }
            else
            {

            }
        }
    }
}

[CustomEditor(typeof(DebugManager))]
public class DebugManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        DebugManager manager = (DebugManager)target;

        EditorGUILayout.LabelField("Name", PlayerPreferences.Name);
        EditorGUILayout.LabelField("Id", PlayerPreferences.PlayerId);
        EditorGUILayout.LabelField("Email", PlayerPreferences.EmailAddress);

        if (GUILayout.Button("Clear Preferences"))
        {
            manager.ClearPreferences();
        }    

        if(GUILayout.Button("Create player one"))
        {
            manager.CreatePlayer();
        }

        if(GUILayout.Button("Player Join"))
        {
            manager.JoinPlayer();
        }
    }
}