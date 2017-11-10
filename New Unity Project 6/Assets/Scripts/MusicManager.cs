using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;   //private audio source


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load: " + name);
    }
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();   //find the audio source

    }

    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];            //set the value to a variable
        Debug.Log("Playing clip: " + levelMusicChangeArray[level]);

        if(thisLevelMusic)  //if there is some music attached
        {
            audioSource.clip = thisLevelMusic;                  //tell it what clip to play
            audioSource.loop = true;                            //loop it
            audioSource.Play();                                 //play it
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
