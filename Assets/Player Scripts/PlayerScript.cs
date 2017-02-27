using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    int hp;
    public AudioSource hitSound;
    public AudioSource blockSound;
    public Texture2D crosshair;
    // Use this for initialization
    void Start ()
    {
        hp = 3;

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(Input.mousePosition);
        if (hp <= 0)
        {
            //Game Over
            resetGame();
        }

    }
    void OnGUI()
    {
        float xMin = (Screen.width / 2) - (crosshair.width / 2);
        float yMin = (Screen.height / 2) - (crosshair.height / 2);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshair.width, crosshair.height), crosshair);
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
        }

    }
}
