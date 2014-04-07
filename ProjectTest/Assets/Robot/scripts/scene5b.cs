using UnityEngine;
using System.Collections;
using System.IO;

public class scene5b : MonoBehaviour {
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;
	public Camera camera01;

	public GameObject one;
	public GameObject two;
	public GameObject three;

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


	void StartSide()
	{
		straight.SetActive(false);
		left.SetActive(false);
		right.SetActive(false);

		one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
	}


    void run()
    {


		StartSide();
		UnityEngine.Debug.Log("LEVEL = " + Application.loadedLevel);
		
		if ((Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 2.1) && stop1==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			camera01.enabled = false;
			stop1=1;
		}
		
		if ((Time.timeSinceLevelLoad > 4.8 && Time.timeSinceLevelLoad < 4.9) && stop2==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			camera01.enabled = false;
			stop2=1;
		}
		
		if ((Time.timeSinceLevelLoad > 10.8 && Time.timeSinceLevelLoad < 10.9) && stop3==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			camera01.enabled = false;
			stop3=1;
		}


        transform.Translate(0, -5 * Time.deltaTime, 0);

		if (Time.timeSinceLevelLoad > 0 && Time.timeSinceLevelLoad < 2)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
		}

		if (Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 3)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 5)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 5 && Time.timeSinceLevelLoad < 9)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 9 && Time.timeSinceLevelLoad < 11)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 14)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
		}
		
		if (Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 3)
		{
			transform.Rotate(0, 0, 90 * Time.deltaTime);
		}
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 5)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		if (Time.timeSinceLevelLoad > 9 && Time.timeSinceLevelLoad < 11)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 14)
		{
			transform.Rotate(0, 0, 45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		if (Time.timeSinceLevelLoad>=15)
		{
			if(Application.loadedLevel == 9)
			{
				using (StreamWriter writer = new StreamWriter("midpathmidarrowchest.txt"))
				{
					writer.WriteLine("mid-term view with map on screen");
					writer.WriteLine(res1 + " " + deltaDate1);
					writer.WriteLine(res2 + " " + deltaDate2);
					writer.WriteLine(res3 + " " + deltaDate3);
					writer.WriteLine(" ");
				}
			}
			
			if(Application.loadedLevel == 8)
			{
				using (StreamWriter writer = new StreamWriter("midpathmidarrowfloor.txt"))
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
				run ();
				
			}
			
		}
	}


	// Update is called once per frame
	void Update () {

        run();
	}
}
