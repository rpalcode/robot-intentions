using UnityEngine;
using System.Collections;
using System.IO;


public class optionalpaths : MonoBehaviour {

	public GameObject red;
	public GameObject blue;
	public GameObject green;
	//public GameObject map;
	public GameObject rift;

	public int path=0;
	public Camera camera01;
	public int pause;

	public bool timed = false;

	public 	int choice=0;

	public string conf = " ";

	int left=0; int mid=0; int right=0;

	public System.DateTime date1 = new System.DateTime(2000, 1, 1, 1, 1, 0);
	public System.DateTime date2 = new System.DateTime(2000, 1, 1, 1, 1, 0);
	public System.TimeSpan deltaDate1;

	public GameObject holo;


	void Start () {
		red.SetActive(false);
		blue.SetActive(false);
		green.SetActive(false);
		//map.SetActive(false);
		holo.SetActive(false);
		Time.timeScale=0;

	}

	// Update is called once per frame

	void OnGUI()
	{


		if(Time.timeSinceLevelLoad>3 && pause != 1)
		{
			//camera01.enabled = false;

			rift.SetActive(true);
			pause = 1;
		}
		if(pause==1)
		{
			//changes 6-12
			string txtFile = " ";
			if(Application.loadedLevel == 2)
				txtFile = "longtermpathselect";
			if(Application.loadedLevel == 3)
				txtFile = "longtermpathselect2";
			// /changes 6-12
			//GUI.Box(new Rect(150,350,300,100), "Which way is the robot going to go?\n(From robot's point of view)");
			//GUI.Box(new Rect(150,300,300,100), robotintent);
			GUI.Box(new Rect(250,450,150,100), "From a scale of 1-7\nhow confident are you?");
			conf = GUI.TextField(new Rect(310,   500, 30, 25), conf, 250);

			if(GUI.Button(new Rect(250,400,50,50), "1")) 
			{
				Debug.Log("clicked!");
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				Debug.Log("time = " + date1 + "->" + date2 + "->" + deltaDate1 + "!");
				int check = 0; if(choice == 1) { check = 1; }

				using (StreamWriter writer = new StreamWriter(txtFile + ".txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("1 " + deltaDate1 + " " + check + " with a confidence of " + conf);
					writer.WriteLine(" ");
				}
				LaunchLevel();
				/*
				if(left==1)
				{
					Application.LoadLevel(16);
				}
				if(mid==1)
				{
					Application.LoadLevel(17);
				}
				if(right==1)
				{
					Application.LoadLevel(18);
				}
				*/
			}
			if(GUI.Button(new Rect(300,400,50,50), "2")) 
			{
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				int check = 0; if(choice == 2) { check = 1; }

				using (StreamWriter writer = new StreamWriter(txtFile + ".txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("2 " + deltaDate1 + " " + check + " with a confidence of " + conf);
					writer.WriteLine(" ");
				}
				LaunchLevel();
				/*
				if(left==1)
				{
					Application.LoadLevel(16);
				}
				if(mid==1)
				{
					Application.LoadLevel(17);
				}
				if(right==1)
				{
					Application.LoadLevel(18);
				}
				*/
			}
			
			if(GUI.Button(new Rect(350,400,50,50), "3")) 
			{
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				int check = 0; if(choice == 3) { check = 1; }

				using (StreamWriter writer = new StreamWriter(txtFile + ".txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("3 " + deltaDate1 + " " + check + " with a confidence of " + conf);
					writer.WriteLine(" ");
				}
				LaunchLevel();
				/*
				if(left==1)
				{
					Application.LoadLevel(16);
				}
				if(mid==1)
				{
					Application.LoadLevel(17);
				}
				if(right==1)
				{
					Application.LoadLevel(18);
				}
				*/
			}
				

			
		}
	}

	void LaunchLevel()
	{
		if(left==1)
		{
			if(Application.loadedLevel == 2)
			   Application.LoadLevel(16);
			else if(Application.loadedLevel == 3)
				Application.LoadLevel(5);
		}
		if(mid==1)
		{
			if(Application.loadedLevel == 2)
				Application.LoadLevel(18);
			else if(Application.loadedLevel == 3)
				Application.LoadLevel(9);
		}
		if(right==1)
		{
			if(Application.loadedLevel == 2)
				Application.LoadLevel(17);
			else if(Application.loadedLevel == 3)
				Application.LoadLevel(13);
		}
			
	}


	void Update () {
		//rotate camera
		//Debug.Log(Time.timeSinceLevelLoad);
		//change paths
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
			if(Application.loadedLevel != 3)
			{ 
				holo.SetActive(true);
			}
		}
		if(path==1)
		{
			if(choice==1)
			{
			red.SetActive(true);
			left=1; 
			blue.SetActive(false);
			green.SetActive(false);
			Time.timeScale=1;

			if(Time.timeSinceLevelLoad>3)
			{
				rift.SetActive(true);
				pause = 1;

			}

			}
			if(choice==2)
			{
				red.SetActive(false);
				blue.SetActive(false);
				green.SetActive(true);
				mid=1;
				Time.timeScale=1;

				if(Time.timeSinceLevelLoad>3)
				{
					rift.SetActive(true);
					pause = 1;
				}

			}
			if(choice==3)
			{
				red.SetActive(false);
				green.SetActive(false);
				blue.SetActive(true);
				right=1;
				Time.timeScale=1;

				if(Time.timeSinceLevelLoad>3)
				{
					rift.SetActive(true);
					pause = 1;
					
				}

			}

		}

 
		//load levels

        if (Input.GetKeyDown("9"))
        {
            Application.LoadLevel(2);
        }
		if (Input.GetKeyDown("0"))
		{
			Application.LoadLevel(3);
		}

		TakeTime();

	}

	//do a more percise time calculation
	void TakeTime()
	{
		if(rift.activeSelf && !timed) 
		{ date1 = System.DateTime.Now; Debug.Log("date1 = " + date1); timed = true; }

	}


}