using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;        //seconds to wait until auto loading next level

    private void Start()
    {
        if (autoLoadNextLevelAfter == 0)        //don't autoload if this is zero
        {
            Debug.Log("Auto load disabled");
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);    //auto load next level
        }
    }

    public void LoadLevel(string name)
    {
        
        Debug.Log("Level load requested for: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitLevel()
    {
        Debug.Log("Request to quit the game");
        Application.Quit();
    }

    public void returnToScene(string name)
    {
        SceneManager.LoadScene(name);
       
    }

    //function toload the next level based on build index
    public void LoadNextLevel()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

   
    

}
