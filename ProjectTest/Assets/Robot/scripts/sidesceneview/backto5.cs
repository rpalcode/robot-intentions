﻿using UnityEngine;
using System.Collections;

public class backto5 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("0"))
        {
            Application.LoadLevel(7);
        }
        if (Input.GetKeyDown("9"))
        {
            Application.LoadLevel(9);
        }
	}
}