﻿using UnityEngine;
using System.Collections;
using System.IO;

public class readData : MonoBehaviour {

	string[] line =new string[16];
	string[] text = new string[16];

	// Use this for initialization
	void Start () {
		//
		 line[1] = "longtermpathselect";
		 text[1] = System.IO.File.ReadAllText("longtermpathselect.txt");
		System.Console.WriteLine("{0}", text[1]);
		//
		 line[2] = "leftpathmidarrowfloor";
		 text[2] = System.IO.File.ReadAllText("leftpathmidarrowfloor.txt");
		System.Console.WriteLine("{0}", text[2]);
		//
		 line[3] = "midpathmidarrowfloor";
		 text[3] = System.IO.File.ReadAllText("midpathmidarrowfloor.txt");
		//
		 line[4] = "rightpathmidarrowfloor";
		 text[4] = System.IO.File.ReadAllText("rightpathmidarrowfloor.txt");
		//
		 line[5] = "leftrobotseye";
		 text[5] = System.IO.File.ReadAllText("leftrobotseye.txt");
		//
		 line[6] = "midrobotseye";
		 text[6] = System.IO.File.ReadAllText("midrobotseye.txt");
		//
		 line[7] = "rightrobotseye";
		 text[7] = System.IO.File.ReadAllText("rightrobotseye.txt");
		//
		 line[8] = "leftpathmidarrowchest";
		 text[8] = System.IO.File.ReadAllText("leftpathmidarrowchest.txt");
		//
		 line[9] = "midpathmidarrowchest";
		 text[9] = System.IO.File.ReadAllText("midpathmidarrowchest.txt");
		//
		 line[10] = "rightpathmidarrowchest";
		 text[10] = System.IO.File.ReadAllText("rightpathmidarrowchest.txt");
		//
		 line[11] = "leftpathshortarrowchest";
		 text[11] = System.IO.File.ReadAllText("leftpathshortarrowchest.txt");
		//
		 line[12] = "midpathshortarrowchest";
		 text[12] = System.IO.File.ReadAllText("midpathshortarrowchest.txt");
		//
		 line[13] = "rightpathshortarrowchest";
		 text[13] = System.IO.File.ReadAllText("rightpathshortarrowchest.txt");
		//
		 line[14] = "leftpathshortarrowfloor";
		 text[14] = System.IO.File.ReadAllText("leftpathshortarrowfloor.txt");
		//
		 line[15] = "midpathshortarrowfloor";
		 text[15] = System.IO.File.ReadAllText("midpathshortarrowfloor.txt");
		//
		 line[16] = "rightpathshortarrowfloor";
		 text[16] = System.IO.File.ReadAllText("rightpathshortarrowfloor.txt");
		//


	}

	
	// Update is called once per frame
	void Update () {
	
	}
}