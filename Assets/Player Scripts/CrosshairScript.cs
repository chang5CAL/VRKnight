using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour {
    int score;
    AudioSource blockSound;
    public Texture2D crosshair;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {

    }
    void onCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Enemy")
        {
            score++;
            int time;
            //Not sure how collision works with GUI elements, or even if it does.
        }

    }
    void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crosshair.width / 2);
        float yMin = (Screen.height / 2) - (crosshair.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshair.width, crosshair.height), crosshair);
    } 
}
