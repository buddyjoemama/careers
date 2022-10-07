using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class URLManager : MonoBehaviour
{
    public string ServerUrl;
    public List<string> URLList = new List<string>();

    internal string CreateGame(string installationId, string points)
    {
        string paramOne = nameof(installationId);
        string paramTwo = nameof(points);

        string url = GetUrl("CreateGame")
            .ReplaceToken(new[]
            {
                new KeyValuePair<string, string>(paramOne, installationId),
                new KeyValuePair<string, string>(paramTwo, points)
            });

        return $"{ServerUrl}{url}";
    }

    private string GetUrl(String key)
    {
        return URLList.Single(s => s.StartsWith(key)).Split(new char[] { '=' }).Last();
    }
}
