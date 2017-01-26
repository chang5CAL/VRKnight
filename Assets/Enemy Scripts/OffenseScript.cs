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
    /// </summary>
    bool isActive;
    int chain;
    int followUp;
    bool coolDown;
    public int score;

	// Use this for initialization
	void Start () {
        isActive = false;
        coolDown = false; //If the player is hit, set to true.
        chain = 0;
	}
	
	// Update is called once per frame
	void Update () {
        int rand;
        System.Random rnd = new System.Random();
		if (Time.fixedDeltaTime % 5 == 0)
        {
            chain++;
            isActive = true;
            rand = rnd.Next(5);
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
            //Do an attack.
        }
        isActive = false;
	}
    void SlashLeft()
    {
        score = 1;
        System.Random followUp = new System.Random();
        int follow = followUp.Next(chain);
        //Probably not a great system...
        if (follow > chain/2)
        {
            //Basically, get a random number and if it divided by the chain 
            //is equal to a certain amount (Probably decided by time), increase
            //The chance of the enemy to do another attack immediately instead of
            //waiting.
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(5);
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
        }
                
    }
    void Thrust()
    {
        score = 2;
        int rand;
        System.Random rnd = new System.Random();
        rand = rnd.Next(3);
        if (rand == 0)
        {
            //Thrust High
        }
        else if(rand == 1)
        {
            //Thrust Mid
        }
        else
        {
            //Thrust Low
        }


        System.Random follow = new System.Random();
        followUp = follow.Next(10);
        if (followUp > chain)
        {
            chain++;
            rand = rnd.Next(5);
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
        }

    }
    void SlashLeftQuick()
    {
        score = 2;
        System.Random followUp = new System.Random();
        if (5 / chain > 10)
        {
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(5);
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
        }

    }
    void SlashRight()
    {
        score = 1;

        System.Random followUp = new System.Random();
        if (5 / chain > 10)
        {
            //Basically, get a random number and if it divided by the chain 
            //is equal to a certain amount (Probably decided by time), increase
            //The chance of the enemy to do another attack immediately instead of
            //waiting.
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(5);
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
        }

    }
    void SlashRightQuick()
    {
        score = 2;

        System.Random followUp = new System.Random();
        if (5 / chain > 10)
        {
            chain++;
            int rand;
            System.Random rnd = new System.Random();
            rand = rnd.Next(5);
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
        }

    }
}
