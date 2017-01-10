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

	// Use this for initialization
	void Start () {
        isActive = false;
	}
	
	// Update is called once per frame
	void Update () {
        int rand;
        System.Random rnd = new System.Random();
		if (Time.fixedDeltaTime % 5 == 0)
        {
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
                
    }
    void Thrust()
    {

    }
    void Slash()
    {

    }
}
