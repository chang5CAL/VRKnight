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
    public int score;
    public Animation reset;
    public Animation leftSlash;
    public Animation rightSlash;
    public Animation leftSlashQuick;
    public Animation rightSlashQuick;
    public Animation chop;
    public Animation highThrust;
    public Animation medThrust;
    public Animation lowThrust;

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
            //Do an attack.
        }
        resetToDefault();
        isActive = false;
	}
    void SlashLeft()
    {
        float startTime = Time.deltaTime;
        while (Time.deltaTime < startTime + 3)
        {
            //Here, take 5 seconds to put sword back in place. Probably too long.
            /*
            transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                transform.position.y - transform.position.y / 2 + .87f,
                transform.position.z - transform.position.z / 2);
            */

            transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x / 2,
                transform.rotation.y,
                transform.rotation.z,
                transform.rotation.w);
            //So I need to figure out which axis I need to rotate around I assume X, so I'm
            //removing the rotation except for the X.
        }

        score += 1;
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
        score += 1;
        float startTime = Time.deltaTime;
        while (Time.deltaTime < startTime + 1)
        {
            //Here, take 5 seconds to put sword back in place. Probably too long.
            /*
            transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                transform.position.y - transform.position.y / 2 + .87f,
                transform.position.z - transform.position.z / 2);
            */

            transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x / 2,
                transform.rotation.y,
                transform.rotation.z,
                transform.rotation.w);
            //So I need to figure out which axis I need to rotate around I assume X, so I'm
            //removing the rotation except for the X.
    }

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
        score += 3;
        float startTime = Time.deltaTime;
        while (Time.deltaTime < startTime + 1)
        {
            //Here, take 5 seconds to put sword back in place. Probably too long.
            /*
            transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                transform.position.y - transform.position.y / 2 + .87f,
                transform.position.z - transform.position.z / 2);
            */

            transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x / 2,
                transform.rotation.y,
                transform.rotation.z,
                transform.rotation.w);
            //So I need to figure out which axis I need to rotate around I assume X, so I'm
            //removing the rotation except for the X.
        }
        int rand;
        System.Random rnd = new System.Random();
        rand = rnd.Next(3);
        if (rand == 0)
        {
            //Thrust High
            while (Time.deltaTime < startTime + 3)
            {
                //Here, take 5 seconds to put sword back in place. Probably too long.
                transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                    transform.position.y - transform.position.y / 2 + .5f,
                    transform.position.z - transform.position.z / 2);

                transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x / 2,
                    transform.rotation.y,
                    transform.rotation.z,
                    transform.rotation.w);
                //So I need to figure out which axis I need to rotate around I assume X, so I'm
                //removing the rotation except for the X.
            }
        }
        else if(rand == 1)
        {
            //Thrust Mid
            while (Time.deltaTime < startTime + 3)
            {
                //Here, take 5 seconds to put sword back in place. Probably too long.
                transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                    transform.position.y,
                    transform.position.z - transform.position.z / 2);
                transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x / 2,
                    transform.rotation.y,
                    transform.rotation.z,
                    transform.rotation.w);
                //So I need to figure out which axis I need to rotate around I assume X, so I'm
                //removing the rotation except for the X.
            }
        }
        else
        {
            //Thrust Low
            while (Time.deltaTime < startTime + 3)
            {
                //Here, take 5 seconds to put sword back in place. Probably too long.
                transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                    transform.position.y - transform.position.y / 2 + .87f,
                    transform.position.z - transform.position.z / 2);
                transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x / 2,
                    transform.rotation.y,
                    transform.rotation.z,
                    transform.rotation.w);
                //So I need to figure out which axis I need to rotate around I assume X, so I'm
                //removing the rotation except for the X.
            }
        }
        while (Time.deltaTime < startTime + 5)
        {
            transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                transform.position.y - transform.position.y / 2 - .5f,
                transform.position.z - transform.position.z / 2);
            //This one just moves it forward to stab.
        }


        System.Random followUp = new System.Random();
        int follow = followUp.Next(score);
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
        score += 2;
        float startTime = Time.deltaTime;
        while (Time.deltaTime < startTime + 1)
        {
            //Here, take 5 seconds to put sword back in place. Probably too long.
            /*
            transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                transform.position.y - transform.position.y / 2 + .87f,
                transform.position.z - transform.position.z / 2);
            */

            transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x / 2,
                transform.rotation.y,
                transform.rotation.z,
                transform.rotation.w);
            //So I need to figure out which axis I need to rotate around I assume X, so I'm
            //removing the rotation except for the X.
        }
        System.Random followUp = new System.Random();
        int follow = followUp.Next(score);
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
        score += 1;

        System.Random followUp = new System.Random();
        int follow = followUp.Next(score);
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
        score += 2;

        float startTime = Time.deltaTime;
        while (Time.deltaTime < startTime + 1)
        {
            //Here, take 5 seconds to put sword back in place. Probably too long.
            /*
            transform.position = new Vector3(transform.position.x - transform.position.x / 2 + .53f,
                transform.position.y - transform.position.y / 2 + .87f,
                transform.position.z - transform.position.z / 2);
            */

            transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x / 2,
                transform.rotation.y,
                transform.rotation.z,
                transform.rotation.w);
            //So I need to figure out which axis I need to rotate around I assume X, so I'm
            //removing the rotation except for the X.
        }
        System.Random followUp = new System.Random();
        int follow = followUp.Next(score);
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
        float startTime = Time.deltaTime;
        //Put the enemy's sword position back to the default position.
        while (Time.deltaTime < startTime+5)
        {
            //Here, take 5 seconds to put sword back in place. Probably too long.
            transform.position = new Vector3(transform.position.x - transform.position.x/5 + .53f, 
                transform.position.y - transform.position.y/5+ .87f, 
                transform.position.z - transform.position.z/5);

            transform.rotation = new Quaternion(transform.rotation.x - transform.rotation.x/5,
                transform.rotation.y - transform.rotation.y/5,
                transform.rotation.z - transform.rotation.z/5,
                transform.rotation.w - transform.rotation.w/5);

        }
        //Reset position to normal position forcibly
        transform.position = new Vector3(.53f,.87f,0.0f);
        transform.rotation = new Quaternion(0.0f,0.0f,0.0f,0.0f);

    }
}
