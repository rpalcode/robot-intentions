using UnityEngine;
using System.Collections;
using System.IO;

public class scene5 : MonoBehaviour {
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;
	public Camera camera01;

    public int choice;

	public System.DateTime date1 = new System.DateTime(1996, 6, 3, 22, 15, 0);
	public System.DateTime date2 = new System.DateTime(1996, 12, 6, 13, 2, 0);
	public System.TimeSpan deltaDate1;
	public System.TimeSpan deltaDate2;
	public System.TimeSpan deltaDate3;
	public GameObject rift;

	
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

		//UnityEngine.Debug.Log("LEVEL = " + Application.loadedLevel);
		//UnityEngine.Debug.Log(Time.timeSinceLevelLoad);

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
		if (Time.timeSinceLevelLoad>=15)
		{
			if(Application.loadedLevel == 11)
			{
				using (StreamWriter writer = new StreamWriter("midpathshortarrowchest.txt"))
				{
					writer.WriteLine("mid-term view with arrow on screen");
					writer.WriteLine("Picked " + res1 + " with a confidence of " + conf1 + " with a time of " + deltaDate1);
					writer.WriteLine("Picked " + res2 + " with a confidence of " + conf2 + " with a time of " + deltaDate2);
					writer.WriteLine("Picked " + res3 + " with a confidence of " + conf3 + " with a time of " + deltaDate3);
					writer.WriteLine(" ");
				}
			}
			
			if(Application.loadedLevel == 10)
			{
				using (StreamWriter writer = new StreamWriter("midpathshortarrowfloor.txt"))
				{
					writer.WriteLine("mid-term view with arrow on floor");
					writer.WriteLine("Picked " + res1 + " with a confidence of " + conf1 + " with a time of " + deltaDate1);
					writer.WriteLine("Picked " + res2 + " with a confidence of " + conf2 + " with a time of " + deltaDate2);
					writer.WriteLine("Picked " + res3 + " with a confidence of " + conf3 + " with a time of " + deltaDate3);
					writer.WriteLine(" ");;
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
			
			GUI.Box(new Rect(170,250,240,100), "Which way is the robot going to go?\n(From robot's point of view)");
			//
			if(stop1 == 1 && stop2==0 && stop3==0) 
			{
				GUI.Box(new Rect(170,350,240,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				conf1 = GUI.TextField(new Rect(170,    400, 240, 25), conf1, 250);
				//GUI.Box(new Rect(150+500,450,300,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				//conf1 = GUI.TextField(new Rect(150+500,500, 300, 25), conf1, 250);
			}
			if(stop1 == 1 && stop2==1 && stop3==0)
			{
				GUI.Box(new Rect(170,350,240,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				conf2 = GUI.TextField(new Rect(170,    400, 240, 25), conf2, 250);
				//GUI.Box(new Rect(150+500,450,300,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				//conf2 = GUI.TextField(new Rect(150+500,500, 300, 25), conf2, 250);
			}
			if(stop1 == 1 && stop2==1 && stop3==1)
			{
				GUI.Box(new Rect(170,350,240,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				conf3 = GUI.TextField(new Rect(170,    400, 240, 25), conf3, 250);
				//GUI.Box(new Rect(150+500,450,300,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				//conf3 = GUI.TextField(new Rect(150+500,500, 300, 25), conf3, 250);
			}
			
			//
			if(GUI.Button(new Rect(170,300,80,50), "left")) 
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
			if(GUI.Button(new Rect(250,300,80,50), "forward")) 
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
			
			if(GUI.Button(new Rect(330,300,80,50), "right")) 
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
