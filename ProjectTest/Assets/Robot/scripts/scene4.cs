﻿using UnityEngine;
using System.Collections;

public class scene4 : MonoBehaviour {
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

    private void option1()
    {
       // print(counter);
        transform.Translate(0, -5 * Time.deltaTime, 0);
        timediff = Time.deltaTime - timediff;
        //print(timediff);
        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }
        upArrow();
        if (counter > 20 && counter < 50) { leftArrow(); }
       // if (counter > 85 && counter < 120) { rightArrow(); }
        if (counter > 120 && counter > 250) { upArrow(); }
        if (counter > 180 && counter < 325) { rightArrow(); }
        if (counter > 325 && counter < 370) { rightArrow(); }

        if (counter > 45 && counter < 75)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
        }

        if (counter > 220 && counter < 240)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 330 && counter < 380)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

        if (counter >= 430)
        {
            Application.LoadLevel(2);
        }        
    }


	// Use this for initialization

	void Start () {
        //counter = 0;
	}

	// Update is called once per frame
	void Update () {

        option1();
	}
}