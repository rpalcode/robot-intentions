using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.IO;

public class col : MonoBehaviour {

	Stopwatch watch = Stopwatch.StartNew();

	public GameObject straight;
	public GameObject left;
	public GameObject right;
	public GameObject robot;
	
	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;
	
	public GameObject rift;

	// Use this for initialization
	void Start () {
		//just in case if time scale is set to 0 for any reason
		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
		PathOne ();
	}
	//this script should have the robot move forward and backwards as if there was an error
	void Crash(double instance1)
	{
		//this would only happen once per scene in which the robot would be at risk of colliding
		if(Time.timeSinceLevelLoad == instance1)
		{
			UnityEngine.Debug.Log("robot is going to collide!!1");
			//make robot move back and forth for a little while
			//transform.Translate(0,-5*Time.deltaTime,0);
			//transform.Translate(0,5*Time.deltaTime,0);
		}
	}

	public void Crash(double instance1, double instance2)
	{
		UnityEngine.Debug.Log("Time = " + Time.timeSinceLevelLoad + " !! :D");
		//this would only happen twice per scene in which the robot would be at risk of colliding
		if(Time.timeSinceLevelLoad > instance1 && Time.timeSinceLevelLoad < instance1 + 10)
		{
			UnityEngine.Debug.Log("robot is going to collide!!1");
			//transform.Translate(0,5*Time.deltaTime,0);
			//transform.Translate(0,5*Time.deltaTime,0);
		}
	}

	//scene for robot going to first path
	public void PathOne()
	{

		//if the paths are 1 or 2, use 2 parameter Crash(), else use the single parameter Crash()
		Crash (3.0, 11.0);

		transform.Translate(0, -5 * Time.deltaTime, 0);

		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 4)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
			//transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		
		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 14)
		{
			//transform.Rotate(0, 0, 45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 16.25)
		{
			//transform.Rotate(0, 0, -45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}


		if(Time.timeSinceLevelLoad >= 16.25)
		{
			using (StreamWriter writer = new StreamWriter("leftpathcollide.txt"))
			{
				writer.WriteLine("collision checker");
				//writer.WriteLine("Picked " + res1 + " with a confidence of " + conf1 + " with a time of " + deltaDate1 + " " + right1);
				writer.WriteLine(" ");
			}
		}
	}

}
