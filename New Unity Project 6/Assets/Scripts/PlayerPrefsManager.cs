using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour {

    //This is a wrapper class to simplify interaction with Unity Player Prefs

    //constants to equate with the player pref key values
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFF_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";         //will always be followed by a string for the level number

    public static void SetMasterVolume(float volume)
    {
        if (volume > 0f && volume < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume out of range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void UnlockLevel(int level)
    {
        if(level <= SceneManager.sceneCountInBuildSettings - 1)
        {
            PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);        //Use 1 for true
        }
        else
        {
            Debug.LogError("Attempting to unlock a level not in the build order");
        }
    }

    public static bool IsLevelUnlocked(int level)
    {
        int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());      //get the level unlock value

        bool isLevelUnlocked = (levelValue == 1);               //simpler than an if/then

        if (level <= SceneManager.sceneCountInBuildSettings - 1)  //value passed is a valid level number
        {
            return isLevelUnlocked;                             
        }
        else
        {
            Debug.LogError("Attempting to query a level not in the build order");
            return false;
        }
    }

    public static void SetDifficulty(float difficulty)
    {
        if(difficulty < 1f || difficulty > 3f)
        {
            Debug.LogError("Invalid Difficutly Level");
        }
        else
        {
            PlayerPrefs.SetFloat(DIFF_KEY, difficulty);
        }
    }

    public static float GetDifficulty()
    {
        return (PlayerPrefs.GetFloat(DIFF_KEY));
    }

}
