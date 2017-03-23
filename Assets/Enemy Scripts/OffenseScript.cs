using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class OffenseScript : MonoBehaviour {
    /// <summary>
    /// This controls the enemy AI in defense mode.
    /// It'll just keep attacking every few seconds, 
    /// with the frequency increasing as time goes on.
    /// Does not stagger on successful block.
    /// This is really only the sword. I might merge it
    /// if I can get a model that's a knight with a sword.
    /// </summary>
    bool isActive;
    int chain;
    int followUp;
    bool coolDown;
    public Animation reset;
    public Animation leftSlash;
    public Animation rightSlash;
    public Animation leftSlashQuick;
    public Animation rightSlashQuick;
    public Animation chop;
    public Animation highThrust;
    public Animation medThrust;
    public Animation lowThrust;
    public Animation deflect;
    public AudioSource blockSound;
    int hitTime;

    // Use this for initialization
    void Start () {
        isActive = false;
        coolDown = false; //If the player is hit, set to true.
        chain = 0;
        hitTime = 5;
	}
	
	// Update is called once per frame
	void Update () {
        print("Time: "+Time.time);
        int rand;
        System.Random rnd = new System.Random();
		if ((int)Time.time % 10 == hitTime)
        {
            //Another thing is that if it keeps chaining, don't start a new loop.
            if (hitTime == 5 && Time.time < 60)
            {
                hitTime = 0;
            }
            else if (hitTime == 0 && Time.time < 60)
            {
                hitTime = 5;
            }
            else
            {
                hitTime = (hitTime + 3) % 10; //So after a minute, make it hit once every 3 seconds.
            }
            print("Using an attack");
            chain++;
            isActive = true;
            rand = rnd.Next(6);
            if (rand == 0)
            {
                print("Slashing Left");
                SlashLeft();
            }
            else if (rand == 1)
            {
                print("Thrusting");
                Thrust();
            }
            else if (rand == 2)
            {
                print("Slashing Left Quickly");
                SlashLeftQuick();
            }
            else if (rand == 3)
            {
                print("Slashing Right");
                SlashRight();
            }
            else if (rand == 4)
            {
                print("Slashing Right Quickly");
                SlashRightQuick();
            }
            else if (rand == 5)
            {
                print("Chopping");
                Chop();
            }
            //Do an attack.

            //Reset chain and isActive
            isActive = false;
            chain = 0;
        }
	}
    void SlashLeft()
    {
        isActive = true;
        leftSlash.Play();
        isActive = false;
        resetToDefault();
        System.Random followUp = new System.Random();
        int follow = followUp.Next(chain);
        if (follow > chain * 3)
        {
            //Basically, get a random number and if it divided by the chain 
            //is equal to a certain amount (Probably decided by time), increase
            //The chance of the enemy to do another attack immediately instead of
            //waiting.
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(6);
            if (rand == 0)
            {
                SlashLeft();
            }
            else if (rand == 1)
            {
                Thrust();
            }
            else if (rand == 2)
            {
                SlashLeftQuick();
            }
            else if (rand == 3)
            {
                SlashRight();
            }
            else if (rand == 4)
            {
                SlashRightQuick();
            }
            else if (rand == 6)
            {
                Chop();
            }
        }

    }
    void Chop()
    {

        //This should just be a downward chop.
        isActive = true;
        chop.Play();
        isActive = false;

        resetToDefault();
        System.Random followUp = new System.Random();
        int follow = followUp.Next(chain);
        if (follow > chain * 3)
        {
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(6);
            if (rand == 0)
            {
                SlashLeft();
            }
            else if (rand == 1)
            {
                Thrust();
            }
            else if (rand == 2)
            {
                SlashLeftQuick();
            }
            else if (rand == 3)
            {
                SlashRight();
            }
            else if (rand == 4)
            {
                SlashRightQuick();
            }
            else if (rand == 6)
            {
                Chop();
            }
        }

    }
    void Thrust()
    {
        int rand;
        resetToDefault();
        System.Random rnd = new System.Random();
        rand = rnd.Next(3);
        isActive = true;
        if (rand == 0)
        {
            //Thrust High
            highThrust.Play();
        }
        else if(rand == 1)
        {
            //Thrust Mid
            medThrust.Play();
        }
        else
        {
            //Thrust Low
            lowThrust.Play();
        }
        isActive = false;

        resetToDefault();

        System.Random followUp = new System.Random();
        int follow = followUp.Next(5);
        if (follow > chain * 3)
        {
            chain++;
            rand = rnd.Next(6);
            if (rand == 0)
            {
                SlashLeft();
            }
            else if (rand == 1)
            {
                Thrust();
            }
            else if (rand == 2)
            {
                SlashLeftQuick();
            }
            else if (rand == 3)
            {
                SlashRight();
            }
            else if (rand == 4)
            {
                SlashRightQuick();
            }
            else if (rand == 6)
            {
                Chop();
            }
        }

    }
    void SlashLeftQuick()
    {
        isActive = true;
        leftSlashQuick.Play();
        isActive = false;

        resetToDefault();
        System.Random followUp = new System.Random();
        int follow = followUp.Next(5);
        if (follow > chain * 3)
        {
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(6);
            if (rand == 0)
            {
                SlashLeft();
            }
            else if (rand == 1)
            {
                Thrust();
            }
            else if (rand == 2)
            {
                SlashLeftQuick();
            }
            else if (rand == 3)
            {
                SlashRight();
            }
            else if (rand == 4)
            {
                SlashRightQuick();
            }
            else if (rand == 6)
            {
                Chop();
            }
        }

    }
    void SlashRight()
    {
        isActive = true;
        rightSlash.Play();
        isActive = false;
        resetToDefault();
        System.Random followUp = new System.Random();
        int follow = followUp.Next(5);
        if (follow > chain * 3)
        {
            //Basically, get a random number and if it divided by the chain 
            //is equal to a certain amount (Probably decided by time), increase
            //The chance of the enemy to do another attack immediately instead of
            //waiting.
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(6);
            if (rand == 0)
            {
                SlashLeft();
            }
            else if (rand == 1)
            {
                Thrust();
            }
            else if (rand == 2)
            {
                SlashLeftQuick();
            }
            else if (rand == 3)
            {
                SlashRight();
            }
            else if (rand == 4)
            {
                SlashRightQuick();
            }
            else if (rand == 6)
            {
                Chop();
            }
        }

    }
    void SlashRightQuick()
    {
        isActive = true;
        rightSlashQuick.Play();
        isActive = false;
        resetToDefault();
        System.Random followUp = new System.Random();
        int follow = followUp.Next(5);
        if (follow > chain*3)
        {
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(6);
            if (rand == 0)
            {
                SlashLeft();
            }
            else if (rand == 1)
            {
                Thrust();
            }
            else if (rand == 2)
            {
                SlashLeftQuick();
            }
            else if (rand == 3)
            {
                SlashRight();
            }
            else if (rand == 4)
            {
                SlashRightQuick();
            }
            else if (rand == 6)
            {
                Chop();
            }
        }

    }

    void resetToDefault()
    {

        reset.Play();

    }
    void onCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "UI")
        {
            //Subtract health
            blockSound.Play();
            //Need to stop whatever animation.
            deflect.Play();
        }

    }
}
