using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {
    //This script attached to a gameobject to be faded in - for instance a black panel

    public float fadeInTime;            //seconds to fade in
    private Image fadePanel;            //in start() will find the image component of this panel
    private Color currentColor = Color.black;   //get a color to manipulate

	// Use this for initialization
	void Start () {
        fadePanel = GetComponent<Image>();      //find the panel Image
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad < fadeInTime)
        {
            float alphaChange = Time.deltaTime / fadeInTime;    //how much change needed this frame
            currentColor.a -= alphaChange;                      //manipluate the alpha on the color
            fadePanel.color = currentColor;                     //give this color to the panel
        }
        else
        {
            gameObject.SetActive(false);                        //disable teh panel to enable clicking
        }
	}
}
