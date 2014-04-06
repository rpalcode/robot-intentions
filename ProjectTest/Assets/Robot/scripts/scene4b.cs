using UnityEngine;
using System.Collections;
//
//using System.Diagnostics;
//using System.Threading;
using System.IO;
//

public class scene4b : MonoBehaviour {
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;
	public Camera camera01;

	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;

	//

	public System.DateTime date1 = new System.DateTime(1996, 6, 3, 22, 15, 0);
	public System.DateTime date2 = new System.DateTime(1996, 12, 6, 13, 2, 0);
	public System.TimeSpan deltaDate1;
	public System.TimeSpan deltaDate2;
	public System.TimeSpan deltaDate3;

	
	public int stop1=0;
	public int stop2=0;
	public int stop3=0;

	public int pause=0;
	public string res1, res2, res3;

	//

	void StartSide()
	{
		straight.SetActive(false);
		left.SetActive(false);
		right.SetActive(false);

		one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
		four.SetActive(false);
	}
	

    private void option1()
    {

		StartSide ();

		//
		UnityEngine.Debug.Log("LEVEL = " + Application.loadedLevel);

		if ((Time.timeSinceLevelLoad > 1.5 && Time.timeSinceLevelLoad < 1.6) && stop1==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			camera01.enabled = false;
			stop1=1;
		}

		if ((Time.timeSinceLevelLoad > 12.8 && Time.timeSinceLevelLoad < 12.9) && stop2==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			camera01.enabled = false;
			stop2=1;
		}

		if ((Time.timeSinceLevelLoad > 14.8 && Time.timeSinceLevelLoad < 14.9) && stop3==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			camera01.enabled = false;
			stop3=1;
		}
		//

		if (Time.timeSinceLevelLoad > 0 && Time.timeSinceLevelLoad < 3)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 4)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 4 && Time.timeSinceLevelLoad < 13)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 14)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 14 && Time.timeSinceLevelLoad < 15)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 16.5)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(false);
			four.SetActive(true);
		}

		transform.Translate(0, -5 * Time.deltaTime, 0);

		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 4)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
        }

		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 14)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
		if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 16.5)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

		if (Time.timeSinceLevelLoad >= 16.5)
		{

			if(Application.loadedLevel == 0)
			{
				using (StreamWriter writer = new StreamWriter("leftpatharrowchest.txt"))
				{
					writer.WriteLine("mid-term view with map on screen");
					writer.WriteLine(res1 + " " + deltaDate1);
					writer.WriteLine(res2 + " " + deltaDate2);
					writer.WriteLine(res3 + " " + deltaDate3);
					writer.WriteLine(" ");
				}
			}
			
			if(Application.loadedLevel == 1)
			{
				using (StreamWriter writer = new StreamWriter("leftpatharrowfloor.txt"))
				{
					writer.WriteLine("mid-term view without map on screen");
					writer.WriteLine(res1 + " " + deltaDate1);
					writer.WriteLine(res2 + " " + deltaDate2);
					writer.WriteLine(res3 + " " + deltaDate3);
					writer.WriteLine(" ");
				}
			}
			
			Application.LoadLevel(2);
		}         
    }


	// Use this for initialization

	void Start () {
		Time.timeScale=1;
	}

	//
	void OnGUI()
	{
		if(pause==1)
		{
			int choice=0;

			GUI.Box(new Rect(150,350,300,100), "Which way is the robot going to go?\n(From robot's point of view)");
			
			if(GUI.Button(new Rect(150,400,100,50), "left")) 
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
			if(GUI.Button(new Rect(250,400,100,50), "forward")) 
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
			
			if(GUI.Button(new Rect(350,400,100,50), "right")) 
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
			if(choice==1)
			{
				date2 = System.DateTime.Now;
				UnityEngine.Debug.Log ("ELAPSED = " + (date2-date1));
				if(stop1 == 1 && stop2==0 && stop3==0) 
				{
					deltaDate1 = (date2-date1);
				}
				if(stop1 == 1 && stop2==1 && stop3==0)
				{
					deltaDate2 = (date2-date1);
				}
				if(stop1 == 1 && stop2==1 && stop3==1)
				{
					deltaDate3 = (date2-date1);
				}
				camera01.enabled = true;
				Time.timeScale =1;
				pause=0;
				option1 ();

			}

		}
	}

	//

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("8"))
		{
			Application.LoadLevel(4);
		}
		if (Input.GetKeyDown("9"))
		{
			Application.LoadLevel(5);
		}
		if (Input.GetKeyDown("0"))
		{
			Application.LoadLevel(6);
		}
        option1();
	}
}
