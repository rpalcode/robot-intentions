using UnityEngine;
using System.Collections;
using System.IO;

public class readData : MonoBehaviour {

	string[] line =new string[22];
	string[] text = new string[22];

	// Use this for initialization
	void Start () {
		line[0] = "longtermpathselect from side";
		text[0] = System.IO.File.ReadAllText("longtermpathselect2.txt");
		//
		 line[1] = "longtermpathselect from robot's eye view";
		 text[1] = System.IO.File.ReadAllText("longtermpathselect.txt");
		//
		 line[2] = "leftpathmidarrowfloor";
		 text[2] = System.IO.File.ReadAllText("leftpathmidarrowfloor.txt");
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
		line[17] = "leftpathnoarrowrobotseye";
		text[17] = System.IO.File.ReadAllText("leftpathnoarrowrobotseye.txt");	
		//
		line[18] = "leftpathcollide";
		text[18] = System.IO.File.ReadAllText("leftcollide.txt");	
		//
		line[19] = "midrobotseyenoarrow";
		text[19] = System.IO.File.ReadAllText("midrobotseyenoarrow.txt");
		//
		line[20] = "rightrobotseyenoarrow";
		text[20] = System.IO.File.ReadAllText("rightrobotseyenoarrow.txt");	
		//
		line[21] = "surveyfinalquestions";
		text[21] = System.IO.File.ReadAllText("surveyfinalquestions.txt");
	

		string fileName = ("Results_for_" + side.username + ".txt");

		using (StreamWriter writer = new StreamWriter(fileName))
		{
			for(int i=0; i<22; i++)
			{
				writer.WriteLine(line[i]);
				writer.WriteLine(text[i]);
		
			}
		}

	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
