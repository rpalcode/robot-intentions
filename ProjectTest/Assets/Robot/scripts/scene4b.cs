using UnityEngine;
using System.Collections;
//
using System.IO;
//

public class scene4b : MonoBehaviour {
	//this class is used for mid term view for path 1
	Texture leftarrows;
	Texture rightarrows;
	Texture uparrows;

    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;

	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;

	public GameObject rift;

	//set a variable position for the GUI
	public int xpos = 170;
	public int ypos = 100;
	public int xsize = 240;
	public int ysize = 80;

	//
	//initialize the system date and times
	public System.DateTime date1 = new System.DateTime(1900, 1, 1, 11, 11, 0);
	public System.DateTime date2 = new System.DateTime(1900, 11, 1, 11, 11, 0);
	public System.TimeSpan deltaDate1;
	public System.TimeSpan deltaDate2;
	public System.TimeSpan deltaDate3;

	
	public int stop1=0;
	public int stop2=0;
	public int stop3=0;

	public int pause=0;
	public string res1, res2, res3;

	//
	public string conf1 = " ";
	public string conf2 = " ";
	public string conf3 = " ";
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

	void leftArrow()
	{
		straight.SetActive(false);
		left.SetActive(true);
		right.SetActive(false);

		one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
		four.SetActive(false);
	}
	
	void upArrow()
	{
		straight.SetActive(true);
		left.SetActive(false);
		right.SetActive(false);

		one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
		four.SetActive(false);
	}
	
	void rightArrow()
	{
		straight.SetActive(false);
		left.SetActive(false);
		right.SetActive(true);

		one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
		four.SetActive(false);
	}
	

    private void option1()
    {

		StartSide ();


		if ((Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 2.1) && stop1==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			rift.SetActive(true);
			stop1=1;
		}

		if ((Time.timeSinceLevelLoad > 6.4 && Time.timeSinceLevelLoad < 6.5) && stop2==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			rift.SetActive(true);
			stop2=1;
		}

		if ((Time.timeSinceLevelLoad > 13.3 && Time.timeSinceLevelLoad < 13.4) && stop3==0)
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			rift.SetActive(true);
			stop3=1;
		}

