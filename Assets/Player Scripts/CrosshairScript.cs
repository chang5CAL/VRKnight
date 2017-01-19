using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour {
    int score;
    AudioSource blockSound;
    Texture2D crosshair;
	// Use this for initialization
	void Start () {
        score = 0;
        //ImagePosition = Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
	}
	
	// Update is called once per frame
	void Update () {

    }
    void onCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Enemy")
        {
            score++;
            blockSound.Play();
        }

    }
    void OnGUI()
    {

    }
}
