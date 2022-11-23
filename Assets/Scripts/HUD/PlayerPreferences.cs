using System;
using UnityEngine;

public static class PlayerPreferences
{
    public static String EmailAddress
    {
        get
        {
            return PlayerPrefs.GetString("email");
        }
        set
        {
            PlayerPrefs.SetString("email", value);
            PlayerPrefs.Save();
        }
    }

    public static String Name
    {
        get
        {
            return PlayerPrefs.GetString("name");
        }
        set
        {
            PlayerPrefs.SetString("name", value);
            PlayerPrefs.Save();
        }
    }

    public static String PlayerId
    {
        get
        {
            return PlayerPrefs.GetString("player_id");
        }
        set
        {
            PlayerPrefs.SetString("player_id", value);
            PlayerPrefs.Save();
        }
    }

    public static String Initials
    {
        get
        {
            return PlayerPrefs.GetString("initials");
        }
        set
        {
            PlayerPrefs.SetString("initials", value);
            PlayerPrefs.Save();
        }
    }

    public static bool Initialized => PlayerPrefs.HasKey("name");
}