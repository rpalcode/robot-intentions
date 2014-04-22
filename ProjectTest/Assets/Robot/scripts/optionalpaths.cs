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

	int r=0; int b=0; int g=0;

	public System.DateTime date1 = new System.DateTime(1996, 6, 3, 22, 15, 0);
	public System.DateTime date2 = new System.DateTime(1996, 12, 6, 13, 2, 0);
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
		if(Time.timeSinceLevelLoad>3)
		{
			//camera01.enabled = false;
			rift.SetActive(false);

			pause = 1;
			date1 = System.DateTime.Now;
		}
		if(pause==1)
		{

			GUI.Box(new Rect(150,350,300,100), "Which way is the robot going to go?\n(From robot's point of view)");
			
			if(GUI.Button(new Rect(150,400,100,50), "1")) 
			{
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				UnityEngine.Debug.Log ("ELAPSED = " + (deltaDate1));

				using (StreamWriter writer = new StreamWriter("longtermpathselect.txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("1 " + deltaDate1);
					writer.WriteLine(" ");
				}

				if(r==1)
				{
					Application.LoadLevel(16);
				}
				if(b==1)
				{
					Application.LoadLevel(18);
				}
				if(g==1)
				{
					Application.LoadLevel(17);
				}
			}
			if(GUI.Button(new Rect(250,400,100,50), "2")) 
			{
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				UnityEngine.Debug.Log ("ELAPSED = " + (deltaDate1));
				
				using (StreamWriter writer = new StreamWriter("longtermpathselect.txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("2 " + deltaDate1);
					writer.WriteLine(" ");
				}
				if(r==1)
				{
					Application.LoadLevel(16);
				}
				if(b==1)
				{
					Application.LoadLevel(18);
				}
				if(g==1)
				{
					Application.LoadLevel(17);
				}
			}
			
			if(GUI.Button(new Rect(350,400,100,50), "3")) 
			{
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				UnityEngine.Debug.Log ("ELAPSED = " + (deltaDate1));
				
				using (StreamWriter writer = new StreamWriter("longtermpathselect.txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("3 " + deltaDate1);
					writer.WriteLine(" ");
				}
				if(r==1)
				{
					Application.LoadLevel(16);
				}
				if(b==1)
				{
					Application.LoadLevel(18);
				}
				if(g==1)
				{
					Application.LoadLevel(17);
				}
			}
/*
		GUI.Box(new Rect(150+500,350,300,100), "Which way is the robot going to go?\n(From robot's point of view)");
			
			if(GUI.Button(new Rect(150+500,400,100,50), "1")) 
			{
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				UnityEngine.Debug.Log ("ELAPSED = " + (deltaDate1));

				using (StreamWriter writer = new StreamWriter("longtermpathselect.txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("1 " + deltaDate1);
					writer.WriteLine(" ");
				}

				if(r==1)
				{
					Application.LoadLevel(16);
				}
				if(b==1)
				{
					Application.LoadLevel(18);
				}
				if(g==1)
				{
					Application.LoadLevel(17);
				}
			}
			if(GUI.Button(new Rect(250+500,400,100,50), "2")) 
			{
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				UnityEngine.Debug.Log ("ELAPSED = " + (deltaDate1));
				
				using (StreamWriter writer = new StreamWriter("longtermpathselect.txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("2 " + deltaDate1);
					writer.WriteLine(" ");
				}

				if(r==1)
				{
					Application.LoadLevel(16);
				}
				if(b==1)
				{
					Application.LoadLevel(18);
				}
				if(g==1)
				{
					Application.LoadLevel(17);
				}
			}
			
			if(GUI.Button(new Rect(350+500,400,100,50), "3")) 
			{
				date2 = System.DateTime.Now;
				deltaDate1 = (date2-date1);
				UnityEngine.Debug.Log ("ELAPSED = " + (deltaDate1));
				
				using (StreamWriter writer = new StreamWriter("longtermpathselect.txt"))
				{
					writer.WriteLine("initial longterm path select");
					writer.WriteLine("3 " + deltaDate1);
					writer.WriteLine(" ");
				}

				if(r==1)
				{
					Application.LoadLevel(16);
				}
				if(b==1)
				{
					Application.LoadLevel(18);
				}
				if(g==1)
				{
					Application.LoadLevel(17);
				}
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
			r=1;
			blue.SetActive(false);
			green.SetActive(false);
			Time.timeScale=1;

			if(Time.timeSinceLevelLoad>3)
			{
				//camera01.enabled = false;
				rift.SetActive(false);
				pause = 1;

			}

			}
			if(choice==2)
			{
				red.SetActive(false);
				blue.SetActive(false);
				green.SetActive(true);
				g=1;
				Time.timeScale=1;

				if(Time.timeSinceLevelLoad>3)
				{
					//camera01.enabled = false;
					rift.SetActive(false);
					pause = 1;
				}

			}
			if(choice==3)
			{
				red.SetActive(false);
				green.SetActive(false);
				blue.SetActive(true);
				b=1;
				Time.timeScale=1;

				if(Time.timeSinceLevelLoad>3)
				{
					//camera01.enabled = false;
					rift.SetActive(false);
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

	}

}