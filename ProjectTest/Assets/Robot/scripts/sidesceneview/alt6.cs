﻿using UnityEngine;
using System.Collections;

public class alt6 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    if(Input.GetKeyDown("0"))
        {
            Application.LoadLevel(11);
        }
    if (Input.GetKeyDown("9"))
    {
        Application.LoadLevel(12);
    }


	}
	
}