using UnityEngine;
using System.Collections;
using System.IO;

public class scene5 : MonoBehaviour {
	//this class is used for short term view for path 2
	Texture leftarrows;
	Texture rightarrows;
	Texture uparrows;

	public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;
	
	public System.DateTime date1 = new System.DateTime(1900, 1, 1, 11, 11, 0);
	public System.DateTime date2 = new System.DateTime(1900, 11, 1, 11, 11, 0);
	public System.TimeSpan deltaDate1;
	public System.TimeSpan deltaDate2;
	public System.TimeSpan deltaDate3;
	public GameObject rift;

	//set a variable position for the GUI
	public int xpos = 170;
	public int ypos = 100;
	public int xsize = 240;
	public int ysize = 80;

	public int stop1=0;
	public int stop2=0;
	public int stop3=0;
	
	public int pause=0;
	public string res1, res2, res3;

	public string conf1 = " ";
	public string conf2 = " ";
	public string conf3 = " ";
	

    void leftArrow()
    {
        straight.SetActive(false);
        left.SetActive(true);
        right.SetActive(false);
    }

    void upArrow()
    {
        straight.SetActive(true);
        left.SetActive(false);
        right.SetActive(false);
    }

    void rightArrow()
    {
        straight.SetActive(false);
        left.SetActive(false);
        right.SetActive(true);
    }


    private void run()
    {

        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

		if ((Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 2.1) && stop1==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			rift.SetActive(true);
			stop1=1;
		}
		
		if ((Time.timeSinceLevelLoad > 5.1 && Time.timeSinceLevelLoad < 5.2) && stop2==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			rift.SetActive(true);
			stop2=1;
		}
		
		if ((Time.timeSinceLevelLoad > 10.8 && Time.timeSinceLevelLoad < 10.9) && stop3==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			rift.SetActive(true);
			stop3=1;
		}

		if (Time.timeSinceLevelLoad > .7 && Time.timeSinceLevelLoad < 2) { rightArrow(); }
		if (Time.timeSinceLevelLoad> 2 && Time.timeSinceLevelLoad<5) { leftArrow(); }
		if (Time.timeSinceLevelLoad > 5 && Time.timeSinceLevelLoad > 7) { upArrow(); }
		if (Time.timeSinceLevelLoad > 8 && Time.timeSinceLevelLoad < 11) { leftArrow(); }
		if (Time.timeSinceLevelLoad > 10 && Time.timeSinceLevelLoad < 12) { rightArrow(); } 
		
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
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 18)
		{
			transform.Rotate(0, 0, 45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}

		int right1=0; int right2=0; int right3=0;
		if(res1 == "right")
			right1 = 1;
		if(res2 == "forward")
			right2 = 1;
		if(res3 == "right")
			right3 = 1;

		if (Time.timeSinceLevelLoad>=15)
		{
			if(Application.loadedLevel == 11)
			{
				using (StreamWriter writer = new StreamWriter("midpathshortarrowchest.txt"))
				{
					writer.WriteLine("mid-term view with arrow on screen");
					writer.WriteLine("Picked " + res1 + " with a confidence of " + conf1 + " with a time of " + deltaDate1 + " " + right1);
					writer.WriteLine("Picked " + res2 + " with a confidence of " + conf2 + " with a time of " + deltaDate2 + " " + right2);
					writer.WriteLine("Picked " + res3 + " with a confidence of " + conf3 + " with a time of " + deltaDate3 + " " + right3);
					writer.WriteLine(" ");
				}
			}
			
			if(Application.loadedLevel == 10)
			{
				using (StreamWriter writer = new StreamWriter("midpathshortarrowfloor.txt"))
				{
					writer.WriteLine("mid-term view with arrow on floor");
					writer.WriteLine("Picked " + res1 + " with a confidence of " + conf1 + " with a time of " + deltaDate1 + " " + right1);
					writer.WriteLine("Picked " + res2 + " with a confidence of " + conf2 + " with a time of " + deltaDate2 + " " + right2);
					writer.WriteLine("Picked " + res3 + " with a confidence of " + conf3 + " with a time of " + deltaDate3 + " " + right3);
					writer.WriteLine(" ");;
				}
			}

			Application.LoadLevel(2);
		}
		
	}
	// Use this for initialization
	
	void Start () {
		Time.timeScale=1;

		leftarrows = (Texture)Resources.Load("leftarrow");
		rightarrows = (Texture)Resources.Load("rightarrow");
		uparrows = (Texture)Resources.Load("uparrow");

		left.renderer.material.color = Color.yellow;
		right.renderer.material.color = Color.yellow;
		straight.renderer.material.color = Color.yellow;
	}
	void OnGUI()
	{
		if(pause==1)
		{
			int choice=0;
			
			//GUI.Box(new Rect(170,250,240,100), "");
			//
			if(stop1 == 1 && stop2==0 && stop3==0) 
			{
				GUI.Box(new Rect(170,350,240,100), "From a scale of 1-7\nhow confident are you?");
				conf1 = GUI.TextField(new Rect(270,   400, 30, 25), conf1, 250);
			}
			if(stop1 == 1 && stop2==1 && stop3==0)
			{
				GUI.Box(new Rect(170,350,240,100), "From a scale of 1-7\nhow confident are you?");
				conf2 = GUI.TextField(new Rect(270,   400, 30, 25), conf2, 250);
			}
			if(stop1 == 1 && stop2==1 && stop3==1)
			{
				GUI.Box(new Rect(170,350,240,100), "From a scale of 1-7\nhow confident are you?");
				conf3 = GUI.TextField(new Rect(270,   400, 30, 25), conf3, 250);
			}
			
			//
			if(GUI.Button(new Rect(170,300,80,50), leftarrows)) 
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
			if(GUI.Button(new Rect(250,300,80,50), uparrows)) 
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
			
			if(GUI.Button(new Rect(330,300,80,50), rightarrows)) 
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
			int enter = 0;
			if(enter==0) 
			{ 
				if(GUI.Button(new Rect(170, 450, 240, 25), "Enter")) { enter=1; choice=1; } 
			}
			//UnityEngine.Debug.Log ("ENTER = " + enter + " and choice = " + choice);
			

			if(choice==1 && enter==1)
			{
				date2 = System.DateTime.Now;
				//UnityEngine.Debug.Log ("ELAPSED = " + (date2-date1));
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
				rift.SetActive(false);
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
