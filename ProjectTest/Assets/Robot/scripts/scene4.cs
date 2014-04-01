﻿using UnityEngine;
using System.Collections;

public class scene4 : MonoBehaviour {
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;
	public Camera camera01;

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
		if (Input.GetKeyDown("p"))
		{
			Time.timeScale =0;
			camera01.enabled = false;
		}
		if (Input.GetKeyDown("o"))
		{
			camera01.enabled = true;
			
			Time.timeScale =1;
		}

		Debug.Log(Time.timeSinceLevelLoad);

		transform.Translate(0, -5 * Time.deltaTime, 0);
        upArrow();
		if (Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 4) { leftArrow(); }
		if (Time.timeSinceLevelLoad > 4 && Time.timeSinceLevelLoad > 8) { upArrow(); }
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 14) { rightArrow(); }
		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 17) { rightArrow(); }

		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 4)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
        }

		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 14)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
		if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 17)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

		if (Time.timeSinceLevelLoad >= 18.5)
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
		if (Input.GetKeyDown("8"))
		{
			Application.LoadLevel(4);
		}
		if (Input.GetKeyDown("9"))
		{
			Application.LoadLevel(5);
		}
		if (Input.GetKeyDown("0"))
		{
			Application.LoadLevel(6);
		}
        option1();
	}
}
