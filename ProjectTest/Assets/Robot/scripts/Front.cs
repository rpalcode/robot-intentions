using UnityEngine;
using System.IO;
using System.Collections;

public class Front : MonoBehaviour {
	public Camera camera01;

	// Use this for initialization
	void Start () {
		using (StreamWriter writer = new StreamWriter("longtermpathselect.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("leftpathmidarrowfloor.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("midpathmidarrowfloor.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("rightpathmidarrowfloor.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("leftrobotseye.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("midrobotseye.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("rightrobotseye.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("leftpathmidarrowchest.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("midpathmidarrowchest.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("rightpathmidarrowchest.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("leftpathshortarrowchest.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("midpathshortarrowchest.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("rightpathshortarrowchest.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("leftpathshortarrowfloor.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("midpathshortarrowfloor.txt"))
		{ writer.WriteLine(" "); }
		using (StreamWriter writer = new StreamWriter("rightpathshortarrowfloor.txt"))
		{ writer.WriteLine(" "); }
	}
	
	// Update is called once per frame
	void Update () 
    {
		Time.timeScale=1;
		Debug.Log (Time.timeSinceLevelLoad);
        transform.Translate(0, -5*Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -90*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 90*Time.deltaTime);
        }


	}
}
