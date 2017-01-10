﻿using System.Collections;
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
            rand = rnd.Next(3);
            if (rand == 0)
            {
                Attack();
            }
            else if (rand == 1)
            {
                Thrust();
            }
            else if (rand == 2)
            {
                Slash();
            }
            //Do an attack.
        }
        isActive = false;
	}
    void Attack()
    {

        System.Random followUp = new System.Random();
        if (5 / chain > 10)
        {
            //Basically, get a random number and if it divided by the chain 
            //is equal to a certain amount (Probably decided by time), increase
            //The chance of the enemy to do another attack immediately instead of
            //waiting.
            chain++;
        }
                
    }
    void Thrust()
    {

        System.Random followUp = new System.Random();
        if (5 / chain > 10)
        {
            chain++;
        }

    }
    void Slash()
    {

        System.Random followUp = new System.Random();
        if (5 / chain > 10)
        {
            chain++;
        }

    }
}
