﻿using System;
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
            return "2dfefef2-57ca-4329-bdc0-1493619f9dc2";// PlayerPrefs.GetString("player_id");
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