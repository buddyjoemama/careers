using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return PlayerPrefs.GetString("player_id");
        }
        set
        {
            PlayerPrefs.SetString("player_id", value);
        }
    }
}