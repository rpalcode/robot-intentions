using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class col : MonoBehaviour {
	Stopwatch watch = Stopwatch.StartNew();
	// Use this for initialization
	void Start () {
		//just in case if time scale is set to 0 for any reason
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//if the paths are 1 or 2, use 2 parameter Crash(), else use the single parameter Crash()
		Crash (10.0, 11.0);
	}
	//this script should have the robot move forward and backwards as if there was an error
	void Crash(double instance1)
	{
		//this would only happen once per scene in which the robot would be at risk of colliding
		if(Time.timeSinceLevelLoad == instance1)
		{
			//make robot move back and forth for a little while
			transform.Translate(0,-5*Time.deltaTime,0);
			transform.Translate(0,5*Time.deltaTime,0);
		}
	}

	void Crash(double instance1, double instance2)
	{
		//this would only happen twice per scene in which the robot would be at risk of colliding
		if(Time.timeSinceLevelLoad == instance1 || Time.timeSinceLevelLoad == instance2)
		{

		}
	}

}
