using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairScript : MonoBehaviour {
    int score;
	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {

    }
    void onCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Enemy")
        {
            score++;
        }

    }
}
