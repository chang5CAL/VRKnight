﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewScript : MonoBehaviour {
    int hp;
	// Use this for initialization
	void Start () {
        hp = 3;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Input.mousePosition);
        if (hp <= 0)
        {
            //Game Over
        }
	}

    void onCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "Enemy")
        {
            //Subtract health
            hp--;
        }

    }
}
