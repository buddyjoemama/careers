using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Networking;

public class CareersUIManager : MonoBehaviour
{
    public GameManager GameManager;
    public URLManager URLManager;

    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateGame()
    {
        StartCoroutine(PerformPostRequest(URLManager.CreateGame("abc123", 200), "", (s) =>
        {
            string gameId = Regex.Match(s, "^\"(?<id>.*)\"$").Groups["id"].Value;
        }));
    }

    private IEnumerator PerformPostRequest(string url, string data, Action<string> successAction, Action failAction = null)
    {
        using (UnityWebRequest request = UnityWebRequest.Post(url, data))
        {
            yield return request.SendWebRequest();

            if(request.result == UnityWebRequest.Result.Success)
            {
                successAction(request.downloadHandler.text);
            }
            else if(failAction != null)
            {
                failAction();
            }
        }
    }
}
