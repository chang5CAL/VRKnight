using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuelScript : MonoBehaviour {
    /// <summary>
    /// This one controls the enemy's AI in duel mode. 
    /// What if does is basically have a block animation
    /// when attacked, UNLESS staggered. If one of the
    /// enemy's attack is blocked, they stagger.
    /// They also have randomized attacks, like in
    /// offense script.
    /// </summary>
    bool isActive;
    int chain;
    int followUp;
    bool coolDown;
    public int score;
    float timeActive;

    // Use this for initialization
    void Start()
    {
        isActive = false;
        coolDown = false; //If the player is hit, set to true.
        chain = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int rand;
        System.Random rnd = new System.Random();
        if (coolDown)
        {
            coolDown = false;
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
        } else
        {
            if (timeActive < Time.time+5)
            {
                coolDown = true;
            }
        }
        isActive = false;
        timeActive = Time.time;
    }
    void SlashLeft()
    {

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
        score += 2;
        int rand;
        System.Random rnd = new System.Random();
        rand = rnd.Next(3);
        if (rand == 0)
        {
            //Thrust High
        }
        else if (rand == 1)
        {
            //Thrust Mid
        }
        else
        {
            //Thrust Low
        }


        System.Random followUp = new System.Random();
        int follow = followUp.Next(score);
        if (follow > chain * 3)
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
        score += 2;
        System.Random followUp = new System.Random();
        int follow = followUp.Next(score);
        if (follow > chain * 3)
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
        score += 2;

        System.Random followUp = new System.Random();
        int follow = followUp.Next(score);
        if (follow > chain * 3)
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
