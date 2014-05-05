using UnityEngine;
using System.Collections;
using System.IO;

public class readData : MonoBehaviour {

	string line [16];
	string text [16];

	// Use this for initialization
	void Start () {
		//
		string line[1] = "longtermpathselect";
		string text[1] = System.IO.File.ReadAllText("longtermpathselect.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[2] = "leftpathmidarrowfloor";
		string text[2] = System.IO.File.ReadAllText("leftpathmidarrowfloor.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[3] = "midpathmidarrowfloor";
		string text[3] = System.IO.File.ReadAllText("midpathmidarrowfloor.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[4] = "rightpathmidarrowfloor";
		string text[4] = System.IO.File.ReadAllText("rightpathmidarrowfloor.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[5] = "leftrobotseye";
		string text[5] = System.IO.File.ReadAllText("leftrobotseye.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[6] = "midrobotseye";
		string text[6] = System.IO.File.ReadAllText("midrobotseye.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[7] = "rightrobotseye";
		string text[7] = System.IO.File.ReadAllText("rightrobotseye.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[8] = "leftpathmidarrowchest";
		string text[8] = System.IO.File.ReadAllText("leftpathmidarrowchest.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[9] = "midpathmidarrowchest";
		string text[9] = System.IO.File.ReadAllText("midpathmidarrowchest.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[10] = "rightpathmidarrowchest";
		string text[10] = System.IO.File.ReadAllText("rightpathmidarrowchest.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[11] = "leftpathshortarrowchest";
		string text[11] = System.IO.File.ReadAllText("leftpathshortarrowchest.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[12] = "midpathshortarrowchest";
		string text[12] = System.IO.File.ReadAllText("midpathshortarrowchest.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[13] = "rightpathshortarrowchest";
		string text[13] = System.IO.File.ReadAllText("rightpathshortarrowchest.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[14] = "leftpathshortarrowfloor";
		string text[14] = System.IO.File.ReadAllText("leftpathshortarrowfloor.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[15] = "midpathshortarrowfloor";
		string text[15] = System.IO.File.ReadAllText("midpathshortarrowfloor.txt");
		System.Console.WriteLine("{0}", text);
		//
		string line[16] = "rightpathshortarrowfloor";
		string text[16] = System.IO.File.ReadAllText("rightpathshortarrowfloor.txt");
		System.Console.WriteLine("{0}", text);
		//
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
