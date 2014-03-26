﻿using UnityEngine;
using System.Collections;

public class scene5 : MonoBehaviour {
    private int counter = 0;
    public double timediff = 0.0;
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;

    public int choice;


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


    private void run()
    {
        //print(counter);
        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

		float a = Time.time;

        if (counter>45 && counter<85) { rightArrow(); }
        if (counter>85 && counter<160) { leftArrow(); }
        if (counter > 160 && counter > 250) { upArrow(); }
        if (counter > 220 && counter < 290) { leftArrow(); }
        if (counter > 290 && counter < 415) { rightArrow(); } 

        if (counter > 75 && counter < 100)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
        if (counter > 125 && counter < 170)
         {
             transform.Rotate(0, 0, -45 * Time.deltaTime);
             transform.Translate(0, -5 * Time.deltaTime, 0);
         }
        if (counter > 270 && counter < 325)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 350 && counter < 405)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter>=500)
        {
            Application.LoadLevel(2);
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