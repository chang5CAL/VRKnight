using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
        //Need to move the camera with the player model
        //So that there's no clipping.
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Input.mousePosition);
	}

}
