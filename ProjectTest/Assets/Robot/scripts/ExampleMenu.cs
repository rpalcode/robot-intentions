/*
using UnityEngine;
using System.Collections;

public class ExampleMenu : VRGUI 
{
	public override void OnVRGUI()
	{



		GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));

		if(scene4b.pause==1)
		{
			int choice=0;
			
			GUILayout.Button(new Rect(200,350,300,100), "Which way is the robot going to go?\n(From robot's point of view)");
			
			if(GUILayout.Button(new Rect(200,400,100,50), "left")) 
			{
				choice=1;
			}
			if(GUILayout.Button(new Rect(300,400,100,50), "forward")) 
			{
				choice=1;
			}
			
			if(GUILayout.Button(new Rect(400,400,100,50), "right")) 
			{
				choice=1;
			}
			
			if(choice==1)
			{
				scene4b.date2 = System.DateTime.Now;
				UnityEngine.Debug.Log ("ELAPSED = " + (scene4b.date2-scene4b.date1));
				
				//UnityEngine.Debug.Log ("TIME = " + timee);
				
				camera01.enabled = true;
				Time.timeScale =1;
				scene4b.pause=0;
				scene4b.option1 ();
				
			}
			
		}

		GUILayout.EndArea();
	}
}

*/