			if (Time.timeSinceLevelLoad > 0 && Time.timeSinceLevelLoad < 1.5)
			{
				one.SetActive(true);
				two.SetActive(false);
				three.SetActive(false);
				four.SetActive(false);
			}
			if (Time.timeSinceLevelLoad > 1.5 && Time.timeSinceLevelLoad < 3)
			{
				one.SetActive(false);
				two.SetActive(false);
				three.SetActive(false);
				four.SetActive(false);
				left.SetActive(true);
			}
			if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 4)
			{
				one.SetActive(false);
				two.SetActive(true);
				three.SetActive(false);
				four.SetActive(false);
			}
			if (Time.timeSinceLevelLoad > 4 && Time.timeSinceLevelLoad < 5)
			{
				one.SetActive(false);
				two.SetActive(true);
				three.SetActive(false);
				four.SetActive(false);
			}
			if (Time.timeSinceLevelLoad > 5 && Time.timeSinceLevelLoad < 11)
			{
				one.SetActive(false);
				two.SetActive(false);
				three.SetActive(false);
				four.SetActive(false);
				straight.SetActive(true);
			}
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 13)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(false);
			four.SetActive(false);
			right.SetActive(true);
		}
			if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 14)
			{
				one.SetActive(false);
				two.SetActive(false);
				three.SetActive(false);
				four.SetActive(false);
				right.SetActive(true);
			}
			if (Time.timeSinceLevelLoad > 14 && Time.timeSinceLevelLoad < 15)
			{
				one.SetActive(false);
				two.SetActive(false);
				three.SetActive(true);
				four.SetActive(false);
			}
			if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 15.5)
			{
				one.SetActive(false);
				two.SetActive(false);
				three.SetActive(false);
				four.SetActive(true);
			}
		if (Time.timeSinceLevelLoad > 15.5 && Time.timeSinceLevelLoad < 22)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
			four.SetActive(false);
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
		if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 16.25)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

		int right1=0; int right2=0; int right3=0;
		if(res1 == "left")
			right1 = 1;
		if(res2 == "forward")
			right2 = 1;
		if(res3 == "right")
			right3 = 1;

		if (Time.timeSinceLevelLoad >= 22)
		{
//
			if(Application.loadedLevel == 5)
			{
				using (StreamWriter writer = new StreamWriter("leftpathmidarrowchest.txt"))
				{
					writer.WriteLine("mid-term view with map on screen");
					writer.WriteLine("Picked " + res1 + " with a confidence of " + conf1 + " with a time of " + deltaDate1 + " " + right1);
					writer.WriteLine("Picked " + res2 + " with a confidence of " + conf2 + " with a time of " + deltaDate2 + " " + right2);
					writer.WriteLine("Picked " + res3 + " with a confidence of " + conf3 + " with a time of " + deltaDate3 + " " + right3);
					writer.WriteLine(" ");
				}
			}
			
			if(Application.loadedLevel == 4)
			{
				using (StreamWriter writer = new StreamWriter("leftpathmidarrowfloor.txt"))
				{
					writer.WriteLine("mid-term view without map on screen");
					writer.WriteLine("Picked " + res1 + " with a confidence of " + conf1 + " with a time of " + deltaDate1 + " " + right1);
					writer.WriteLine("Picked " + res2 + " with a confidence of " + conf2 + " with a time of " + deltaDate2 + " " + right2);
					writer.WriteLine("Picked " + res3 + " with a confidence of " + conf3 + " with a time of " + deltaDate3 + " " + right3);
					writer.WriteLine(" ");
				}
			}
				if(Application.loadedLevel == 16)
				{
					using (StreamWriter writer = new StreamWriter("leftrobotseye.txt"))
					{
					writer.WriteLine("mid-term robot's eye view without map on screen");
					writer.WriteLine("Picked " + res1 + " with a confidence of " + conf1 + " with a time of " + deltaDate1 + " " + right1);
					writer.WriteLine("Picked " + res2 + " with a confidence of " + conf2 + " with a time of " + deltaDate2 + " " + right2);
					writer.WriteLine("Picked " + res3 + " with a confidence of " + conf3 + " with a time of " + deltaDate3 + " " + right3);
					writer.WriteLine(" ");
					}
				}


//
			Application.LoadLevel(2);
		}         
    }


	// Use this for initialization

	void Start () {
		Time.timeScale=1;

		leftarrows = (Texture)Resources.Load("leftarrow");
		rightarrows = (Texture)Resources.Load("rightarrow");
		uparrows = (Texture)Resources.Load("uparrow");
	}

	//
	void OnGUI()
	{
		if(pause==1)
		{
			int choice=0;

			GUI.Box(new Rect(xpos,250,xsize,100), "Which way is the robot going to go?\n(From robot's point of view)");

//
			if(stop1 == 1 && stop2==0 && stop3==0) 
			{
				GUI.Box(new Rect(xpos,350,xsize,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				conf1 = GUI.TextField(new Rect(xpos,    400, xsize, 25), conf1, 250);

			}
			if(stop1 == 1 && stop2==1 && stop3==0)
			{
				GUI.Box(new Rect(xpos,350,xsize,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				conf2 = GUI.TextField(new Rect(xpos,    400, xsize, 25), conf2, 250);
			}
			if(stop1 == 1 && stop2==1 && stop3==1)
			{
				GUI.Box(new Rect(xpos,350,xsize,100), "From a scale of 1-7\nhow confident are you with your answer? ");
				conf3 = GUI.TextField(new Rect(xpos,    400, xsize, 25), conf3, 250);
			}

//

			if(GUI.Button(new Rect(xpos,300,xsize/3,50), leftarrows)) 
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
			if(GUI.Button(new Rect(xpos + (xsize/3),300,xsize/3,50), uparrows)) 
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
			
			if(GUI.Button(new Rect(xpos + 2*(xsize/3),300,80,50), rightarrows)) 
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
				if(GUI.Button(new Rect(xpos, 450, xsize, 25), "Enter")) { enter=1; choice=1; } 
			}

			if(choice==1 && enter==1)
			{
				date2 = System.DateTime.Now;
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


				option1 ();

			}

		}
	}

	void Update () {

        option1();
	}
}
