using UnityEngine;
using System.Collections;
using System.IO;

public class complete : MonoBehaviour {
	public string userResponse = "What did you think of the robot?";
	public string userResponse2 = "What do you want to change about the robot so that you would like it more?";
	// Use this for initialization
	void Start () {
	
	}

	void OnGUI()
	{
		//GUI.Box(new Rect(150,350,300,100), "What did you think of the robot?");
		//GUI.Box(new Rect(150+500,350,300,100), "What did you think of the robot?");

		userResponse = GUI.TextField(new Rect(100,     350, 500, 150), userResponse, 250);
		//userResponse = GUI.TextField(new Rect(100+600, 350, 500, 150), userResponse, 250);
		userResponse2 = GUI.TextField(new Rect(100,    500, 500, 150), userResponse2, 250);
		//userResponse2 = GUI.TextField(new Rect(100+600, 500, 500, 150), userResponse2, 250);

	}

	// Update is called once per frame
	void Update () {
		using (StreamWriter writer = new StreamWriter("surveyfinalquestions.txt"))
		{
			writer.WriteLine("what did you think of the robot?");
			writer.WriteLine(userResponse);
			writer.WriteLine("What do you want to change about the robot so that you would like it more?");
			writer.WriteLine(userResponse2);
			writer.WriteLine(" ");
		}

		if(Input.GetKeyDown("a"))
		{
			Application.LoadLevel(20);
		}

	}
}
