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
        }
    }

    public static String PlayerId
    {
        get
        {
            return "07c50af2-2ed5-4c01-94ed-5d5ac8780024";
            return PlayerPrefs.GetString("player_id");
        }
        set
        {
            PlayerPrefs.SetString("player_id", value);
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
        }
    }

    public static void Save()
    {
        PlayerPrefs.Save();
    }

    public static bool Initialized => PlayerPrefs.HasKey("name");
}