using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GameObject.FindObjectOfType<MusicManager>();
        if (musicManager)
        {
            Debug.Log("Found music manager " + musicManager);
            float volume = PlayerPrefsManager.GetMasterVolume();

        }
        else
        {
            Debug.LogWarning("No music manager found on startup scene");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
