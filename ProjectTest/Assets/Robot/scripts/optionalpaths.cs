using UnityEngine;
using System.Collections;

public class optionalpaths : MonoBehaviour {
	public GameObject red;
	public GameObject blue;
	public GameObject green;
	public GameObject map;
	public int path=0;
	public Camera camera01;
	public int pause;
   
	void Start () {
		red.SetActive(false);
		blue.SetActive(false);
		green.SetActive(false);
		map.SetActive(false);
		Time.timeScale=0;
	}

	// Update is called once per frame

	void OnGUI()
	{
		if(Time.timeSinceLevelLoad>3)
		{
			camera01.enabled = false;
			pause = 1;
			
		}
		if(pause==1)
		{

			
			GUI.Box(new Rect(150,350,300,100), "Which way is the robot going to go?\n(From robot's point of view)");
			
			if(GUI.Button(new Rect(150,400,100,50), "left")) 
			{
				Application.LoadLevel(16);
				
			}
			if(GUI.Button(new Rect(250,400,100,50), "forward")) 
			{
				Application.LoadLevel(17);

			}
			
			if(GUI.Button(new Rect(350,400,100,50), "right")) 
			{
				Application.LoadLevel(18);

			}
			/*
			GUI.Box(new Rect(150+500,350,300,100), "Which way is the robot going to go?\n(From robot's point of view)");
			
			if(GUI.Button(new Rect(150+500,400,100,50), "left")) 
			{
				if(stop1 == 1 && stop2==0 && stop3==0) 
				{
					res1 = "left";
				}
				if(stop1 == 1 && stop2==1 && stop3==0)
				{
					res2 = "left";
				}
				if(stop1 == 1 && stop2==1 && stop3==1)
				{
					res3 = "left";
				}
				choice=1;

			}
			if(GUI.Button(new Rect(250+500,400,100,50), "forward")) 
			{
				if(stop1 == 1 && stop2==0 && stop3==0) 
				{
					res1 = "forward";
				}
				if(stop1 == 1 && stop2==1 && stop3==0)
				{
					res2 = "forward";
				}
				if(stop1 == 1 && stop2==1 && stop3==1)
				{
					res3 = "forward";
				}
				choice=1;
			}
			
			if(GUI.Button(new Rect(350+500,400,100,50), "right")) 
			{
				if(stop1 == 1 && stop2==0 && stop3==0) 
				{
					res1 = "right";
				}
				if(stop1 == 1 && stop2==1 && stop3==0)
				{
					res2 = "right";
				}
				if(stop1 == 1 && stop2==1 && stop3==1)
				{
					res3 = "right";
				}
				choice=1;
			}
*/

				

			
		}
	}


	void Update () {
		//rotate camera
		Debug.Log(Time.timeSinceLevelLoad);
		//change paths
		int choice=0;
		if (Input.GetKeyDown("e"))
		{
			choice=1;
		}
		if (Input.GetKeyDown("d"))
		{
			choice=2;
		}
		if (Input.GetKeyDown("c"))
		{
			choice=3;
		}


		if (Input.GetKeyDown("e") || Input.GetKeyDown("d") || Input.GetKeyDown("c"))
		{
			path=1;
		}
		if(path==1)
		{
			if(choice==1)
			{
			red.SetActive(true);
			blue.SetActive(false);
			green.SetActive(false);
			map.SetActive(false);
			Time.timeScale=1;

			if(Time.timeSinceLevelLoad>3)
			{
				camera01.enabled = false;
				pause = 1;

			}

			}
			if(choice==2)
			{
				red.SetActive(false);
				blue.SetActive(false);
				green.SetActive(true);
				map.SetActive(false);
				Time.timeScale=1;

				if(Time.timeSinceLevelLoad>3)
				{
					camera01.enabled = false;
					pause = 1;
				}

			}
			if(choice==3)
			{
				red.SetActive(false);
				green.SetActive(false);
				blue.SetActive(true);
				map.SetActive(false);
				Time.timeScale=1;

				if(Time.timeSinceLevelLoad>3)
				{
					camera01.enabled = false;
					pause = 1;
					
				}

			}

		}

		/* if (Input.GetKeyUp("w"))
		{
			red.SetActive(false);
			green.SetActive(false);
			blue.SetActive(false);
			map.SetActive(true);
			Time.timeScale=1;
			if(Time.timeSinceLevelLoad>5)
			{
				camera01.enabled = false;
			}
		}
*/ 
		//load levels

        if (Input.GetKeyDown("9"))
        {
            Application.LoadLevel(2);
        }
		if (Input.GetKeyDown("0"))
		{
			Application.LoadLevel(3);
		}

	}

}