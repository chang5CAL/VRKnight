using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    int hp;
    public AudioSource hitSound;
    public Texture2D bloodSplatter;
    // Use this for initialization
    void Start ()
    {
        hp = 3;

    }
	
	// Update is called once per frame
	void Update ()
    {
        //transform.LookAt(Input.mousePosition);
        if (hp <= 0)
        {
            //Game Over
            resetGame();
        }

    }
    void resetGame()
    {
        //Open up a GUI that let's the player do things
        //On reset:
        hp = 3;
        //On Main menu
    }
    
    void onCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Enemy")
        {
            //Subtract health
            hp--;
            hitSound.Play();
            onHit();
        }

    }

    void onHit()
    {
        //Shake the camera a bit, or do something to indicate the player's been hit
        //For instance, screen turns red for a bit.
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), bloodSplatter);
        float startTime = Time.time;
        while(Time.time + 1 < startTime)
        {
            //Make the screen flash red then go transparent.git
        }
    }
}
