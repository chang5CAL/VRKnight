using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public delegate void Action();
    int hp;
    int score;
    public AudioSource hitSound;
    public Texture2D bloodSplatter;
    public event Action onOver;
    // Use this for initialization
    void Start ()
    {
        hp = 3;

    }
	

	// Update is called once per frame
	void Update ()
    {
        Vector3 front = transform.TransformDirection(Vector3.forward);
        Ray ray = Camera.main.ScreenPointToRay(front);
        RaycastHit hit;
        if (Physics.Raycast(transform.position,front,out hit))
        {
            if (hit.collider.tag == "EnemyWeapon")
            {
                print("Registered hit on weapon");
                GameObject enemy = GameObject.Find("Enemy");
                OffenseScript s = (OffenseScript) enemy.GetComponent(typeof(OffenseScript));
                s.deflectCheck();
                //Cancel AI's attack
            }
        }
        score = (int)Time.time;
        //transform.LookAt(Input.mousePosition);
        if (hp <= 0)
        {
            //Game Over
            resetGame();
        }

    }
    void resetGame()
    {
        bool reset = false;
        //Open up a GUI that let's the player do things
        //On reset:
        if (reset)
        {
            hp = 3;
            //On Main menu
            score = 0;
        } else
        {
            //Quit game
        }
    }
    
    void onCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "EnemyWeapon")
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
        GUI.backgroundColor = new Color(255, 0, 0);
        float startTime = Time.time;
        while(Time.time + 1 < startTime)
        {

            GUI.backgroundColor = new Color(255-(startTime - Time.time)*255, 0, 0);
            //Make the screen flash red then go transparent.
        }
        GUI.backgroundColor = new Color(0, 0, 0);
    }
    
}
