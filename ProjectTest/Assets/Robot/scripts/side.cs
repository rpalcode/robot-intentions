﻿using UnityEngine;
using System.Collections;

public class side : MonoBehaviour {
    public int counter = 0;
    public double timediff = 0.0;
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;

    void leftArrow()
    {
        straight.SetActive(false);
        left.SetActive(true);
        right.SetActive(false);
    }

    void upArrow()
    {
        straight.SetActive(true);
        left.SetActive(false);
        right.SetActive(false);
    }

    void rightArrow()
    {
        straight.SetActive(false);
        left.SetActive(false);
        right.SetActive(true);
    }

    void option1()
    {

    }

    void option3()
    {

    }

    void run()
    {
        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

        timediff = Time.deltaTime - timediff;
        //print(timediff);

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }

        if (counter>45 && counter<85) { rightArrow(); }
        if (counter>85 && counter<160) { leftArrow(); }
        if (counter > 160 && counter > 250) { upArrow(); }
        if (counter > 250 && counter < 395) { leftArrow(); }
        if (counter > 395 && counter < 460) { rightArrow(); } 

        if (counter > 75 && counter < 100)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
        if (counter > 125 && counter < 170)
         {
             transform.Rotate(0, 0, -45 * Time.deltaTime);
             transform.Translate(0, -5 * Time.deltaTime, 0);
         }
        if (counter > 340 && counter < 405)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 415 && counter < 470)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter>=500)
        {
            robot.rigidbody.velocity = Vector3.zero;
        }

    }
	// Use this for initialization
	void Start () {
        
	}

	// Update is called once per frame
	void Update () {
        run();
	}
}
