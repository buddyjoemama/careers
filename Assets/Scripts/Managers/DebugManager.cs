using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DebugManager : MonoBehaviour
{
    public PlayersManager PlayersManager;

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
}

[CustomEditor(typeof(DebugManager))]
public class DebugManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        DebugManager manager = (DebugManager)target;

        EditorGUILayout.LabelField("Name", PlayerPreferences.Name);
        EditorGUILayout.TextField("Id", PlayerPreferences.PlayerId);

        if (GUILayout.Button("Clear Preferences"))
        {
            manager.ClearPreferences();
        }    

        if(GUILayout.Button("Create Default Player"))
        {

        }

        if(GUILayout.Button("Player Join"))
        {
            manager.JoinPlayer();
        }
    }
}