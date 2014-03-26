﻿using UnityEngine;
using System.Collections;

public class scene6 : MonoBehaviour {
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


    private void option3()
    {
        //print(counter);
        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

        timediff = Time.deltaTime - timediff;
        //print(timediff);

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }

        if (counter > 30 && counter < 65) { rightArrow(); }
        if (counter > 200 && counter < 320) { leftArrow(); }
        if (counter > 380 && counter < 450) { leftArrow(); }

        if (counter > 55 && counter < 70)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
        if (counter > 300 && counter < 320)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 430 && counter < 460)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

        if (counter >= 600)
        {
            Application.LoadLevel(2);
        }
    }


	// Use this for initialization

	void Start () {
        
	}

	// Update is called once per frame
	void Update () {

        option3();
	}
}