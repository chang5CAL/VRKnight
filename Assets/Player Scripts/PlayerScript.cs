using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    int hp;
    public AudioSource hitSound;
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
